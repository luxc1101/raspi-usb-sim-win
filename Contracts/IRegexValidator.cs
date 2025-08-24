using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RpiUsbSim.Contracts
{
    internal interface IRegexValidator
    {
        bool validateIPAddress(string ipAddress);
        bool validatePortNumber(string portNumber);
        bool validateUsername(string username);
        bool validateKey(string key);
        bool validateLog(string log);
        bool validateWiFiPassword(string password);
        bool validateSSID(string ssid);
    }
}
