//using Newtonsoft.Json;
using System;
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

        public Settings(Panel LPS, Button home, Button settings, Button notes, Button data)
        {
            LPSize = LPS.Width;
            LP = LPS;
            
            //asigno referencia a los botones del menu
            homebtn = home;
            settingsbtn = settings;
            databtn = data;
            notesbtn = notes;

            InitializeComponent();
            LoadSettings();
            //ApplySettings();
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
            UserSettingsManager.SaveUserSettings(userSettings);
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
            ApplySettings();
        }
    }

}
