using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RpiUsbSim.Contracts
{
    internal interface IWifiConnector
    {
        IEnumerable<string> EnumerateAvailableSSIDs();
        void CreateWifiProfile(string ssid, string password);
        void RemoveWifiProfile(string profile);
        bool IsSelectedSSIDAvailable(string ssid);
        string GetCurrentConnectedSSID();
        void ConnectToSelectedSSID(string ssid);
        bool IsSSIDAlreadyConnected();
    }
}
