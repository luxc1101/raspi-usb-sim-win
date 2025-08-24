using RpiUsbSim.Contracts;
using System.Diagnostics;
using System.Text.Json;

namespace RpiUsbSim
{
    public class SshConfig
    {
        public string IP { get; set; }
        public string Username { get; set; }
        public string Key { get; set; }
        public int Port { get; set; }
        public string Log { get; set; }
    }

    public class WiFi
    {
        public string SSID { get; set; }
        public string Psk { get; set; }
    }
    public class ConfigModel
    {
        public SshConfig SSHConf { get; set; }
        public WiFi WiFi { get; set; }
    }

    public partial class SshLoginDialog : Form
    {
        public string IP { get; set; }
        public string Username { get; set; }
        public string Key { get; set; }
        public int Port { get; set; }
        public string Log { get; set; }
        public string SSID { get; set; }
        public string Psk { get; set; }

        private readonly IRegexValidator _regexValidator;

        private readonly IWifiConnector _wifiConnector;

        public SshLoginDialog()
        {
            InitializeComponent();
            _regexValidator = new RegexValidation();
            _wifiConnector = new WifiConnection();
            InitializeSshDefaultValues();
        }

        private void InitializeSshDefaultValues()
        {
            IP = "192.168.2.36";
            Username = "pi";
            Key = "pass";
            Port = 24;
            Log = "session.log";
            SSID = "YourSSID";
            Psk = "YourPassword";
            LoadConfigDefaults();
            
        }

        private void LoadConfigDefaults()
        {
            try
            {
                string configPath = Path.GetFullPath(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"..\..\..\", "Configuration", "Config.json"));
                if (File.Exists(configPath)) 
                {
                    string jsonString = File.ReadAllText(configPath);
                    var config = JsonSerializer.Deserialize<ConfigModel>(jsonString);
                    if (config?.SSHConf != null)
                    {
                        maskedTextBox_ip.Text = config.SSHConf.IP;
                        textBox_user.Controls[0].Text = config.SSHConf.Username;
                        textBox_key.Controls[0].Text = config.SSHConf.Key;
                        textBox_port.Controls[0].Text = config.SSHConf.Port.ToString();
                        textBox_log.Controls[0].Text = config.SSHConf.Log;
                    }
                    if (config?.WiFi != null)
                    {
                        comboBox_ssid.Text = config.WiFi.SSID;
                        textBox_password.Controls[0].Text = config.WiFi.Psk;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading config: {ex.Message}");
            }
        }

        private void btn_connect_Click(object sender, EventArgs e)
        {
            if (ValidateInputs())
            {
                ConnectToWifi();
            }
        }

        private void btn_apply_Click(object sender, EventArgs e)
        {
            if (ValidateInputs())
            {
                IP = maskedTextBox_ip.Text.Replace(',', '.');
                Port = int.TryParse(textBox_port.Controls[0].Text, out int port) ? port : 22;
                Username = textBox_user.Controls[0].Text;
                Key = textBox_key.Controls[0].Text;
                Log = textBox_log.Controls[0].Text;
            }
        }

        private List<string> GetAvailableSSIDs()
        {
            var ssids = new List<string>();
            var process = new Process
            {
                StartInfo = new ProcessStartInfo
                {
                    FileName = "netsh",
                    Arguments = "wlan show networks",
                    RedirectStandardOutput = true,
                    UseShellExecute = false,
                    CreateNoWindow = true
                }
            };
            process.Start();
            string output = process.StandardOutput.ReadToEnd();
            process.WaitForExit();

            // extract SSIDs from the output 
            foreach (var line in output.Split('\n')) 
            {
                var trimmedLine = line.Trim();
                if (trimmedLine.StartsWith("SSID ", StringComparison.OrdinalIgnoreCase))
                {
                    var ssid = trimmedLine.Split(':', 2)[1].Trim();
                    if (!string.IsNullOrEmpty(ssid) && !ssids.Contains(ssid))
                    {
                        ssids.Add(ssid);
                    }
                }
            }
            return ssids;
        }

        private void comboBox_ssid_DropDown(object sender, EventArgs e)
        {
            comboBox_ssid.Items.Clear();
            var ssids = GetAvailableSSIDs();
            comboBox_ssid.Items.AddRange(ssids.ToArray());
        }

        private void ConnectToWifi()
        {
            string ssid = comboBox_ssid.Text;
            string password = textBox_password.Controls[0].Text;
            _wifiConnector.CreateWifiProfile(ssid, password);
            //if (!_wifiConnector.isSSIDAvailable(ssid))
            //{
            //    MessageBox.Show($"The SSID '{ssid}' is not available. Please choose another one.", "Connection Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //    comboBox_ssid.Focus();
            //    return;
            //}
            //_wifiConnector.CreateWifiProfile(ssid, password);
            //bool isConnected = _wifiConnector.ConnectToWifi(ssid, password);
            //if (isConnected)
            //{
            //    MessageBox.Show($"Successfully connected to '{ssid}'.", "Connection Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //}
            //else
            //{
            //    MessageBox.Show($"Failed to connect to '{ssid}'. Please check the password and try again.", "Connection Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //    textBox_password.Focus();
            //}
        }

        private bool ValidateInputs()
        {
            if (!_regexValidator.validateIPAddress(maskedTextBox_ip.Text))
            {
                MessageBox.Show("Invalid IP address format.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                maskedTextBox_ip.Focus();
                return false;
            }

            else if (!_regexValidator.validatePortNumber(textBox_port.Controls[0].Text))
            {
                MessageBox.Show("Invalid Port number, please use default", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBox_port.Focus();
                return false;
            }

            else if (!_regexValidator.validateUsername(textBox_user.Controls[0].Text))
            {
                MessageBox.Show("Username cannot be empty.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBox_user.Focus();
                return false;
            }

            else if (!_regexValidator.validateKey(textBox_key.Controls[0].Text))
            {
                MessageBox.Show("Key cannot be empty.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBox_key.Focus();
                return false;
            }

            else if (!_regexValidator.validateLog(textBox_log.Controls[0].Text))
            {
                MessageBox.Show("Log file must end with .log and cannot be empty.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBox_log.Focus();
                return false;
            }

            else if (!_regexValidator.validateWiFiPassword(textBox_password.Controls[0].Text))
            {   
                MessageBox.Show("WiFi password cannot be empty.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBox_password.Focus();
                return false;
            }
            else if (!_regexValidator.validateSSID(comboBox_ssid.Text))
            {
                MessageBox.Show("SSID cannot be empty.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                comboBox_ssid.Focus();
                return false;
            }

            return true;
        }

    }
}
