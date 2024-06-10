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
    public partial class Form2 : Form
    {
        private Menu form1;
        private string labelText;
        private string dataText;

        public Form2(Menu form1 ,string name, string email, string pictureUrl)
        {
            InitializeComponent();
            this.form1 = form1;

            labelName.Text = name;
            labelEmail.Text = email;
            LoadProfileImage(pictureUrl);
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
            if (form1 != null)
            {
                form1.Show();
            }
            this.Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            labelText = LabelDataSave.Text;
            dataText = DataDataSave.Text;
            //MessageBox.Show(labelText, dataText);
            DataList.Items.Add(labelText, dataText);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
