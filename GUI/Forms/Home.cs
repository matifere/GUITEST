using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI.Forms
{
    public partial class Home : Form
    {
        private Main main;
        
        public Home(int resto, Main mainForm)
        {
            InitializeComponent();
            this.main = mainForm; 
            ChangeStyle(resto);
        }

        private int[] ColoresIntList(int resto) //dejo en una lista todos los colores compatibles para que sea mas facil crear un estilo 
        {

            int size = ThemeColor.ColorList.Count / 4;
            int[] colorListIndex = new int[size];

            for (int i = 0; i < size; i++)
            {
                colorListIndex[i] = main.SelectMod(i, resto);
            }

            return colorListIndex;
        }

        private void ChangeStyle(int resto)
        {
            int[] listaColores = ColoresIntList(resto);

            this.BackColor = main.SelectThemeColor(listaColores[5]);

        }


        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Home_Load(object sender, EventArgs e)
        {

        }
    }
}
