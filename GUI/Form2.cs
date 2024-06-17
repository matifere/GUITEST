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
        private Menu form1;

        private Button currentButton;
        //private Random random;
        //private int tempIndex;
        private Form activeForm;
        private string globalPic;

        public Main(Menu form1 ,string name, string email, string pictureUrl)
        {
            InitializeComponent();
            this.form1 = form1;

            labelName.Text = name;
            labelEmail.Text = email;
            LoadProfileImage(pictureUrl);
            globalPic = pictureUrl;
            //random = new Random();
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
            form1?.Close();
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
            form1?.Show();
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
            OpenChildForm(new Forms.Home(0, form1, labelName.Text, labelEmail.Text, globalPic), sender, 2, 0); // cambia el primer entero para seguir dentro de la misma paleta
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.Settings(), sender, 3, 1);


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
    }
}
