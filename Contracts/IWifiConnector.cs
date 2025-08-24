using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RpiUsbSim.Contracts
{
    internal interface IWifiConnector
    {
        void CreateWifiProfile(string ssid, string password);
        void RemoveWifiProfile(string profile);
        bool isSSIDAvailable(string ssid);
        string GetConnectedSSID();
        void ConnectToWifi(string ssid);
        bool isWifiConnected();
    }
}
