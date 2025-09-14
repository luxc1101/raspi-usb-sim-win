using RpiUsbSim.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace RpiUsbSim.SSHLoginDialog
{
    internal class LoginConfiguration:ILoginConfigurator 
    {

        public LoginConfiguration() {}
        public string ConfigFile { get; set; } = Path.GetFullPath(
            Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"..\..\..\", "Configuration", "Config.json")
            );

        public bool IsFileExisting(string configFile) { return File.Exists(configFile); }

        public ConfigModel LoadConfiguration(string configFile)
        {
            string jsonConfigurationString = File.ReadAllText(configFile);
            ConfigModel dictConfiguration = JsonSerializer.Deserialize<ConfigModel>(jsonConfigurationString);
            return dictConfiguration;
        }
        public void SaveConfiguration(string configFile, ConfigModel config)
        {
            var updatedConfigurationJson = JsonSerializer.Serialize(config, new JsonSerializerOptions { WriteIndented = true });
            File.WriteAllText(configFile, updatedConfigurationJson);
        }

        public bool IsConfigValid(ConfigModel config)
        {
            if (config == null || config.SSHConf == null || config.WiFi == null)
            {
                return false;
            }
            return true;
        }
    }
}
