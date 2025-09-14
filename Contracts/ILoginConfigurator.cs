using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RpiUsbSim.Contracts
{
    public class WiFi
    {
        public string SSID { get; set; }
        public string Psk { get; set; }
    }

    public class SshConfig
    {
        public string IP { get; set; }
        public string Username { get; set; }
        public string Key { get; set; }
        public int Port { get; set; }
        public string Log { get; set; }
    }

    public class ConfigModel
    {
        public SshConfig SSHConf { get; set; }
        public WiFi WiFi { get; set; }
    }

    internal interface ILoginConfigurator
    {
        string ConfigFile { get; set; }

        bool IsFileExisting(string configFile);
        ConfigModel LoadConfiguration(string configFile);
        void SaveConfiguration(string configFile, ConfigModel config);

        bool IsConfigValid(ConfigModel config);


    }
}
