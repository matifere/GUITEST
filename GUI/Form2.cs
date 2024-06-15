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
        private Random random;
        private int tempIndex;


        public Main(Menu form1 ,string name, string email, string pictureUrl)
        {
            InitializeComponent();
            this.form1 = form1;

            labelName.Text = name;
            labelEmail.Text = email;
            LoadProfileImage(pictureUrl);
            random = new Random();
        }

        protected override void OnResize(EventArgs e)
        {
            TitleLabel.Left = ((this.ClientSize.Width - TitleLabel.Width - PanelSideMenu.Width) / 2) ;

            base.OnResize(e);
        }
        //protected override void 

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
            this.Close();
        }

        private Color SelectThemeColor()
        {
            int index = random.Next(ThemeColor.ColorList.Count);
            while(tempIndex == index)
            {
                index = random.Next(ThemeColor.ColorList.Count);
            }
            tempIndex = index;
            string color = ThemeColor.ColorList[index];
            return ColorTranslator.FromHtml(color);
        }

        private void ActiveButton(object btnSender)
        {
            if(btnSender != null)
            {
                if (currentButton != (Button)btnSender)
                {
                    DisableButton();
                    Color color = SelectThemeColor();
                    currentButton = (Button)btnSender;
                    currentButton.BackColor = color;
                    currentButton.ForeColor = Color.White; //ojo con esto si queres poner colores claros
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
            ActiveButton(sender);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ActiveButton(sender);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            ActiveButton(sender);


        }

        private void button3_Click(object sender, EventArgs e)
        {
            ActiveButton(sender);
        }

        private void TitleLabel_Click(object sender, EventArgs e)
        {

        }
    }
}
