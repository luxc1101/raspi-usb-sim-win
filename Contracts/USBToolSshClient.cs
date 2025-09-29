using Renci.SshNet;
using RpiUsbSim.Main;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RpiUsbSim.Contracts
{
    internal class USBToolSshClient : ISSHClient
    {
        public SshClient? sshClient;

        public USBToolSshClient()
        {
            sshClient = null;
        }
        public SshClient CreateClient(SSHConnectionInfo sshConnectionInfo)
        {
            var connectionInfo = new ConnectionInfo(
                sshConnectionInfo.Host,
                sshConnectionInfo.Port,
                sshConnectionInfo.Username,
                new PasswordAuthenticationMethod(
                    sshConnectionInfo.Username,
                    sshConnectionInfo.Password))
            { 
                Timeout = TimeSpan.FromSeconds(5)
            };

            sshClient = new SshClient(connectionInfo);
            sshClient.HostKeyReceived += (sender, e) =>
            {
                e.CanTrust = true;
            };
            return sshClient;
        }

        public void ConnectSsh()
        {
            try 
            {
                sshClient?.Connect();
            }
            catch (Exception ex)
            {
                throw new InvalidOperationException("[ERROR]: " + ex.Message);
            }
        }

        public void DisconnectSsh()
        {
            try 
            {
                sshClient?.Disconnect();
            }
            catch (Exception ex) 
            {
                throw new InvalidOperationException("[ERROR]: " + ex.Message);
            }
        }
        public bool GetSshConnectionStatus()
        {   
            if (sshClient == null) 
            {
                return false;
            }
            if (!sshClient.IsConnected) 
            {
                return false;
            }
            return true;
        }

        public string SendCommand(string command)
        {
            if (!GetSshConnectionStatus())
                throw new InvalidOperationException("[ERROR]: SSH Connection failed");
            using SshCommand cmd = sshClient.RunCommand(command);
            return cmd.Result;
        }
    }
}
