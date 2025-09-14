
using System.Reflection.Metadata;
using System.Windows.Forms;

namespace RpiUsbSim
{
    partial class SshLoginDialog
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        private Size TextBoxSize = new Size(182, 23);

        private Button btn_eye;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
         
        private Panel CreateTextBox(Point point, string name, int tabidx)
        {
            Panel panelbox = new Panel
            {
                Location = point,
                Size = TextBoxSize,
                BackColor = Color.White,
                BorderStyle = BorderStyle.Fixed3D
            };

            var textBox = new TextBox
            {
                Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right,
                BorderStyle = BorderStyle.None,
                Location = new Point(0, 0),
                Name = name,
                Size = TextBoxSize,
                TabIndex = tabidx,
                Font = new Font("Courier New", 10)
            };
            panelbox.Controls.Add(textBox);

            return panelbox;
        }

        private Label CreateLabel(string text, Point point, string name, int tabidx)
        {
            var label = new Label
            {
                Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left,
                AutoSize = true,
                Location = point,
                Name = name,
                TabIndex = tabidx,
                Text = text,
                TextAlign = ContentAlignment.MiddleCenter,
            };
            return label;
        }
        private Button CreateButton(string text, Point point, string name, int tabidx)
        {
            var button = new Button
            {
                Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right,
                Location = point,
                Name = name,
                Size = new Size(64, 33),
                TabIndex = tabidx,
                Text = text,
                UseVisualStyleBackColor = true
            };
            return button;
        }

