using Google.Cloud.Firestore;
using MaterialSkin.Controls;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI.Forms
{
    public partial class Data : Form
    {
        private FirestoreDb firestoreDb;
        private string UserId = "";

        public Data(string userId)
        {
            UserId = userId;
            InitializeComponent();
            InitializeFirestore();
            LoadProducts();
        }

        private void InitializeFirestore()
        {
            firestoreDb = FirestoreDb.Create("guiexp");
        }

        
        //accede a los datos de usuario (inutil por ahora)
        private async Task<Dictionary<string, object>> ReadUserFromFirestore(string userId)
        {
            try
            {
                DocumentReference docRef = firestoreDb.Collection("users").Document(userId);
                DocumentSnapshot snapshot = await docRef.GetSnapshotAsync();

                if (snapshot.Exists)
                {
                    Dictionary<string, object> userData = snapshot.ToDictionary();
                    return userData;
                }
                else
                {
                    Console.WriteLine("No data found for user with ID: " + userId);
                    return null;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error reading user data: " + ex.Message);
                return null;
            }
        }

        

        

        private async Task SaveProductToFirestore(string userId, string productName, float price, int amount, List<string> tags)
        {
            try
            {
                // Referencia a la colección "products" en Firestore
                CollectionReference productsRef = firestoreDb.Collection("products");

                // Crear un diccionario para el producto
                Dictionary<string, object> product = new Dictionary<string, object>
                {
                    { "UserId", userId },
                    { "Name", productName },
                    { "Price", price },
                    { "Amount", amount },
                    { "Tags", tags }
                };

                // Añadir el producto a la colección
                await productsRef.AddAsync(product);
                Console.WriteLine("Product saved successfully.");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error saving product: " + ex.Message);
            }
        }


        private void AddProductPanel(string productName, double price, List<string> tags, FlowLayoutPanel container, string productId) //crear contenedor
        {
            // Crear un nuevo panel
            MaterialCard productPanel = new MaterialCard();
            productPanel.Size = new Size(348, 100);

            // Crear un Label para el nombre del producto
            MaterialLabel nameLabel = new MaterialLabel();
            nameLabel.Text = "Name: " + productName;
            nameLabel.Location = new Point(10, 10);
            nameLabel.AutoSize = true;
            nameLabel.FontType = MaterialSkin.MaterialSkinManager.fontType.H6;

            // Crear un Label para el precio del producto
            MaterialLabel priceLabel = new MaterialLabel();
            priceLabel.Text = "Price: $" + price;
            priceLabel.Location = new Point(10, 30);
            priceLabel.AutoSize = true;
            priceLabel.FontType = MaterialSkin.MaterialSkinManager.fontType.H6;

            // Crear un Label para las etiquetas del producto
            MaterialLabel tagsLabel = new MaterialLabel();
            tagsLabel.Text = "Tags: " + string.Join(", ", tags);
            tagsLabel.Location = new Point(10, 50);
            tagsLabel.AutoSize = true;
            tagsLabel.FontType = MaterialSkin.MaterialSkinManager.fontType.H6;

            //crear un boton para eliminar el dato
            MaterialButton delateButton = new MaterialButton();
            delateButton.Location = new Point(295, 10);
            delateButton.AutoSize = true;
            delateButton.Icon = BtnDiscard.Icon;
            delateButton.Click += (sender, e) => DelateButton_Click(sender, e, productId);

            // Agregar los Labels al panel del producto
            productPanel.Controls.Add(nameLabel);
            productPanel.Controls.Add(priceLabel);
            productPanel.Controls.Add(tagsLabel);
            productPanel.Controls.Add(delateButton);

            // Agregar el panel del producto al contenedor
            container.Controls.Add(productPanel);
        }
        private void DelateButton_Click(object sender, EventArgs e, string productId)
        {
            MaterialButton clickedButton = sender as MaterialButton;
            if (clickedButton != null)
            {
                if (clickedButton.Parent is MaterialCard parentPanel)
                {
                    this.Controls.Remove(parentPanel); // O container.Controls.Remove(parentPanel) dependiendo de donde lo hayas añadido
                    parentPanel.Dispose();
                    DeleteProduct(productId); // Implementa esta función según tu lógica
                }
            }
        }

        private async void DeleteProduct(string productId)
        {
            DocumentReference productDocRef = firestoreDb.Collection("products").Document(productId);

            // Elimina el documento del producto
            await productDocRef.DeleteAsync();
            Console.WriteLine("Product deleted successfully.");
        }



        private async Task<List<Dictionary<string, object>>> ReadProductsFromFirestore(string userId)
        {
            try
            {
                CollectionReference productsRef = firestoreDb.Collection("products");
                Query query = productsRef.WhereEqualTo("UserId", userId);
                QuerySnapshot snapshot = await query.GetSnapshotAsync();

                List<Dictionary<string, object>> products = new List<Dictionary<string, object>>();
                foreach (DocumentSnapshot doc in snapshot.Documents)
                {
                    Dictionary<string, object> productData = doc.ToDictionary();
                    productData.Add("Id", doc.Id);
                    products.Add(productData);
                }

                return products;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error reading products: " + ex.Message);
                return null;
            }
        }
        private async void LoadProducts()
        {
            List<Dictionary<string, object>> products = await ReadProductsFromFirestore(UserId);

            if (products != null)
            {
                // Limpiar el contenedor antes de agregar nuevos paneles
                FlpContainer.Controls.Clear();

                foreach (var product in products)
                {
                    string productId = product.ContainsKey("Id") ? product["Id"].ToString() : "N/A";
                    string productName = product.ContainsKey("Name") ? product["Name"].ToString() : "N/A";
                    double price = product.ContainsKey("Price") ? Convert.ToDouble(product["Price"]) : 0.0;
                    // Convertir la lista de objetos a una lista de cadenas
                    List<object> tagsObjectList = product.ContainsKey("Tags") ? (List<object>)product["Tags"] : new List<object>();
                    List<string> tags = tagsObjectList.Select(tag => tag.ToString()).ToList();

                    // Llamar a la función para crear y agregar un panel de producto
                    AddProductPanel(productName, price, tags, FlpContainer, productId);
                }
            }
        }

        private async void Data_Load(object sender, EventArgs e)
        {
        }
        private void LbDataPlus_Click(object sender, EventArgs e)
        {

        }

        private void BtnConsult_Click(object sender, EventArgs e)
        {

        }

        private void materialLabel2_Click(object sender, EventArgs e)
        {

        }

        private void materialLabel3_Click(object sender, EventArgs e)
        {

        }

        private void BtnSaveProduct_Click(object sender, EventArgs e)
        {
            
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            try
            {
                string productName = TbName.Text;
                string priceS = TbPrice.Text;
                string amountS = TbAmount.Text;

                float price = float.Parse(priceS);
                int amount = int.Parse(amountS);

                List<String> tags = new List<String>() { CbColor.Text, CbGender.Text, CbBrand.Text };

                SaveProductToFirestore(UserId, productName, price, amount, tags);

                LoadProducts();
            }
            catch
            {
                MessageBox.Show("Data error"); return;
            }
            
        }

        private void BtnDiscard_Click(object sender, EventArgs e)
        {
            TbName.Text = string.Empty;
            TbPrice.Text = string.Empty;
            TbAmount.Text = string.Empty;
        }
    }
}
