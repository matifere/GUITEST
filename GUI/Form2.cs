using GUI.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public partial class Main : Form
    {
        //campos
        private Menu MenuForm;
        private UserSettings userSettings;

        private Button currentButton;
        //private Random random;
        //private int tempIndex;
        private Form activeForm;
        private Settings settingsForm;
        private string globalPic;
        private Form closeChild;
        private Color mainTitleColor;
        private Color UserColor;

        public Main(Menu form1 ,string name, string email, string pictureUrl)
        {
            InitializeComponent();
            this.MenuForm = form1;
            
            LoadSettings();
            ApplySettings();
            labelName.Text = name;
            labelEmail.Text = email;
            LoadProfileImage(pictureUrl);
            globalPic = pictureUrl;
            //random = new Random();

            mainTitleColor = TitlePanel.BackColor;
            UserColor = PanelLogData.BackColor;
        }

        public void LoadSettings()
        {
            userSettings = UserSettingsManager.LoadUserSettings();
        }

        public void ApplySettings()
        {
            //this.Text = userSettings.UserName;
            //this.Width = userSettings.WindowWidth;
            //this.Height = userSettings.WindowHeight;
            // Aplica más configuraciones según sea necesario
            PanelSideMenu.Width = userSettings.PanelWidth;

            //dejar de mostrar texto en los botones si son muy chicos y no permitir que sean mas chicos que el icono
            if(userSettings.PanelWidth < 150)
            {
                BtnHome.Text = "";
                SettingsBtn.Text = "";
                NotesBtn.Text = "";
                DataBtn.Text = "";
            }
            if (userSettings.PanelWidth < 40)
            {
                PanelSideMenu.Width = 40;
            }


        }

        //Mantener texto centrado
        FormWindowState LastwinState = FormWindowState.Normal;
        
        private void MenuLabelResize(object sender, EventArgs e)
        {
            //cuando cambie de estado
            if (WindowState != LastwinState)
            {
                LastwinState = WindowState;
                TitleLabel.Left = ((this.ClientSize.Width - TitleLabel.Width - PanelSideMenu.Width) / 2);
            }
        }

        //Arreglar bug cierre
        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            base.OnFormClosing(e);

            // Cerrar Form1 cuando se cierre Form2
            MenuForm?.Close();
        }

        private async void LoadProfileImage(string imageUrl)
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
        private void Form2_Load(object sender, EventArgs e)
        {
            
        }

        private void buttonLogout_Click(object sender, EventArgs e)
        {
            MenuForm?.Show();
            this.Hide();
        }

        public Color SelectThemeColor(int colorIndex) //lo que está comentado es para poner el color en aleatorio
        {
            //int index = random.Next(ThemeColor.ColorList.Count);
            //while(tempIndex == index)
            //{
            //    index = random.Next(ThemeColor.ColorList.Count);
            //}
            //tempIndex = index;
            string color = ThemeColor.ColorList[colorIndex];
            return ColorTranslator.FromHtml(color);
        }

        //para respetar el color vamos a usar mod 4
        public int SelectMod(int cociente, int resto)
        {
            if (cociente > ThemeColor.ColorList.Count)
            {
                return 0;
            }
            else
            {
                return (cociente * 4) + resto;
            }
        }

        private void ActiveButton(object btnSender, int colorCociente, int colorResto)
        {
            if(btnSender != null)
            {
                if (currentButton != (Button)btnSender)
                {
                    DisableButton();
                    Color color = SelectThemeColor(SelectMod(colorCociente, colorResto));
                    currentButton = (Button)btnSender;
                    currentButton.BackColor = color;
                    currentButton.ForeColor = Color.White; //ojo con esto si queres poner colores claros
                    TitlePanel.BackColor = color;
                    PanelLogData.BackColor = ThemeColor.ChangeColorBrightness(color, -0.3);
                }
            }
            
        }
        private void DisableButton()
        {
            foreach (Control previousBtn in PanelSideMenu.Controls)
            {
                if (previousBtn.GetType() == typeof(Button))
                {
                    previousBtn.BackColor = Color.FromArgb(63, 64, 63);
                    previousBtn.ForeColor = Color.White;

                }
            }
        }

        private void OpenChildForm(Form childForm, Object btnSender, int colorCociente, int colorResto)
        {
            if(activeForm !=  null)
            {
                activeForm.Close();
            }
            ActiveButton(btnSender, colorCociente, colorResto);
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None; //le sacamos los bordes al form hijo
            childForm.Dock = DockStyle.Fill; //hacemos que llene el panel
            this.FormShow.Controls.Add(childForm); //agrego el control del childform
            this.FormShow.Tag = childForm;
            childForm.BringToFront();
            childForm.Show(); //muestro el form en el panel
            TitleLabel.Text = childForm.Text; //cambiar el nombre del titulo (el del panel de arriba)
            closeChild = childForm;
        }

        #region nonuse
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
        #endregion nonuse

        private void BtnHome_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.Home(0, this), sender, 2, 0); // cambia el primer entero para seguir dentro de la misma paleta
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.Settings(PanelSideMenu, BtnHome, SettingsBtn, NotesBtn, DataBtn, this, 1), sender, 0, 1);


        }

        private void button2_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.Notes(), sender, 3, 2);



        }

        private void button3_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.Data(), sender, 3, 3);
        }

        private void TitleLabel_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        //cierra la ventana cuando se preciona esc
        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (keyData == Keys.Escape)
            {
                if(closeChild != null)
                {
                    closeChild.Close();
                    PanelLogData.BackColor = UserColor;
                    TitlePanel.BackColor = mainTitleColor;
                    TitleLabel.Text = "GUITEST";
                }
                return true;
            }

            return base.ProcessCmdKey(ref msg, keyData);
        }
    }
}
