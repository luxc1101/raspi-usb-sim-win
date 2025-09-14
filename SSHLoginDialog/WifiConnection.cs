using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RpiUsbSim.Contracts;

namespace RpiUsbSim.SSHLoginDialog
{
    internal class WifiConnection : IWifiConnector
    {

        public WifiConnection() { }

        public IEnumerable<string> EnumerateAvailableSSIDs()
        {
            var ssids = new List<string>();
            var process = new Process
            {
                StartInfo = new ProcessStartInfo
                {
                    FileName = "cmd.exe",
                    Arguments = "/C netsh wlan show networks",
                    RedirectStandardOutput = true,
                    UseShellExecute = false,
                    CreateNoWindow = true
                }
            };
            process.Start();
            string output = process.StandardOutput.ReadToEnd();
            process.WaitForExit();
            foreach (var line in output.Split('\n'))
            {
                var trimmedLine = line.Trim();
                if (trimmedLine.StartsWith("SSID", StringComparison.OrdinalIgnoreCase))
                {
                    var parts = trimmedLine.Split(':');
                    if (parts.Length > 1)
                    {
                        ssids.Add(parts[1].Trim());
                    }
                }
            }
            return ssids;
        }

        public void CreateWifiProfile(string ssid, string password)
        {
            // Create a Wi-Fi profile XML string
            string profileXml = $@"
                <WLANProfile xmlns='http://www.microsoft.com/networking/WLAN/profile/v1'>
                    <name>{ssid}</name>
                    <SSIDConfig>
                        <SSID>
                            <name>{ssid}</name>
                        </SSID>
                    </SSIDConfig>
                    <connectionType>ESS</connectionType>
                    <connectionMode>auto</connectionMode>
                    <MSM>
                        <security>
                            <authEncryption>
                                <authentication>WPA2PSK</authentication>
                                <encryption>AES</encryption>
                                <useOneX>false</useOneX>
                            </authEncryption>
                            <sharedKey>
                                <keyType>passPhrase</keyType>
                                <protected>false</protected>
                                <keyMaterial>{password}</keyMaterial>
                            </sharedKey>
                        </security>
                    </MSM>
                </WLANProfile>";
            // Save the profile to a temporary file
            File.WriteAllText("WiFiProfile.xml", profileXml);
        }

        public void RemoveWifiProfile(string profile)
        {
            try
            {
                if (File.Exists(profile))
                {
                    File.Delete(profile);
                }
            }
            catch (FileNotFoundException)
            {
                throw;
            }
            catch(Exception)
            {
                throw;
            }
        }

        public bool IsSelectedSSIDAvailable(string ssid)
        {
            var process = new Process
            {
                StartInfo = new ProcessStartInfo
                {
                    FileName = "cmd.exe",
                    Arguments = $"/c netsh wlan show networks | findstr \"{ssid}\"",
                    RedirectStandardOutput = true,
                    UseShellExecute = false,
                    CreateNoWindow = true
                }
            };
            process.Start();
            string output = process.StandardOutput.ReadToEnd();
            process.WaitForExit();
            return !string.IsNullOrWhiteSpace(output);
        }

        public string GetCurrentConnectedSSID()
        {
            var process = new Process
            {
                StartInfo = new ProcessStartInfo
                {
                    FileName = "cmd.exe",
                    Arguments = "/C netsh wlan show interfaces | findstr \"SSID\"",
                    RedirectStandardOutput = true,
                    UseShellExecute = false,
                    CreateNoWindow = true
                }
            }; 
            process.Start();
            string output = process.StandardOutput.ReadToEnd();
            process.WaitForExit();
            foreach (var line in output.Split('\n'))
            {
                var trimmedLine = line.Trim();
                if (trimmedLine.StartsWith("SSID", StringComparison.OrdinalIgnoreCase))
                {
                    var parts = trimmedLine.Split(':');
                    if (parts.Length > 1)
                    {
                        return parts[1].Trim();
                    }
                }
            }
            return string.Empty;
        }   

        public void ConnectToSelectedSSID(string ssid)
        {
            var addProfileProcess = new Process
            {
                StartInfo = new ProcessStartInfo
                {
                    FileName = "cmd.exe",
                    Arguments = "/C netsh wlan add profile filename=\"WiFiProfile.xml\"",
                    RedirectStandardOutput = true,
                    UseShellExecute = false,
                    CreateNoWindow = true
                }
            };
            addProfileProcess.Start();
            addProfileProcess.WaitForExit();

            var connectProcess = new Process
            {
                StartInfo = new ProcessStartInfo
                {
                    FileName = "cmd.exe",
                    Arguments = $"/C netsh wlan connect name=\"{ssid}\"",
                    RedirectStandardOutput = true,
                    UseShellExecute = false,
                    CreateNoWindow = true
                }
            };
            connectProcess.Start();
            connectProcess.WaitForExit();
        }

        public bool IsSSIDAlreadyConnected()
        {
            string cmd = @"netsh wlan show interfaces | Findstr /c:""Signal"" && Echo Online || Echo Offline";

            var signalProcess = new Process
            {
                StartInfo = new ProcessStartInfo
                {
                    FileName = "cmd.exe",
                    Arguments = $"/C {cmd}",
                    RedirectStandardOutput = true,
                    UseShellExecute = false,
                    CreateNoWindow = true
                }

            }; 
            signalProcess.Start();
            string output = signalProcess.StandardOutput.ReadToEnd();
            signalProcess.WaitForExit();

            if (output.Contains("Online"))
            {
                return true;
            }
            return false;
        }

        public bool IsSelectedSSIDEqualsToConnectedSSID(string selectedSSID, string connectedSSID) 
        {
            if (selectedSSID == connectedSSID){ return true; }
            return false;
              
        }


    }

}