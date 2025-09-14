using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RpiUsbSim.Contracts
{
    internal interface IRegexValidator
    {
        bool ValidateIPAddress(string ipAddress);
        bool ValidatePortNumber(string portNumber);
        bool ValidateUsername(string username);
        bool ValidateKey(string key);
        bool ValidateLog(string log);
        bool ValidateWiFiPassword(string password);
        bool ValidateSSID(string ssid);
    }
}
