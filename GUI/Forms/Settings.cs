//using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.Json;
using System.IO;

namespace GUI.Forms
{
    public partial class Settings : Form
    {
        private UserSettings userSettings;
        public Settings()
        {
            InitializeComponent();
            LoadSettings();
            ApplySettings();
        }

        private void LoadSettings()
        {
            userSettings = UserSettingsManager.LoadUserSettings();
        }

        private void ApplySettings()
        {
            this.Text = userSettings.UserName;
            this.Width = userSettings.WindowWidth;
            this.Height = userSettings.WindowHeight;
            // Aplica más configuraciones según sea necesario
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            SaveSettings();
        }

        private void SaveSettings()
        {
            userSettings.UserName = this.Text;
            userSettings.WindowWidth = this.Width;
            userSettings.WindowHeight = this.Height;
            // Guarda más configuraciones según sea necesario

            UserSettingsManager.SaveUserSettings(userSettings);
        }


    }

}
