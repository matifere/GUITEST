using System;
using System.IO;
using GUI;
using Newtonsoft.Json;

public static class UserSettingsManager
{
    private static readonly string ConfigFolder = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), "MyAppSettings");
    private static readonly string ConfigFilePath = Path.Combine(ConfigFolder, "userSettings.json");

    static UserSettingsManager()
    {
        // Crear la carpeta si no existe
        if (!Directory.Exists(ConfigFolder))
        {
            Directory.CreateDirectory(ConfigFolder);
        }
    }

    public static void SaveUserSettings(UserSettings settings)
    {
        var json = JsonConvert.SerializeObject(settings, Formatting.Indented);
        File.WriteAllText(ConfigFilePath, json);
    }

    public static UserSettings LoadUserSettings()
    {
        if (File.Exists(ConfigFilePath))
        {
            var json = File.ReadAllText(ConfigFilePath);
            return JsonConvert.DeserializeObject<UserSettings>(json);
        }
        else
        {
            return new UserSettings(); // Retorna una configuración por defecto si el archivo no existe
        }
    }
}
