using Org.BouncyCastle.Asn1;
using RpiUsbSim.Contracts;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RpiUsbSim.Main
{
    internal class FilesystemSpaceMonitor
    {
        private readonly USBToolSshClient _sshClient;
        private readonly Action<Dictionary<string, object>> _filesystemSpaceCallback;
        private string _mnt = string.Empty;
        public bool IsRunning = false;
        private Dictionary<string, object> _filesystemSpaceData = new ()
        {
            ["FSused"] = "unknown",
            ["FSavail"] = "unknown",
            ["Note"] = string.Empty 
        };

        public FilesystemSpaceMonitor(USBToolSshClient sshClient, Action<Dictionary<string, object>> filesystemSpaceCallback)
        {
            _sshClient = sshClient;
            _filesystemSpaceCallback = filesystemSpaceCallback;
        }

        public void SetMountPointPath(string mountPointPath)
        {
            _mnt = mountPointPath;
            Debug.WriteLine($"[DEBUG] Mount point set to: {_mnt}");
        }

        public void start() { 
            if (!IsRunning)
            {
                Debug.WriteLine("[DEBUG] Starting FilesystemSpaceMonitor...");
                IsRunning = true;
                Task.Run(() => MonitorFilesystemSpace());
            }
        }

        private void Stop()
        {
            IsRunning = false;
        }

        private async Task MonitorFilesystemSpace()
        {
            while (IsRunning)
            {
                try
                {
                    if (_sshClient.GetSshConnectionStatus()) 
                    {
                        string result = _sshClient.SendCommand($"df -Bm | grep -i '{_mnt}'");
                        if (string.IsNullOrWhiteSpace(result))
                        {
                            _filesystemSpaceCallback(_filesystemSpaceData);
                        }
                        else 
                        {
                            string FSusedStr = result.Split(' ', StringSplitOptions.RemoveEmptyEntries)[^2].TrimEnd('%');
                            int FSused = int.TryParse(FSusedStr, out var FSusedInt) ? FSusedInt : -1;
                            _filesystemSpaceData["FSused"] = FSused;
                            Debug.WriteLine($"[DEBUG] Filesystem used space: {FSused}%");

                        }
                    }
                    
                }
                catch (Exception ex)
                {
                    _filesystemSpaceCallback(_filesystemSpaceData);
                    throw new InvalidOperationException("[ERROR]: " + ex.Message);
                }
                await Task.Delay(2000); // Check every 2000 milliseconds
            }
        }

    }
}
