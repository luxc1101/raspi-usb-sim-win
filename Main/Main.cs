using Renci.SshNet;
using RpiUsbSim.Contracts;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RpiUsbSim.Main
{
    public partial class Main : Form
    {
        private USBToolSshClient sshClient = new USBToolSshClient();
        private TraceTextDecorator beautyTrace = new TraceTextDecorator();
        public SshClient rpiSshClient { get; set; }

        public Main()
        {
            InitializeComponent();
            InitializeUSBToolState();
            rpiSshClient = sshClient.CreateClient(new SSHConnectionInfo());
        }

        private void toolStripButton_Help_Click(object sender, EventArgs e)
        {
            var userGuid = new HelpDialog.HelpDialog();
            userGuid.ShowDialog();
        }

        private void toolStripButton_SSHConnect_Click(object sender, EventArgs e)
        {
            var sshLogin = new SshLoginDialog();
            sshLogin.SSHConnectionEstablished += OnSSHConnectionEstablished;
            if (sshLogin.ShowDialog() == DialogResult.OK)
            {
            }
        }

        private void OnSSHConnectionEstablished(SSHConnectionInfo sshConnectionInfo)
        {
            try
            {
                // Create the SSH client and connect
                rpiSshClient = sshClient.CreateClient(sshConnectionInfo);
                // Check the connection status
                if (!sshClient.GetSshConnectionStatus())
                {
                    sshClient.ConnectSsh(); // Attempt to connect
                }
                UpdateTrace(beautyTrace.CategoriesString("[INFO]: SSH connection established."));
                // If connected, update the UI and send a test command
                toolStripButton_SSHConnect.Enabled = false;
                toolStripButton_SSHDisconnect.Enabled = true;

                string result = sshClient.SendCommand("pwd");
                UpdateTrace(beautyTrace.CategoriesString(result));
            }
            catch (Exception ex)
            {
                UpdateTrace(beautyTrace.CategoriesString(ex.Message));
            }
        }

        private void UpdateTrace(string rtfMessage)
        {
            if (InvokeRequired)
            {
                Invoke(new Action<string>(UpdateTrace), rtfMessage);
                return;
            }
            richTextBox_Trace.SelectedRtf = rtfMessage;
            richTextBox_Trace.AppendText(Environment.NewLine);
        }

        private void toolStripButton_SSHDisconnect_Click(object sender, EventArgs e)
        {
            try 
            {
                sshClient.DisconnectSsh();
                toolStripButton_SSHConnect.Enabled = true;
                toolStripButton_SSHDisconnect.Enabled = false;
            }
            catch (Exception ex) 
            {
                UpdateTrace(beautyTrace.CategoriesString(ex.Message));
            }
        }

        private void InitializeUSBToolState()
        {
            toolStripButton_SSHConnect.Enabled = true;
            toolStripButton_SSHDisconnect.Enabled = false;
        }
    }
}