        private void InitializeComponent()
        {
            // this.Icon = Icon.FromHandle(Resources.ssh_connect.GetHicon());

            groupBox_SSH = new GroupBox();

            tableLayoutPanel_SSHConfig = new TableLayoutPanel();
            
            groupBox_wifi = new GroupBox();

            tableLayoutPanel_wifi = new TableLayoutPanel();

            tableLayoutPanel_btn = new TableLayoutPanel();

            Panel panelMaskedTextBox = new Panel
            {
                Location = new Point(83, 3),
                Size = TextBoxSize,
                BackColor = Color.White,
                BorderStyle = BorderStyle.Fixed3D
            };

            maskedTextBox_ip = new MaskedTextBox
            {
                Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right,
                BorderStyle = BorderStyle.None,
                Location = new Point(0, 0),
                Name = "maskedTextBox_ip",
                Size = TextBoxSize,
                TabIndex = 5,
                Mask = "000.000.000.000",
                PromptChar = '_',
                InsertKeyMode = InsertKeyMode.Insert,
                Font = new Font("Courier New", 10),
                SelectionStart = 0,
            };


            panelMaskedTextBox.Controls.Add(maskedTextBox_ip);

            Panel panelComboBox = new Panel
            {
                Location = new Point(83, 3),
                Size = TextBoxSize,
                BackColor = Color.White,
                BorderStyle = BorderStyle.Fixed3D
            };

            comboBox_ssid = new ComboBox()
            {
                FormattingEnabled = true,
                DropDownStyle = ComboBoxStyle.DropDown,
                Location = new Point(0, 0),
                Name = "comboBox_ssid",
                Size = TextBoxSize,
                TabIndex = 2,
                FlatStyle = FlatStyle.Flat,
                Font = new Font("Courier New", 10)
            };

            panelComboBox.Controls.Add(comboBox_ssid);
            comboBox_ssid.DropDown += new EventHandler(comboBox_ssid_DropDown);

            groupBox_SSH.SuspendLayout();
            tableLayoutPanel_SSHConfig.SuspendLayout();
            groupBox_wifi.SuspendLayout();
            tableLayoutPanel_wifi.SuspendLayout();
            tableLayoutPanel_btn.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox_SSH
            // 
            groupBox_SSH.Controls.Add(tableLayoutPanel_SSHConfig);
            groupBox_SSH.Location = new Point(10, 2);
            groupBox_SSH.Name = "groupBox_SSH";
            groupBox_SSH.Size = new Size(280, 165);
            groupBox_SSH.TabIndex = 0;
            groupBox_SSH.TabStop = false;
            groupBox_SSH.Text = "SSH Config";
            // 
            // label_ip_address
            // 
            label_ip_address = CreateLabel("IP Address", new Point(3, 0), "label_ip_address", 0);
            // 
            // label_port
            // 
            label_port = CreateLabel("Port", new Point(3, 27), "label_port", 1);
            // 
            // textBox_port
            // 
            textBox_port = CreateTextBox(new Point(83, 30), "textBox_port", 6);
            // 
            // label_user
            // 
            label_user = CreateLabel("User", new Point(3, 54), "label_user", 2);
            // 
            // textBox_user
            // 
            textBox_user = CreateTextBox(new Point(83, 57), "textBox_user", 7);
            // 
            // label_key
            // 
            label_key = CreateLabel("Key", new Point(3, 81), "label_key", 3);
            // 
            // textBox_key
            // 
            textBox_key = CreateTextBox(new Point(83, 84), "textBox_key", 8);
            // 
            // label_log
            // 
            label_log = CreateLabel("Log", new Point(3, 108), "label_log", 4);
            // 
            // textBox_log
            // 
            textBox_log = CreateTextBox(new Point(83, 111), "textBox_log", 9);
            // 
            // tableLayoutPanel_SSHConfig
            // 
            tableLayoutPanel_SSHConfig.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            tableLayoutPanel_SSHConfig.ColumnCount = 2;
            tableLayoutPanel_SSHConfig.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 30F));
            tableLayoutPanel_SSHConfig.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 70F));
            tableLayoutPanel_SSHConfig.Controls.Add(panelMaskedTextBox, 1, 0);
            tableLayoutPanel_SSHConfig.Controls.Add(textBox_log, 1, 4);
            tableLayoutPanel_SSHConfig.Controls.Add(textBox_key, 1, 3);
            tableLayoutPanel_SSHConfig.Controls.Add(textBox_user, 1, 2);
            tableLayoutPanel_SSHConfig.Controls.Add(textBox_port, 1, 1);
            tableLayoutPanel_SSHConfig.Controls.Add(label_port, 0, 1);
            tableLayoutPanel_SSHConfig.Controls.Add(label_ip_address, 0, 0);
            tableLayoutPanel_SSHConfig.Controls.Add(label_user, 0, 2);
            tableLayoutPanel_SSHConfig.Controls.Add(label_key, 0, 3);
            tableLayoutPanel_SSHConfig.Controls.Add(label_log, 0, 4);
            tableLayoutPanel_SSHConfig.Location = new Point(5, 22);
            tableLayoutPanel_SSHConfig.Name = "tableLayoutPanel_SSHConfig";
            tableLayoutPanel_SSHConfig.RowCount = 5;
            tableLayoutPanel_SSHConfig.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanel_SSHConfig.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanel_SSHConfig.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanel_SSHConfig.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanel_SSHConfig.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanel_SSHConfig.Size = new Size(268, 137);
            tableLayoutPanel_SSHConfig.TabIndex = 0;
            // 
            // groupBox_wifi
            // 
            groupBox_wifi.Controls.Add(tableLayoutPanel_wifi);
            groupBox_wifi.Location = new Point(10, 173);
            groupBox_wifi.Name = "groupBox_wifi";
            groupBox_wifi.Size = new Size(280, 82);
            groupBox_wifi.TabIndex = 1;
            groupBox_wifi.TabStop = false;
            groupBox_wifi.Text = "WiFi";

            // Create the eye button
            btn_eye = new Button
            {
                BackColor = Color.Transparent,
                Size = new Size(15, 15),
                Location = new Point(TextBoxSize.Width - 25, 0),
                FlatStyle = FlatStyle.Flat,
                TabIndex = 3,
                BackgroundImage = Resources.eye_closed,
                BackgroundImageLayout = ImageLayout.Zoom,
            };
            btn_eye.FlatAppearance.BorderSize = 0;
            btn_eye.FlatAppearance.MouseDownBackColor = Color.Transparent; // Transparent on click
            btn_eye.FlatAppearance.MouseOverBackColor = Color.Transparent; // Transparent on hover
            btn_eye.Click += btn_eye_Click;
            // 
            // label_ssid
            //
            label_ssid = CreateLabel("SSID", new Point(3, 0), "label_ssid", 0);
            //
            // label_password
            //
            label_password = CreateLabel("Password", new Point(3, 27), "label_password", 1);
            //
            // textBox_password
            //

            textBox_password = CreateTextBox(new Point(83, 30), "textBox_password", 3);
            (textBox_password.Controls[0] as TextBox).Size = new Size(TextBoxSize.Width - 25, TextBoxSize.Height);
            (textBox_password.Controls[0] as TextBox).UseSystemPasswordChar = true;
            textBox_password.Controls.Add(btn_eye);
            // 
            // tableLayoutPanel_wifi
            // 
            tableLayoutPanel_wifi.ColumnCount = 2;
            tableLayoutPanel_wifi.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 30F));
            tableLayoutPanel_wifi.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 70F));
            tableLayoutPanel_wifi.Controls.Add(textBox_password, 1, 1);
            tableLayoutPanel_wifi.Controls.Add(label_ssid, 0, 0);
            tableLayoutPanel_wifi.Controls.Add(label_password, 0, 1);
            tableLayoutPanel_wifi.Controls.Add(panelComboBox, 1, 0);
            tableLayoutPanel_wifi.Location = new Point(5, 22);
            tableLayoutPanel_wifi.Name = "tableLayoutPanel_wifi";
            tableLayoutPanel_wifi.RowCount = 2;
            tableLayoutPanel_wifi.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel_wifi.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel_wifi.Size = new Size(268, 54);
            tableLayoutPanel_wifi.TabIndex = 0;
            //
            // btn_connect
            //
            btn_connect = CreateButton("Connect", new Point(3, 3), "btn_connect", 2);
            btn_connect.Click += btn_connect_Click;
            // 
            // btn_cancel
            //
            btn_cancel = CreateButton("Cancel", new Point(73, 3), "btn_cancel", 3);
            btn_cancel.Click += btn_cancel_Click;
            // 
            // btn_apply
            //
            btn_apply = CreateButton("Apply", new Point(143, 3), "btn_apply", 4);
            btn_apply.Click += btn_apply_Click;
            // 
            // btn_help
            //
            btn_help = CreateButton("Help", new Point(213, 3), "btn_help", 5);  
            // 
            // tableLayoutPanel_btn
            // 
            tableLayoutPanel_btn.ColumnCount = 4;
            tableLayoutPanel_btn.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel_btn.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel_btn.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel_btn.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel_btn.Controls.Add(btn_connect, 0, 0);
            tableLayoutPanel_btn.Controls.Add(btn_help, 3, 0);
            tableLayoutPanel_btn.Controls.Add(btn_cancel, 1, 0);
            tableLayoutPanel_btn.Controls.Add(btn_apply, 2, 0);
            tableLayoutPanel_btn.Location = new Point(10, 261);
            tableLayoutPanel_btn.Name = "tableLayoutPanel_btn";
            tableLayoutPanel_btn.RowCount = 1;
            tableLayoutPanel_btn.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel_btn.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel_btn.Size = new Size(280, 39);
            tableLayoutPanel_btn.TabIndex = 6;
            // 
            // SshLoginDialog
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(300, 312);
            Controls.Add(tableLayoutPanel_btn);
            Controls.Add(groupBox_wifi);
            Controls.Add(groupBox_SSH);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "SshLoginDialog";
            Text = "Rpi SSH Connection";
            groupBox_SSH.ResumeLayout(false);
            tableLayoutPanel_SSHConfig.ResumeLayout(false);
            tableLayoutPanel_SSHConfig.PerformLayout();
            groupBox_wifi.ResumeLayout(false);
            tableLayoutPanel_wifi.ResumeLayout(false);
            tableLayoutPanel_wifi.PerformLayout();
            tableLayoutPanel_btn.ResumeLayout(false);
            ResumeLayout(false);
        }

        private GroupBox groupBox_SSH;
        private TableLayoutPanel tableLayoutPanel_SSHConfig;
        private Label label_ip_address;
        private Label label_port;
        private Label label_user;
        private Label label_key;
        private Label label_log;
        private Panel textBox_log;
        private Panel textBox_key;
        private Panel textBox_user;
        private Panel textBox_port;
        private GroupBox groupBox_wifi;
        private TableLayoutPanel tableLayoutPanel_wifi;
        private Label label_ssid;
        private Label label_password;
        private Panel textBox_password;
        private Button btn_connect;
        private Button btn_cancel;
        private Button btn_apply;
        private Button btn_help;
        private TableLayoutPanel tableLayoutPanel_btn;
        private MaskedTextBox maskedTextBox_ip;
        private ComboBox comboBox_ssid;
    }
}
