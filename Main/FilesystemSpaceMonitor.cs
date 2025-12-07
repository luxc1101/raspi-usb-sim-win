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
        private readonly USBToolSshClient sshClient;
        private readonly Action<Dictionary<string, object>> filesystemSpaceCallback;
        private string _mnt = string.Empty;
        public bool IsRunning = false;
        private Dictionary<string, object> filesystemSpaceData = new ()
        {
            ["FSused"] = "N/A",
            ["FSavail"] = "N/A",
            ["Note"] = string.Empty 
        };

        public FilesystemSpaceMonitor(USBToolSshClient Client, Action<Dictionary<string, object>> fsSpaceCallback)
        {
            sshClient = Client;
            filesystemSpaceCallback = fsSpaceCallback;
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
                    if (sshClient.GetSshConnectionStatus())
                    {
                        string result = sshClient.SendCommand($"df -Bm | grep -i '{_mnt}'");
                        if (string.IsNullOrWhiteSpace(result))
                        {
                            filesystemSpaceData["FSused"] = "N/A";
                            filesystemSpaceData["FSavail"] = "N/A";
                            filesystemSpaceData["Note"] = string.Empty;
                            filesystemSpaceCallback(filesystemSpaceData);
                        }
                        else if (!result.Contains("part"))
                        {
                            string FSusedStr = result.Split(' ', StringSplitOptions.RemoveEmptyEntries)[^2].TrimEnd('%');
                            int FSused = int.TryParse(FSusedStr, out var FSusedInt) ? FSusedInt : -1;
                            string FsavailStr = result.Split(' ', StringSplitOptions.RemoveEmptyEntries)[3].TrimEnd('M');
                            float FSavail = float.TryParse(FsavailStr, out var FSavailFloat) ? FSavailFloat : -1;
                            filesystemSpaceData["FSused"] = FSused;
                            filesystemSpaceData["FSavail"] = FSavail;
                            filesystemSpaceData["Note"] = string.Empty;
                            filesystemSpaceCallback(filesystemSpaceData);
                        }
                        else
                        {
                            var lines = result.Split('\n', StringSplitOptions.RemoveEmptyEntries);
                            int lineslength = lines.Length;
                            var FSusedList = new List<int>();
                            var FSavailList = new List<float>();

                            foreach (var item in lines)
                            {
                                string FSusedStr = item.Split(' ', StringSplitOptions.RemoveEmptyEntries)[^2].TrimEnd('%');
                                int FSused = int.TryParse(FSusedStr, out var FSusedInt) ? FSusedInt : -1;
                                FSusedList.Add(FSused);
                                string FsavailStr = item.Split(' ', StringSplitOptions.RemoveEmptyEntries)[3].TrimEnd('M');
                                float FSavail = float.TryParse(FsavailStr, out var FSavailFloat) ? FSavailFloat : -1;
                                FSavailList.Add(FSavail);
                            }
                            int FSusedSum = FSusedList.Sum();
                            float FSavailSum = FSavailList.Sum();
                            Debug.WriteLine($"sum fs used {FSusedSum}");
                            Debug.WriteLine($"sum Fa availab {FSavailSum}");
                            filesystemSpaceData["FSused"] = FSusedSum;
                            filesystemSpaceData["FSavail"] = FSavailSum;
                            filesystemSpaceData["Note"] = "Multi partitions, values are summed";
                            filesystemSpaceCallback(filesystemSpaceData);
                        }
                    }
                    
                }
                catch (Exception ex)
                {
                    filesystemSpaceCallback(filesystemSpaceData);
                    throw new InvalidOperationException("[ERROR]: " + ex.Message);
                }
                await Task.Delay(1000); // Check every 1000 milliseconds
            }
        }

    }
}
