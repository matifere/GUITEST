using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using Google.Apis.Auth.OAuth2;
using Google.Apis.Oauth2.v2;
using Google.Apis.Plus.v1;
using Google.Apis.Plus.v1.Data;
using Google.Apis.Services;
using Google.Apis.Util.Store;
using Google.Cloud.Firestore;
using System.Net.Http;
using System.Drawing;
using static Google.Rpc.Context.AttributeContext.Types;
using System.Security.Cryptography.X509Certificates;
using Svg;
using System.IO;
using System.Diagnostics;

namespace GUI
{
    public partial class Menu : Form
    {
        private UserCredential credential;
        private FirestoreDb firestoreDb;
        Image defaultImage = null;

        public Menu()
        {
            InitializeComponent();
            
            InitializeFirestore();

            ShowSvgImage("cat-solid", CatPic);
            //ShowSvgImage("right-from-bracket-solid", LogOutPic);
            //ShowSvgImage("google", LogInPic);
            //ShowSvgImageInBtn("google", buttonLogin);
            //ShowSvgImageInBtn("right-from-bracket-solid", buttonLogout);


        }



        private void ShowSvgImage(string name, PictureBox imagen)
        {
            string appDirectory = AppDomain.CurrentDomain.BaseDirectory;
            string svgPath = Path.Combine(appDirectory, "imagenes", name + ".svg");
            try
            {
                var svgDocument = SvgDocument.Open(svgPath);

                var bitmap = svgDocument.Draw();

                imagen.Image = bitmap;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar la imagen SVG: {ex.Message}");
            }
        }
        //private void ShowSvgImageInBtn(string name, Button boton)
        //{
        //    string appDirectory = AppDomain.CurrentDomain.BaseDirectory;
        //    string svgPath = Path.Combine(appDirectory, "imagenes", name + ".svg");
        //    try
        //    {
        //        var svgDocument = SvgDocument.Open(svgPath);

        //        var bitmap = svgDocument.Draw();

        //        ResizeImage(bitmap, boton.Height, boton.Height);

        //        boton.Image = bitmap;
                
        //    }
        //    catch (Exception ex)
        //    {
        //        MessageBox.Show($"Error al cargar la imagen SVG: {ex.Message}");
        //    }
        //}

        //private Bitmap ResizeImage(Image image, int newWidth, int newHeight)
        //{
        //    Bitmap resizedImage = new Bitmap(newWidth, newHeight);
        //    using (Graphics g = Graphics.FromImage(resizedImage))
        //    {
        //        g.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.HighQualityBicubic;
        //        g.DrawImage(image, 0, 0, newWidth, newHeight);
        //    }

        //    return resizedImage;
        //}

        private void InitializeFirestore()
        {
            firestoreDb = FirestoreDb.Create("guiexp"); // Reemplaza "YOUR_PROJECT_ID" con tu ID de proyecto de Firebase
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
        }

        private void nro1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        



        private async void buttonLogin_Click(object sender, EventArgs e)
        {
            defaultImage = Imagen.Image;
            string[] scopes = { Oauth2Service.Scope.UserinfoProfile, Oauth2Service.Scope.UserinfoEmail };

            using (var stream = new System.IO.FileStream("credential.json", System.IO.FileMode.Open, System.IO.FileAccess.Read))
            {
                string credPath = "token.json";
                credential = await GoogleWebAuthorizationBroker.AuthorizeAsync(
                    GoogleClientSecrets.FromStream(stream).Secrets,
                    scopes,
                    "user",
                    CancellationToken.None,
                    new FileDataStore(credPath, true));
            }

            if (credential != null)
            {
                Oauth2Service service = new Oauth2Service(new BaseClientService.Initializer()
                {
                    HttpClientInitializer = credential,
                    ApplicationName = "Google Login App"
                });

                var userInfo = await service.Userinfo.Get().ExecuteAsync();

                if (userInfo != null)
                {
                    // Actualizar etiquetas con información del usuario
                    labelName.Text = $"{userInfo.Name}";
                    labelEmail.Text = $"{userInfo.Email}";

                    //centrar el texto
                    labelName.Left = (this.ClientSize.Width - labelName.Width) / 2;
                    labelEmail.Left = (this.ClientSize.Width - labelEmail.Width) / 2;


                    await LoadProfileImageAsync(userInfo.Picture);
                    // Guardar información del usuario en Firestore
                    await SaveUserToFirestore(userInfo);

                    Form2 form2 = new Form2(this, userInfo.Name, userInfo.Email, userInfo.Picture);
                    form2.Show();
                    this.Hide();
                }
            }
        }
        private async Task LoadProfileImageAsync(string imageUrl)
        {
            using (HttpClient client = new HttpClient())
            {
                var response = await client.GetAsync(imageUrl);
                if (response.IsSuccessStatusCode)
                {
                    var stream = await response.Content.ReadAsStreamAsync();
                    Imagen.Image = Image.FromStream(stream);
                }
            }
        }

        private async Task SaveUserToFirestore(Google.Apis.Oauth2.v2.Data.Userinfo userInfo)
        {
            CollectionReference usersRef = firestoreDb.Collection("users");
            DocumentReference docRef = usersRef.Document(userInfo.Id);
            Dictionary<string, object> user = new Dictionary<string, object>
            {
                { "Name", userInfo.Name },
                { "Email", userInfo.Email },
                { "Picture", userInfo.Picture }
            };
            await docRef.SetAsync(user);
        }

        private void buttonLogout_Click(object sender, EventArgs e)
        {
            // Revocar token y eliminar la información de credenciales
            if (credential != null)
            {
                credential.RevokeTokenAsync(CancellationToken.None).Wait();

                // Eliminar información de las credenciales almacenadas
                string credPath = "token.json";
                if (System.IO.Directory.Exists(credPath))
                {
                    System.IO.Directory.Delete(credPath, true);
                }

                // Limpiar las etiquetas de información del usuario
                labelName.Text = "Name:";
                labelEmail.Text = "Email:";
                Imagen.Image = defaultImage;

                MessageBox.Show("Sesión cerrada con éxito.");
            }
        }

        private void labelName_Click(object sender, EventArgs e)
        {

        }

        private void Image_Click(object sender, EventArgs e)
        {

        }

        private void Menu_Load(object sender, EventArgs e)
        {

        }

        private void Cross_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
