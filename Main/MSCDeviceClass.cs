using Renci.SshNet;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RpiUsbSim.Contracts;
using System.Collections;
using System.Threading;

namespace RpiUsbSim.Main
{
    internal class MSCDeviceClass
    {
        private USBToolSshClient sshClient;
        private Dictionary<string, (string img, string mnt)> mscDeviceDict;
        private FilesystemSpaceMonitor? filesystemSpaceMonitor;
        private readonly Action<Dictionary<string, object>>? _uiCallback;

        public MSCDeviceClass(USBToolSshClient client, Dictionary<string, (string img, string mnt)> deviceDict, Action<Dictionary<string, object>>? uiCallback = null)
        {
            sshClient = client;
            mscDeviceDict = deviceDict;
            _uiCallback = uiCallback;
            filesystemSpaceMonitor = new FilesystemSpaceMonitor(sshClient, new Action<Dictionary<string, object>>(OnFsMonitorUpdate));
        }

        public bool CheckMSCFileSystemImageExistence(string mscDeviceName)
        {
            if (mscDeviceDict.TryGetValue(mscDeviceName, out var mscValueTuple) && sshClient.GetSshConnectionStatus())
            {
                string cmd = $"ls";
                string result = sshClient.SendCommand(cmd);
                Debug.WriteLine($"[DEBUG] value tumple image: {mscValueTuple.img}, mnt: {mscValueTuple.mnt}");
                if (result.Contains(mscValueTuple.img))
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            return false;
        }

        public void ChangeFileSystemLED(string mscDeviceName, PictureBox statusLed)
        {
            if (CheckMSCFileSystemImageExistence(mscDeviceName))
            {
                Debug.WriteLine($"[DEBUG] File system image for {mscDeviceName} exists.");
                statusLed.BackgroundImage = Resources.led_green;
            }
            else
            {
                Debug.WriteLine($"[DEBUG] File system image for {mscDeviceName} does not exist.");
                statusLed.BackgroundImage = Resources.led_red;
            }
        }

        public void UpdateFSSpaceMonitor(string mscDeviceName)
        {
            if (mscDeviceDict.TryGetValue(mscDeviceName, out var mscValueTuple) && sshClient.GetSshConnectionStatus())
            {
                if (filesystemSpaceMonitor != null)
                {
                    filesystemSpaceMonitor.SetMountPointPath(mscValueTuple.mnt);
                    if (!filesystemSpaceMonitor.IsRunning)
                        filesystemSpaceMonitor.start();
                }
            }
        }
        public void OnFsMonitorUpdate(Dictionary<string, object> fsSpaceDict)
        {
            if (fsSpaceDict.TryGetValue("FSused", out var used))
            {
                Debug.WriteLine($"[DEBUG] Filesystem used space (internal): {used}");
            }
            if (fsSpaceDict.TryGetValue("FSavail", out var avail))
            {
                Debug.WriteLine($"[DEBUG] Filesystem available space (internal): {avail}");
            }
            _uiCallback?.Invoke(fsSpaceDict);
        }
        

    }

}

