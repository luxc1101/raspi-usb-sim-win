using Renci.SshNet;
using RpiUsbSim.Contracts;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
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
        private SSHStatusMonitor? _sshStatusMonitor;
        private SSHClientTraceUpdater? _sshClientTraceUpdater;
        private SSHCommandRunner? _sshCommandRunner;
        private bool _isSSHConnected = false;

        public Main()
        {
            InitializeComponent();
            rpiSshClient = sshClient.CreateClient(new SSHConnectionInfo());
            InitSSHClientTraceUpdater();
            InitSSHCommandRunner();
            StartSSHStatusMonitor();
            
        }

        private void toolStripButton_Help_Click(object sender, EventArgs e)
        {
            var userGuid = new HelpDialog.HelpDialog();
            userGuid.ShowDialog();
        }

        private void toolStripButton_SSHConnect_Click(object sender, EventArgs e)
        {
            if (!_isSSHConnected)
            {
                var sshLogin = new SshLoginDialog();
                sshLogin.SSHConnectionEstablished += EstablishSSHConnection;
                if (sshLogin.ShowDialog() == DialogResult.OK)
                {
                    sshLogin.Close();
                }
            }
        }

        private void EstablishSSHConnection(SSHConnectionInfo sshConnectionInfo)
        {
            try
            {
                rpiSshClient = sshClient.CreateClient(sshConnectionInfo);
                UpdateSSHClientTrace($"[INFO]: Host: {sshConnectionInfo.Host} is connecting");
                if (!sshClient.GetSshConnectionStatus())
                {
                    // UpdateTrace($"[INFO]: Host: {sshConnectionInfo.Host} is connecting");
                    sshClient.ConnectSsh(); // Attempt to connect
                }
                UpdateSSHClientTrace($"[INFO]: SSH connection established");
                // UpdateTrace($"[INFO]: SSH connection established");
                _isSSHConnected = sshClient.GetSshConnectionStatus();
                Debug.WriteLine($"[DEBUG]: SSH Connection Status after connection attempt: {_isSSHConnected}");
                if (_isSSHConnected)
                {
                    toolStripButton_Mount.Enabled = true;
                    toolStripButton_Eject.Enabled = !toolStripButton_Mount.Enabled;
                }
                // string result = sshClient.SendCommand("python mount_robot.py 'MSC' 'FAT32' '_'");
                // UpdateTrace(result);
            }
            catch (Exception ex)
            {
                UpdateTrace(ex.Message);
            }

        }

        private void UpdateTrace(string msg)
        {
            if (InvokeRequired)
            {
                Invoke(new Action<string>(UpdateTrace), msg);
                return;
            }

            if (!richTextBox_Trace.Text.EndsWith(Environment.NewLine) && !string.IsNullOrEmpty(richTextBox_Trace.Text))
            {
                richTextBox_Trace.AppendText(Environment.NewLine);
            }

            string rtfMessage = beautyTrace.CategoriesString(msg);
            richTextBox_Trace.SelectedRtf = rtfMessage;
            richTextBox_Trace.SelectionStart = richTextBox_Trace.Text.Length;
            richTextBox_Trace.ScrollToCaret();
        }

        private void toolStripButton_SSHDisconnect_Click(object sender, EventArgs e)
        {
            try
            {
                sshClient.DisconnectSsh();
                UpdateSSHClientTrace($"[WARN]: SSH is disconnected!");
                _isSSHConnected = sshClient.GetSshConnectionStatus();
                _sshClientTraceUpdater?.Stop();
            }
            catch (Exception ex)
            {
                UpdateTrace(ex.Message);
            }
        }

        private void InitializeUSBToolState()
        {
            toolStripButton_Mount.Enabled = false;
            toolStripButton_Eject.Enabled = false;
            toolStripButton_Clear.Enabled = true;
            toolStripButton_Help.Enabled = true;
            toolStripButton_Install.Enabled = false;
            button_CMD.Enabled = false;
            comboBox_CMD.Enabled = false;
        }

        private void StartSSHStatusMonitor()
        {
            _sshStatusMonitor = new SSHStatusMonitor(sshClient, UpdateSSHClientConnectionStatus);
            _sshStatusMonitor.Start();
        }

        private void InitSSHClientTraceUpdater()
        {
            _sshClientTraceUpdater = new SSHClientTraceUpdater(UpdateTrace);
        }

        private void InitSSHCommandRunner()
        {
            _sshCommandRunner = new SSHCommandRunner(sshClient, UpdateTrace);
        }

        private void UpdateSSHClientConnectionStatus(bool isConnected)
        {
            if (InvokeRequired)
            {
                Invoke(new Action<bool>(UpdateSSHClientConnectionStatus), isConnected);
                return;
            }
            // Debug.WriteLine($"[DEBUG]: Updating SSH Connection Status: {_isSSHConnected}");
            toolStripStatusLabel_Status.Text = isConnected ? "SSH Connected" : "SSH Disconnected";
            toolStripStatusLabel_LED.Image = isConnected ? Resources.led_green : Resources.led_red;
            toolStripButton_SSHConnect.Enabled = isConnected ? false : true;
            toolStripButton_SSHDisconnect.Enabled = isConnected ? true : false;
            toolStripButton_Install.Enabled = isConnected ? true : false;
            button_CMD.Enabled = isConnected ? true : false;
            comboBox_CMD.Enabled = isConnected ? true : false;
            if (!_isSSHConnected)
            {
                InitializeUSBToolState();
            }
        }

        private void toolStripButton_Clear_Click(object sender, EventArgs e)
        {
            richTextBox_Trace.Clear();
        }

        private void UpdateSSHClientTrace(string msg)
        {
            _sshClientTraceUpdater?.SetTraces(msg);
            if (_sshClientTraceUpdater != null && !_sshClientTraceUpdater.IsRunning)
            {
                Debug.WriteLine($"[DEBUG]: Starting SSH Client Trace Updater");
                _sshClientTraceUpdater?.Start();
            }
        }

        private void UpdateCmdExecution(string cmd)
        {
            _sshCommandRunner?.SetCommand(cmd);
            if (_sshCommandRunner != null && !_sshCommandRunner.IsRunning)
            {
                Debug.WriteLine($"[DEBUG]: Starting SSH Command Runner");
                _sshCommandRunner?.Start();
            }
        }

        private void button_CMD_Click(object sender, EventArgs e)
        {
            if (_isSSHConnected)
            {
                string command = comboBox_CMD.Text.ToString();
                if (!string.IsNullOrEmpty(command))
                {
                    UpdateSSHClientTrace($"[USER]: {command}");
                    UpdateCmdExecution(command);

                    // string result = sshClient.SendCommand(command);
                }
            }
            else
            {
                UpdateSSHClientTrace("[WARN]: SSH is not connected. Please connect to SSH first.");
            }
        }
    }
}
