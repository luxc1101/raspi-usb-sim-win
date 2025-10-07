using RpiUsbSim.Contracts;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RpiUsbSim.Main
{
    internal class SSHStatusMonitor
    {
        private readonly USBToolSshClient _sshClient;
        private readonly Action<bool> _connectionStatusCallback;
        private bool _isMonitoring;
        public bool IsRunning => _isMonitoring;

        public SSHStatusMonitor(USBToolSshClient sshClient, Action<bool> connectionStatusCallback)
        {
            _sshClient = sshClient;
            _connectionStatusCallback = connectionStatusCallback;
        }

        public void Start() 
        {
            _isMonitoring = true;
            Task.Run(() => MonitorConnection());
        }

        public void Stop()
        {
            _isMonitoring = false;
        }

        private async Task MonitorConnection()
        {
            while (_isMonitoring)
            {
                try
                {
                    bool isConnected = _sshClient.GetSshConnectionStatus();
                    Debug.WriteLine($"[DEBUG]: SSH Connection Status: {isConnected}");
                    _connectionStatusCallback(isConnected);
                }
                catch (Exception ex)
                {
                    _connectionStatusCallback(false);
                    throw new InvalidOperationException("[ERROR]: " + ex.Message);
                }
                await Task.Delay(500); // Check every 500 milliseconds
            }
        }

    }
}
