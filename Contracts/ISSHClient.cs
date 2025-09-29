using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Renci.SshNet;

namespace RpiUsbSim.Contracts
{
    internal interface ISSHClient
    {
        SshClient CreateClient(SSHConnectionInfo sshConnectionInfo);

        void ConnectSsh();
        void DisconnectSsh();
        bool GetSshConnectionStatus();
        string SendCommand(string command);
    }
}
