﻿//using Newtonsoft.Json;
using Mysqlx.Session;
using System;
using System.Drawing.Text;
using System.Windows.Forms;


namespace GUI.Forms
{
    public partial class Settings : Form
    {
        private UserSettings userSettings;
        private int LPSize; //tamaño del panel izq
        private Panel LP;
        private Button homebtn;
        private Button settingsbtn;
        private Button notesbtn;
        private Button databtn;
        private Main main;

        private bool maximize = false;
        private bool autoSave = false;


        public Settings(Panel LPS, Button home, Button settings, Button notes, Button data, Main mainForm, int resto)
        {
            
            //left panel size
            LPSize = LPS.Width;
            LP = LPS;


            //asigno referencia a los botones del menu
            homebtn = home;
            settingsbtn = settings;
            databtn = data;
            notesbtn = notes;

            InitializeComponent();
            LoadSettings();
            this.main = mainForm;
            ChangeStyle(resto);

            //auto save
            if(userSettings.AutoSaveAndApply != null)
            {

                CbSavAplAuto.Checked = userSettings.AutoSaveAndApply;
                UserSettingsManager.SaveUserSettings(userSettings);
            }
            else
            {
                userSettings.AutoSaveAndApply = autoSave;
                UserSettingsManager.SaveUserSettings(userSettings);

            }
        }

        #region color
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

            this.BackColor = main.SelectThemeColor(listaColores[2]);
            SaveLPSBtn.BackColor = main.SelectThemeColor(listaColores[2]);
            LeftPanelSize.BackColor = main.SelectThemeColor(listaColores[1]);

        }
        #endregion

        public void LoadSettings()
        {
            userSettings = UserSettingsManager.LoadUserSettings();
        }

        public void ApplySettings()
        {
            //this.Text = userSettings.UserName;
            
            // Aplica más configuraciones según sea necesario
            LP.Width = userSettings.PanelWidth;

            if (userSettings.PanelWidth < 150)
            {
                homebtn.Text = "";
                settingsbtn.Text = "";
                notesbtn.Text = "";
                databtn.Text = "";
            }
            else
            {
                homebtn.Text = "Home";
                settingsbtn.Text = "Settings";
                notesbtn.Text = "Notes";
                databtn.Text = "Data";
            }
            if (userSettings.PanelWidth < 40)
            {
                LP.Width = 40;
            }


            //cargar el alto y ancho
            if (!maximize && userSettings.WindowHeight >= 300 && userSettings.WindowHeight >= 300)
            {
                main.Width = userSettings.WindowWidth;
                main.Height = userSettings.WindowHeight;
                main.WindowState = FormWindowState.Normal;
            }
            else if(maximize)
            {
                main.WindowState = FormWindowState.Maximized;
            }
            
            

        }

        public void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
           // SaveLPSSettings();
        }

        public void SaveLPSSettings(string size)
        {
            //userSettings.UserName = this.Text;
            //userSettings.WindowWidth = this.Width;
            //userSettings.WindowHeight = this.Height;
            try
            {
                userSettings.PanelWidth = Int32.Parse(size);

            }
            catch
            {

            }
            UserSettingsManager.SaveUserSettings(userSettings); //guardar\

            if (userSettings.AutoSaveAndApply)
            {
                ApplySettings();
            }
        }

        private void SaveBtn_Click(object sender, EventArgs e) //save all                     
        {
            SaveLPSSettings(LeftPanelSize.Text);
        }

        private void ApplyBtn_Click(object sender, EventArgs e)
        {
            ApplySettings();
        }

        private void SaveBtn_Click_1(object sender, EventArgs e) //save lps
        {
            SaveLPSSettings(LeftPanelSize.Text);
        }

        private void ResetSetBtn_Click(object sender, EventArgs e)
        {
            userSettings.PanelWidth = 187;
            userSettings.WindowHeight = 579;
            userSettings.WindowWidth = 976;
            maximize = false;
            userSettings.Maximize = maximize;
            ApplySettings();
        }

        private void SaveWinSize_Click(object sender, EventArgs e)
        /*
         Record
         Maximized
         Default 976 579
         */

        {
            if (SelectWin.Text == "Default")
            {
                //if(autosave)
                //main.Width = 976;
                //main.Height = 579;

                userSettings.WindowHeight = 579;
                userSettings.WindowWidth = 976;
                maximize = false;
                userSettings.Maximize = maximize;
            }

            else if (SelectWin.Text == "Maximized")
            {
                maximize = true;
                userSettings.Maximize = maximize;
            }

            else if(SelectWin.Text == "Record")
            {
                maximize = false;
                userSettings.Maximize = maximize;
                userSettings.WindowWidth = main.Width;
                userSettings.WindowHeight = main.Height;
            }

            else if(SelectWin.Text != "Default" || SelectWin.Text == "Maximized" || SelectWin.Text == "Record")
            {
                MessageBox.Show("please choose an option", "Error");
            }
            UserSettingsManager.SaveUserSettings(userSettings);

            if (userSettings.AutoSaveAndApply)
            {
                ApplySettings();
            }

        }

        private void CbSavAplAuto_CheckedChanged(object sender, EventArgs e)
        {
            userSettings.AutoSaveAndApply = CbSavAplAuto.Checked;
            UserSettingsManager.SaveUserSettings(userSettings);
        }
    }

}
