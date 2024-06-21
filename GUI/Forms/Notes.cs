using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI.Forms
{
    public partial class Notes : Form
    {
        private Main main;
        public Notes(Main main, int resto)
        {
            InitializeComponent();
            this.main = main;
            ChangeStyle(resto);
        }

        private void Notes_Load(object sender, EventArgs e)
        {

        }

        #region Color
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

            this.BackColor = main.SelectThemeColor(listaColores[0]);

        }
        #endregion

        private void BtnFont_Click(object sender, EventArgs e)
        {
            if(FdFont.ShowDialog() == DialogResult.OK)
            {
                TbNote.Font = FdFont.Font;
            }
        }

        private void BtnFontColor_Click(object sender, EventArgs e)
        {
            if(CdFontColor.ShowDialog() == DialogResult.OK)
            {
                TbNote.ForeColor = CdFontColor.Color;
            }
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            if(SfdSave.ShowDialog() == DialogResult.OK)
            {
                if (Extend(SfdSave.FileName))
                {
                    File.WriteAllText(SfdSave.FileName, TbNote.Text);
                }
                else
                {
                    File.WriteAllText(SfdSave.FileName + ".txt", TbNote.Text);

                }
            }
        }

        //si filename contiene un punto dejarlo asi, si no poner .txt al final
        private bool Extend(string file)
        {
            return file.Contains(".");
        }


        private void BtnOpen_Click(object sender, EventArgs e)
        {
            if(OfdOpen.ShowDialog() == DialogResult.OK)
            {
                if(File.Exists(OfdOpen.FileName))
                {
                    TbNote.Text = File.ReadAllText(OfdOpen.FileName);
                }
            }
        }
    }
}
