using RpiUsbSim.Contracts;
using System.Diagnostics;
using System.Text.Json;
using RpiUsbSim.SSHLoginDialog;
using System.Threading;
using System.Diagnostics.Eventing.Reader;

namespace RpiUsbSim
{
    public partial class SshLoginDialog : Form
    {
        public string IP { get; set; } = string.Empty;
        public string Username { get; set; } = string.Empty;
        public string Key { get; set; } = string.Empty;
        public int Port { get; set; } = 22;  
        public string Log { get; set; } = string.Empty;
        public string SSID { get; set; } = string.Empty;
        public string Psk { get; set; } = string.Empty;
        public string ConfigFile { get { return loginConfiguration.ConfigFile; } }

        private readonly RegexValidation regexValidation = new RegexValidation();
        private readonly WifiConnection wifiConnection = new WifiConnection();
        private readonly LoginConfiguration loginConfiguration = new LoginConfiguration();

        public SshLoginDialog()
        {
            InitializeComponent();
            InitializeSshDefaultValues();
        }

        private void InitializeSshDefaultValues()
        {
            LoadConfigJsonFile();          
        }

        private ConfigModel TryGetValidConfig()
        {  
            if (!loginConfiguration.IsFileExisting(ConfigFile))
            {
                MessageBox.Show($"Config file not found at {ConfigFile}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
            ConfigModel dictConfiguration = loginConfiguration.LoadConfiguration(ConfigFile);
            if (!loginConfiguration.IsConfigValid(dictConfiguration)) 
            {
                MessageBox.Show("Configuration file is invalid or missing required fields.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }

            return dictConfiguration;
        }

        private void ApplyConfigToUI(ConfigModel config) 
        {
            maskedTextBox_ip.Text = config.SSHConf.IP;
            textBox_user.Controls[0].Text = config.SSHConf.Username;
            textBox_key.Controls[0].Text = config.SSHConf.Key;
            textBox_port.Controls[0].Text = config.SSHConf.Port.ToString();
            textBox_log.Controls[0].Text = config.SSHConf.Log;
            comboBox_ssid.Text = config.WiFi.SSID;
            textBox_password.Controls[0].Text = config.WiFi.Psk;
        }

        private void ApplyUIToConfig(ConfigModel config)
        {
            config.SSHConf.IP = maskedTextBox_ip.Text;
            config.SSHConf.Port = int.TryParse(textBox_port.Controls[0].Text, out int port) ? port : 22;
            config.SSHConf.Username = textBox_user.Controls[0].Text;
            config.SSHConf.Key = textBox_key.Controls[0].Text;
            config.SSHConf.Log = textBox_log.Controls[0].Text;
            config.WiFi.SSID = comboBox_ssid.Text;
            config.WiFi.Psk = textBox_password.Controls[0].Text;
        }
        private void LoadConfigJsonFile()
        {
            try
            {
                var dictConfiguration = TryGetValidConfig();
                if (dictConfiguration != null)
                {
                    ApplyConfigToUI(dictConfiguration);
                }
            }
            catch (Exception ex)
            {
                AutoClosingMsgBox.Show($"Error loading config: {ex.Message}", "Error", 2000, boxIcon: MessageBoxIcon.Error);
            }
        }

        private void WriteConfigJsonFile(bool toShowMsg = true) 
        {
            try
            {
                var dictConfiguration = TryGetValidConfig();
                if (dictConfiguration != null) 
                {
                    ApplyUIToConfig(dictConfiguration);
                    loginConfiguration.SaveConfiguration(ConfigFile, dictConfiguration);
                    if (toShowMsg)
                        AutoClosingMsgBox.Show("Configuration saved successfully!", "Info", boxIcon: MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                AutoClosingMsgBox.Show($"Error saving config: {ex.Message}", "Error", 2000, boxIcon: MessageBoxIcon.Error);
            }
            
        }

        private void btn_eye_Click(object sender, EventArgs e)
        {
            var passwordTextBox = textBox_password.Controls[0] as TextBox;

            if (passwordTextBox != null)
            {
                if (passwordTextBox.UseSystemPasswordChar)
                {
                    passwordTextBox.UseSystemPasswordChar = false;
                    btn_eye.BackgroundImage = Resources.eye_opened;
                    return;
                }
                passwordTextBox.UseSystemPasswordChar = true;
                btn_eye.BackgroundImage = Resources.eye_closed;
            }
        }

        private void btn_connect_Click(object sender, EventArgs e)
        {

            if (ValidateInputs())
            {
                int tryTimes = 3;
                var result = MessageBox.Show($"Attempting to connect to SSID: {comboBox_ssid.Text}, please wait.", "Connecting", MessageBoxButtons.OKCancel);
                if (result != DialogResult.OK)
                    return;
                if (ConnectToWifi(tryTimes))
                {
                    IP = RegexValidation.NormalizeIP(maskedTextBox_ip.Text.Replace(',', '.'));
                    Port = int.TryParse(textBox_port.Controls[0].Text, out int port) ? port : 22;
                    Username = textBox_user.Controls[0].Text;
                    Key = textBox_key.Controls[0].Text;
                    Log = textBox_log.Controls[0].Text;
                    SSID = comboBox_ssid.Text;
                    Psk = textBox_password.Controls[0].Text;
                    WriteConfigJsonFile(toShowMsg: false);
                    this.Close();
                }
            }
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_apply_Click(object sender, EventArgs e)
        {
            if (ValidateInputs())
            {
                WriteConfigJsonFile();
            }
        }

        private void comboBox_ssid_DropDown(object sender, EventArgs e)
        {
            comboBox_ssid.Items.Clear();
            comboBox_ssid.Items.AddRange(wifiConnection.EnumerateAvailableSSIDs().ToArray());
        }

        private bool ConnectToWifi(int tryTimes)
        {
            string selectedSSID = comboBox_ssid.Text;
            string password = textBox_password.Controls[0].Text;
            wifiConnection.CreateWifiProfile(selectedSSID, password);
            if (wifiConnection.IsSelectedSSIDAvailable(selectedSSID)) 
            {
                bool isSelectedSSIDEqualsToConnectedSSIDisSelected = wifiConnection.IsSelectedSSIDEqualsToConnectedSSID(selectedSSID, wifiConnection.GetCurrentConnectedSSID());
                bool isSSIDAlreadyConnected = wifiConnection.IsSSIDAlreadyConnected();

                if (isSelectedSSIDEqualsToConnectedSSIDisSelected && isSSIDAlreadyConnected)
                {
                    AutoClosingMsgBox.Show($"'{selectedSSID}' is connected", "Connected", boxIcon: MessageBoxIcon.Information);
                    return true;
                }
                if (tryTimes > 0) 
                {
                    wifiConnection.ConnectToSelectedSSID(selectedSSID);
                    Thread.Sleep(2000);
                    return ConnectToWifi(tryTimes - 1);
                }

                MessageBox.Show($"The SSID '{selectedSSID}' connection is failed. Please check SSID and password.", "Connection Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            MessageBox.Show($"The SSID '{selectedSSID}' is not available. Please choose another one.", "Connection Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            return false;
        }

        private static void BlinkTestControl(Control textControl, Color blickColor, int durationMs = 600, int intervalMS = 150)
        {
            Color originalColor = textControl.BackColor;
            System.Windows.Forms.Timer timer = new System.Windows.Forms.Timer();
            int elapsed = 0;
            bool toggler = false;

            timer.Interval = intervalMS;
            timer.Tick += (s, e) =>
            {
                toggler = !toggler;
                textControl.BackColor = toggler ? blickColor : originalColor;

                elapsed += intervalMS;
                if (elapsed >= durationMs)
                {
                    textControl.BackColor = originalColor; // restore
                    timer.Stop();
                    timer.Dispose();
                }
            };
            timer.Start();
        }

        private bool ValidateInputs()
        {
            if (!regexValidation.ValidateIPAddress(maskedTextBox_ip.Text))
            {
                AutoClosingMsgBox.Show("Invalid IP address format.", caption: "Validation Error", boxIcon: MessageBoxIcon.Error);
                BlinkTestControl(maskedTextBox_ip, Color.Yellow);
                return false;
            }

            else if (!regexValidation.ValidatePortNumber(textBox_port.Controls[0].Text))
            {
                AutoClosingMsgBox.Show("Invalid Port number, please use default.", caption: "Validation Error", boxIcon: MessageBoxIcon.Error);
                BlinkTestControl(textBox_port.Controls[0], Color.Yellow);
                return false;
            }

            else if (!regexValidation.ValidateUsername(textBox_user.Controls[0].Text))
            {
                AutoClosingMsgBox.Show("Username cannot be empty.", caption: "Validation Error", boxIcon: MessageBoxIcon.Error);
                BlinkTestControl(textBox_user.Controls[0], Color.Yellow);
                return false;
            }

            else if (!regexValidation.ValidateKey(textBox_key.Controls[0].Text))
            {
                AutoClosingMsgBox.Show("Key cannot be empty.", "Validation Error", boxIcon: MessageBoxIcon.Error);
                BlinkTestControl(textBox_key.Controls[0], Color.Yellow);
                return false;
            }

            else if (!regexValidation.ValidateLog(textBox_log.Controls[0].Text))
            {
                AutoClosingMsgBox.Show("Log file must end with .log and cannot be empty.", "Validation Error", boxIcon: MessageBoxIcon.Error);
                BlinkTestControl(textBox_log.Controls[0], Color.Yellow);
                return false;
            }

            else if (!regexValidation.ValidateWiFiPassword(textBox_password.Controls[0].Text))
            {
                AutoClosingMsgBox.Show("WiFi password cannot be empty.", "Validation Error", boxIcon: MessageBoxIcon.Error);
                BlinkTestControl(textBox_password.Controls[0], Color.Yellow);
                return false;
            }
            else if (!regexValidation.ValidateSSID(comboBox_ssid.Text))
            {
                AutoClosingMsgBox.Show("SSID cannot be empty.", "Validation Error", boxIcon: MessageBoxIcon.Error);
                BlinkTestControl(comboBox_ssid, Color.Yellow);
                return false;
            }

            return true;
        }

    }
}
