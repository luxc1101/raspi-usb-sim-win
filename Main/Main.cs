using Renci.SshNet;
using RpiUsbSim.Contracts;
using RpiUsbSim.SSHLoginDialog;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.Json.Nodes;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace RpiUsbSim.Main
{
    public partial class Main : Form
    {
        private readonly USBToolSshClient sshClient = new USBToolSshClient();
        private readonly TraceTextDecorator beautyTrace = new TraceTextDecorator();
        private readonly Lazy<MSCDeviceClass> mscDevice;
        private SSHStatusMonitor? sshStatusMonitor;
        private SSHClientTraceUpdater? sshClientTraceUpdater;
        private SSHCommandRunner? sshCommandRunner;
        private string usbDeviceFile { get { return usbDeviceJsonRead.DeviceFile; } }
        private UsbDeviceJsonRead usbDeviceJsonRead = new UsbDeviceJsonRead();
        private bool _isSSHConnected = false;
    private Dictionary<string, (string img, string mnt)> mscDeviceDict = new Dictionary<string, (string img, string mnt)>();

        public Main()
        {
            InitializeUISetup();
            mscDevice = new Lazy<MSCDeviceClass>(() => new MSCDeviceClass(sshClient, mscDeviceDict, OnFilesystemSpaceUpdated), LazyThreadSafetyMode.ExecutionAndPublication);
        }

        private void InitializeUISetup() 
        {
            InitializeComponent();
            InitSSHClientTraceUpdater();
            LoadUSBDeviceToDropdownList();
            sshClient.CreateClient(new SSHConnectionInfo());
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
                sshClient.CreateClient(sshConnectionInfo);
                if (!sshClient.GetSshConnectionStatus())
                {
                    sshClient.ConnectSsh(); // Attempt to connect
                }
                UpdateSSHClientTrace($"[INFO]: Host {sshConnectionInfo.Host} connection established");
                _isSSHConnected = sshClient.GetSshConnectionStatus();
                Debug.WriteLine($"[DEBUG]: SSH Connection Status after connection attempt: {_isSSHConnected}");
                if (_isSSHConnected)
                {
                    toolStripButton_Mount.Enabled = true;
                    toolStripButton_Eject.Enabled = !toolStripButton_Mount.Enabled;
                    mscDevice.Value.ChangeFileSystemLED(comboBox_MSC.Text, pictureBox_statusLed);
                    mscDevice.Value.UpdateFSSpaceMonitor(comboBox_MSC.Text);
                }
            }
            catch (Exception ex)
            {
                UpdateTrace(ex.Message);
            }

        }

        private void OnFilesystemSpaceUpdated(Dictionary<string, object> fsSpaceDict) 
        {
            // Ensure UI updates happen on UI thread
            if (InvokeRequired)
            {
                BeginInvoke(new Action(() => OnFilesystemSpaceUpdated(fsSpaceDict)));
                return;
            }

            if (fsSpaceDict.TryGetValue("FSused", out var usedObj))
            {
                int usedSpace = usedObj is int used ? used : progressBar_space.Minimum;
                //progressBar_space.Text = $"{usedObj} % Used";
                SetProgressInstant(progressBar_space, usedSpace);
            }

        }

        private void SetProgressInstant(ProgressBar bar, int value)
        {
            if (bar.InvokeRequired)
            {
                Invoke(new Action(() => SetProgressInstant(bar, value)));
                return;
            }

            int clamped = Math.Clamp(value, bar.Minimum, bar.Maximum);
            var prevStyle = bar.Style;

            // Nudge technique: set value+1 then set the target value to avoid animation on increase
            if (clamped == bar.Maximum)
            {
                bar.Value = bar.Maximum;
            }
            else
            {
                bar.Value = Math.Min(bar.Maximum, clamped + 1);
                bar.Value = clamped;
            }

            bar.Refresh();         // force paint
            Application.DoEvents(); // allow immediate repaint

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
                sshClientTraceUpdater?.Stop();
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
            sshStatusMonitor = new SSHStatusMonitor(sshClient, UpdateSSHClientConnectionStatus);
            sshStatusMonitor.Start();
        }

        private void InitSSHClientTraceUpdater()
        {
            sshClientTraceUpdater = new SSHClientTraceUpdater(UpdateTrace);
        }

        private void InitSSHCommandRunner()
        {
            sshCommandRunner = new SSHCommandRunner(sshClient, UpdateTrace);
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
            sshClientTraceUpdater?.SetTraces(msg);
            if (sshClientTraceUpdater != null && !sshClientTraceUpdater.IsRunning)
            {
                Debug.WriteLine($"[DEBUG]: Starting SSH Client Trace Updater");
                sshClientTraceUpdater?.Start();
            }
        }

        private void UpdateCmdExecution(string cmd)
        {
            sshCommandRunner?.SetCommand(cmd);
            if (sshCommandRunner != null && !sshCommandRunner.IsRunning)
            {
                Debug.WriteLine($"[DEBUG]: Starting SSH Command Runner");
                sshCommandRunner?.Start();
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
                }
            }
            else
            {
                UpdateSSHClientTrace("[WARN]: SSH is not connected. Please connect to SSH first.");
            }
        }

        private void LoadUSBDeviceToDropdownList()
        {
            if (usbDeviceJsonRead.IsFileExisting(usbDeviceFile))
            {
                JsonNode rootNode = usbDeviceJsonRead.GetRootJsonNode();
                JsonNode mscNode = usbDeviceJsonRead.GetMSCDeviceJsonNodeFromRoot();
                JsonNode ecmNode = usbDeviceJsonRead.GetECMDeviceJsonNodeFromRoot();
                JsonNode hidNode = usbDeviceJsonRead.GetHIDDeviceJsonNodeFromRoot();
                JsonNode cdcNode = usbDeviceJsonRead.GetCDCDeviceJsonNodeFromRoot();
                // Debug.WriteLine($"Node count {mscNode.AsArray().Count}");
                if (!usbDeviceJsonRead.IsJsonNodeNull(mscNode) && mscNode is JsonArray mscNodeArray)
                {
                    for (int i = 0; i < mscNodeArray.Count; i++)
                    {
                        var mscdevice = mscNodeArray[i]?["dev"];
                        var mscmnt = mscNodeArray[i]?["mnt"];
                        var mscimg = mscNodeArray[i]?["img"];
                        var mscValueTuple = (mscimg?.ToString() ?? string.Empty, mscmnt?.ToString() ?? string.Empty);
                        mscDeviceDict.Add(mscdevice?.ToString() ?? string.Empty, mscValueTuple);

                        if (mscdevice is not null) { comboBox_MSC.Items.Add(item: mscdevice); }
                    }
                    comboBox_MSC.SelectedIndex = 0;
                }
                else { Debug.WriteLine("[WARN]: JsonNode is null or unable as JsonArray"); }
            }

        }

        private void comboBox_MSC_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (mscDevice == null) return;
            mscDevice.Value.ChangeFileSystemLED(comboBox_MSC.Text, pictureBox_statusLed);
            mscDevice.Value.UpdateFSSpaceMonitor(comboBox_MSC.Text);
        }
    }
}
