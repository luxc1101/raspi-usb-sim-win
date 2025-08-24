using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using RpiUsbSim.Contracts;

namespace RpiUsbSim
{
    internal class RegexValidation : IRegexValidator
    {
        public bool validateIPAddress(string ipAddress)
        {
            ipAddress = ipAddress.Replace(',', '.');

            if (IsValidIPAddress(ipAddress) == false)
            {
                return false;
            }
            return true;
        }
        public bool validatePortNumber(string portNumber)
        {
            if (int.TryParse(portNumber, out int portNr))
            {
                if (portNr < 0 || portNr > 65535)
                {
                    return false;
                }
                return true;
            }
            // Debug.Assert(false, "Port number validation failed. Expected a valid integer between 0 and 65535.");
            return false;
        }
        public bool validateUsername(string username)
        {
            if (string.IsNullOrWhiteSpace(username))
            {
                // Debug.Assert(false, "Username validation failed. Expected a non-empty string.");
                return false;
            }
            return true;
        }
        public bool validateKey(string key)
        {
            if (string.IsNullOrWhiteSpace(key))
            {
                return false;
            }
            return true;
        }
        public bool validateLog(string log)
        {
            if (string.IsNullOrWhiteSpace(log))
            {
                return false;
            }

            else if (!log.Trim().EndsWith(".log", StringComparison.OrdinalIgnoreCase)) 
            {
                return false;
            }
            return true;
        }

        public bool validateWiFiPassword(string password)
        {
            if (string.IsNullOrWhiteSpace(password))
            {
                return false;
            }
            // Assuming WiFi passwords can be any non-empty string
            return true;
        }

        public bool validateSSID(string ssid)
        {
            if (string.IsNullOrWhiteSpace(ssid))
            {
                return false;
            }
            return true;
        }
        private bool IsValidIPAddress(string ipAddress)
        {
            string ipv4Pattern = @"^(?:(?:25[0-5]|2[0-4][0-9]|[01]?[0-9][0-9]?)\.){3}(?:25[0-5]|2[0-4][0-9]|[01]?[0-9][0-9]?)$";

            if (string.IsNullOrWhiteSpace(ipAddress))
            {
                Debug.Assert(false, "IP address validation failed. Expected a non-empty string.");
                return false;
            }
            return Regex.IsMatch(ipAddress.Trim(), ipv4Pattern);
        }
    }
}
