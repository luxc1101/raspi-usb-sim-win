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
        private CancellationTokenSource? _cts;
        private Task? _monitoringTask;

        public SSHStatusMonitor(USBToolSshClient sshClient, Action<bool> connectionStatusCallback)
        {
            _sshClient = sshClient;
            _connectionStatusCallback = connectionStatusCallback;
        }

        public void Start() 
        {
            _isMonitoring = true;
            _cts = new CancellationTokenSource();
            _monitoringTask = Task.Run(() => MonitorConnection(_cts.Token), CancellationToken.None);
        }

        public void Stop()
        {
            _isMonitoring = false;
            _cts?.Cancel();
            _monitoringTask?.Wait(TimeSpan.FromSeconds(2));
            _cts?.Dispose();
            _cts = null;
            _monitoringTask = null;
        }

        private async Task MonitorConnection(CancellationToken token)
        {
            while (_isMonitoring && !token.IsCancellationRequested)
            {
                try
                {
                    bool isConnected = _sshClient.GetSshConnectionStatus();
                    // Debug.WriteLine($"[DEBUG]: SSH Status Monitor SSH Connection Status: {isConnected}");
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
