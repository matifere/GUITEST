//using Newtonsoft.Json;
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
