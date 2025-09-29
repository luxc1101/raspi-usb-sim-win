namespace RpiUsbSim.Main
{
    partial class Main
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        /// 
        private ToolStripStatusLabel CreateStatusLabel() 
        {
            ToolStripStatusLabel toolStripStatusLabel = new ToolStripStatusLabel();
            return toolStripStatusLabel;
        }
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            statusStrip = new StatusStrip();
            toolStripStatusLabel_LED = new ToolStripStatusLabel();
            toolStripStatusLabel_Status = new ToolStripStatusLabel();
            toolStripStatusLabel_Version = new ToolStripStatusLabel();
            toolStripStatusLabel_Date = new ToolStripStatusLabel();
            toolBar = new ToolStrip();
            toolStripButton_SSHConnect = new ToolStripButton();
            toolStripButton_SSHDisconnect = new ToolStripButton();
            toolStripSeparator1 = new ToolStripSeparator();
            toolStripButton_Mount = new ToolStripButton();
            toolStripButton_Eject = new ToolStripButton();
            toolStripSeparator2 = new ToolStripSeparator();
            toolStripButton_Clear = new ToolStripButton();
            toolStripButton_Install = new ToolStripButton();
            toolStripSeparator3 = new ToolStripSeparator();
            toolStripButton_Help = new ToolStripButton();
            menuStrip = new MenuStrip();
            toolStripMenuItem_Calls = new ToolStripMenuItem();
            toolStripMenuItem_SSHConnect = new ToolStripMenuItem();
            toolStripMenuItem_SSHDisconnect = new ToolStripMenuItem();
            toolStripMenuItem_Mount = new ToolStripMenuItem();
            toolStripMenuItem_Eject = new ToolStripMenuItem();
            toolStripMenuItem_Clear = new ToolStripMenuItem();
            toolStripMenuItem_Install = new ToolStripMenuItem();
            toolStripMenuItem_Help = new ToolStripMenuItem();
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            tableLayoutPanel_Main = new TableLayoutPanel();
            tabControl = new TabControl();
            tabPage_MSC = new TabPage();
            tabPage_ECM = new TabPage();
            tabPage_HID = new TabPage();
            tabPage_CDC = new TabPage();
            groupBox_Trace = new GroupBox();
            tableLayoutPanel_Trace = new TableLayoutPanel();
            tableLayoutPanel_CMD = new TableLayoutPanel();
            button_CMD = new Button();
            comboBox_CMD = new ComboBox();
            richTextBox_Trace = new RichTextBox();
            statusStrip.SuspendLayout();
            toolBar.SuspendLayout();
            menuStrip.SuspendLayout();
            tableLayoutPanel_Main.SuspendLayout();
            tabControl.SuspendLayout();
            groupBox_Trace.SuspendLayout();
            tableLayoutPanel_Trace.SuspendLayout();
            tableLayoutPanel_CMD.SuspendLayout();
            SuspendLayout();
            // 
            // statusStrip
            // 
            statusStrip.Items.AddRange(new ToolStripItem[] { toolStripStatusLabel_LED, toolStripStatusLabel_Status, toolStripStatusLabel_Version, toolStripStatusLabel_Date });
            statusStrip.Location = new Point(0, 493);
            statusStrip.Name = "statusStrip";
            statusStrip.RenderMode = ToolStripRenderMode.Professional;
            statusStrip.Size = new Size(384, 22);
            statusStrip.TabIndex = 0;
            statusStrip.Text = "statusStrip";
            // 
            // toolStripStatusLabel_LED
            // 
            toolStripStatusLabel_LED.DisplayStyle = ToolStripItemDisplayStyle.Image;
            toolStripStatusLabel_LED.ImageTransparentColor = Color.Lime;
            toolStripStatusLabel_LED.Name = "toolStripStatusLabel_LED";
            toolStripStatusLabel_LED.Size = new Size(0, 17);
            // 
            // toolStripStatusLabel_Status
            // 
            toolStripStatusLabel_Status.DisplayStyle = ToolStripItemDisplayStyle.Text;
            toolStripStatusLabel_Status.Margin = new Padding(0, 3, 0, 3);
            toolStripStatusLabel_Status.Name = "toolStripStatusLabel_Status";
            toolStripStatusLabel_Status.Size = new Size(103, 16);
            toolStripStatusLabel_Status.Text = "SSH Disconnected";
            // 
            // toolStripStatusLabel_Version
            // 
            toolStripStatusLabel_Version.Name = "toolStripStatusLabel_Version";
            toolStripStatusLabel_Version.Size = new Size(0, 17);
            // 
            // toolStripStatusLabel_Date
            // 
            toolStripStatusLabel_Date.Margin = new Padding(0, 3, 0, 3);
            toolStripStatusLabel_Date.Name = "toolStripStatusLabel_Date";
            toolStripStatusLabel_Date.Size = new Size(95, 16);
            toolStripStatusLabel_Date.Text = "Date: 2025-09-21";
            // 
            // toolBar
            // 
            toolBar.AccessibleRole = AccessibleRole.MenuBar;
            toolBar.AllowItemReorder = true;
            toolBar.BackColor = Color.Gainsboro;
            toolBar.BackgroundImageLayout = ImageLayout.None;
            toolBar.ImageScalingSize = new Size(25, 28);
            toolBar.Items.AddRange(new ToolStripItem[] { toolStripButton_SSHConnect, toolStripButton_SSHDisconnect, toolStripSeparator1, toolStripButton_Mount, toolStripButton_Eject, toolStripSeparator2, toolStripButton_Clear, toolStripButton_Install, toolStripSeparator3, toolStripButton_Help });
            toolBar.Location = new Point(0, 24);
            toolBar.Name = "toolBar";
            toolBar.Padding = new Padding(0, 2, 0, 0);
            toolBar.RenderMode = ToolStripRenderMode.Professional;
            toolBar.Size = new Size(384, 36);
            toolBar.Stretch = true;
            toolBar.TabIndex = 1;
            toolBar.Text = "toolBar";
            // 
            // toolStripButton_SSHConnect
            // 
            toolStripButton_SSHConnect.DisplayStyle = ToolStripItemDisplayStyle.Image;
            toolStripButton_SSHConnect.Image = Resources.ssh_connect;
            toolStripButton_SSHConnect.ImageTransparentColor = Color.Magenta;
            toolStripButton_SSHConnect.Margin = new Padding(2, 0, 2, 2);
            toolStripButton_SSHConnect.Name = "toolStripButton_SSHConnect";
            toolStripButton_SSHConnect.Size = new Size(29, 32);
            toolStripButton_SSHConnect.Text = "SSH Connect";
            toolStripButton_SSHConnect.Click += toolStripButton_SSHConnect_Click;
            // 
            // toolStripButton_SSHDisconnect
            // 
            toolStripButton_SSHDisconnect.DisplayStyle = ToolStripItemDisplayStyle.Image;
            toolStripButton_SSHDisconnect.Image = Resources.ssh_disconnect;
            toolStripButton_SSHDisconnect.ImageTransparentColor = Color.Magenta;
            toolStripButton_SSHDisconnect.Margin = new Padding(2, 0, 2, 2);
            toolStripButton_SSHDisconnect.Name = "toolStripButton_SSHDisconnect";
            toolStripButton_SSHDisconnect.Size = new Size(29, 32);
            toolStripButton_SSHDisconnect.Text = "SSH Disconnect";
            toolStripButton_SSHDisconnect.Click += toolStripButton_SSHDisconnect_Click;
            // 
            // toolStripSeparator1
            // 
            toolStripSeparator1.Name = "toolStripSeparator1";
            toolStripSeparator1.Size = new Size(6, 34);
            // 
            // toolStripButton_Mount
            // 
            toolStripButton_Mount.DisplayStyle = ToolStripItemDisplayStyle.Image;
            toolStripButton_Mount.Image = Resources.mount;
            toolStripButton_Mount.ImageTransparentColor = Color.Magenta;
            toolStripButton_Mount.Margin = new Padding(2, 0, 2, 2);
            toolStripButton_Mount.Name = "toolStripButton_Mount";
            toolStripButton_Mount.Size = new Size(29, 32);
            toolStripButton_Mount.Text = "Mount";
            // 
            // toolStripButton_Eject
            // 
            toolStripButton_Eject.DisplayStyle = ToolStripItemDisplayStyle.Image;
            toolStripButton_Eject.Image = Resources.eject;
            toolStripButton_Eject.ImageTransparentColor = Color.Magenta;
            toolStripButton_Eject.Margin = new Padding(2, 0, 2, 2);
            toolStripButton_Eject.Name = "toolStripButton_Eject";
            toolStripButton_Eject.Size = new Size(29, 32);
            toolStripButton_Eject.Text = "Eject";
            // 
            // toolStripSeparator2
            // 
            toolStripSeparator2.Name = "toolStripSeparator2";
            toolStripSeparator2.Size = new Size(6, 34);
            // 
            // toolStripButton_Clear
            // 
            toolStripButton_Clear.DisplayStyle = ToolStripItemDisplayStyle.Image;
            toolStripButton_Clear.Image = Resources.clear;
            toolStripButton_Clear.ImageTransparentColor = Color.Magenta;
            toolStripButton_Clear.Margin = new Padding(2, 0, 2, 2);
            toolStripButton_Clear.Name = "toolStripButton_Clear";
            toolStripButton_Clear.Size = new Size(29, 32);
            toolStripButton_Clear.Text = "Clear Trace Window";
            // 
            // toolStripButton_Install
            // 
            toolStripButton_Install.DisplayStyle = ToolStripItemDisplayStyle.Image;
            toolStripButton_Install.Image = Resources.install;
            toolStripButton_Install.ImageTransparentColor = Color.Magenta;
            toolStripButton_Install.Margin = new Padding(2, 0, 2, 2);
            toolStripButton_Install.Name = "toolStripButton_Install";
            toolStripButton_Install.Size = new Size(29, 32);
            toolStripButton_Install.Text = "Install USB Gadget";
            // 
            // toolStripSeparator3
            // 
            toolStripSeparator3.Name = "toolStripSeparator3";
            toolStripSeparator3.Size = new Size(6, 34);
            // 
            // toolStripButton_Help
            // 
            toolStripButton_Help.DisplayStyle = ToolStripItemDisplayStyle.Image;
            toolStripButton_Help.Image = Resources.help;
            toolStripButton_Help.ImageTransparentColor = Color.Magenta;
            toolStripButton_Help.Margin = new Padding(2, 0, 2, 2);
            toolStripButton_Help.Name = "toolStripButton_Help";
            toolStripButton_Help.Size = new Size(29, 32);
            toolStripButton_Help.Text = "About This Tool";
            toolStripButton_Help.Click += toolStripButton_Help_Click;
            // 
            // menuStrip
            // 
            menuStrip.BackColor = Color.Gainsboro;
            menuStrip.Items.AddRange(new ToolStripItem[] { toolStripMenuItem_Calls });
            menuStrip.Location = new Point(0, 0);
            menuStrip.Name = "menuStrip";
            menuStrip.RenderMode = ToolStripRenderMode.Professional;
            menuStrip.Size = new Size(384, 24);
            menuStrip.TabIndex = 2;
            menuStrip.Text = "menuStrip";
            // 
            // toolStripMenuItem_Calls
            // 
            toolStripMenuItem_Calls.DropDownItems.AddRange(new ToolStripItem[] { toolStripMenuItem_SSHConnect, toolStripMenuItem_SSHDisconnect, toolStripMenuItem_Mount, toolStripMenuItem_Eject, toolStripMenuItem_Clear, toolStripMenuItem_Install, toolStripMenuItem_Help });
            toolStripMenuItem_Calls.Name = "toolStripMenuItem_Calls";
            toolStripMenuItem_Calls.Padding = new Padding(0, 0, 4, 0);
            toolStripMenuItem_Calls.Size = new Size(40, 20);
            toolStripMenuItem_Calls.Text = "Calls";
            // 
            // toolStripMenuItem_SSHConnect
            // 
            toolStripMenuItem_SSHConnect.Image = Resources.ssh_connect;
            toolStripMenuItem_SSHConnect.Name = "toolStripMenuItem_SSHConnect";
            toolStripMenuItem_SSHConnect.ShortcutKeys = Keys.Control | Keys.S;
            toolStripMenuItem_SSHConnect.Size = new Size(201, 22);
            toolStripMenuItem_SSHConnect.Text = "SSH Connect";
            toolStripMenuItem_SSHConnect.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // toolStripMenuItem_SSHDisconnect
            // 
            toolStripMenuItem_SSHDisconnect.Image = Resources.ssh_disconnect;
            toolStripMenuItem_SSHDisconnect.Name = "toolStripMenuItem_SSHDisconnect";
            toolStripMenuItem_SSHDisconnect.ShortcutKeys = Keys.Control | Keys.D;
            toolStripMenuItem_SSHDisconnect.Size = new Size(201, 22);
            toolStripMenuItem_SSHDisconnect.Text = "SSH Disconnect";
            toolStripMenuItem_SSHDisconnect.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // toolStripMenuItem_Mount
            // 
            toolStripMenuItem_Mount.Image = Resources.mount;
            toolStripMenuItem_Mount.Name = "toolStripMenuItem_Mount";
            toolStripMenuItem_Mount.ShortcutKeys = Keys.Control | Keys.M;
            toolStripMenuItem_Mount.Size = new Size(201, 22);
            toolStripMenuItem_Mount.Text = "Mount";
            toolStripMenuItem_Mount.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // toolStripMenuItem_Eject
            // 
            toolStripMenuItem_Eject.Image = Resources.eject;
            toolStripMenuItem_Eject.Name = "toolStripMenuItem_Eject";
            toolStripMenuItem_Eject.ShortcutKeys = Keys.Control | Keys.E;
            toolStripMenuItem_Eject.Size = new Size(201, 22);
            toolStripMenuItem_Eject.Text = "Eject";
            toolStripMenuItem_Eject.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // toolStripMenuItem_Clear
            // 
            toolStripMenuItem_Clear.Image = Resources.clear;
            toolStripMenuItem_Clear.Name = "toolStripMenuItem_Clear";
            toolStripMenuItem_Clear.Size = new Size(201, 22);
            toolStripMenuItem_Clear.Text = "Clear Trace Window";
            toolStripMenuItem_Clear.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // toolStripMenuItem_Install
            // 
            toolStripMenuItem_Install.Image = Resources.install;
            toolStripMenuItem_Install.Name = "toolStripMenuItem_Install";
            toolStripMenuItem_Install.Size = new Size(201, 22);
            toolStripMenuItem_Install.Text = "Install USB Gadget";
            toolStripMenuItem_Install.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // toolStripMenuItem_Help
            // 
            toolStripMenuItem_Help.Image = Resources.help;
            toolStripMenuItem_Help.Name = "toolStripMenuItem_Help";
            toolStripMenuItem_Help.Size = new Size(201, 22);
            toolStripMenuItem_Help.Text = "About USB Simulator";
            toolStripMenuItem_Help.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // tableLayoutPanel_Main
            // 
            tableLayoutPanel_Main.ColumnCount = 1;
            tableLayoutPanel_Main.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel_Main.Controls.Add(tabControl, 0, 0);
            tableLayoutPanel_Main.Controls.Add(groupBox_Trace, 0, 1);
            tableLayoutPanel_Main.Dock = DockStyle.Fill;
            tableLayoutPanel_Main.Location = new Point(0, 60);
            tableLayoutPanel_Main.Name = "tableLayoutPanel_Main";
            tableLayoutPanel_Main.RowCount = 2;
            tableLayoutPanel_Main.RowStyles.Add(new RowStyle(SizeType.Percent, 30F));
            tableLayoutPanel_Main.RowStyles.Add(new RowStyle(SizeType.Percent, 70F));
            tableLayoutPanel_Main.Size = new Size(384, 433);
            tableLayoutPanel_Main.TabIndex = 3;
            // 
            // tabControl
            // 
            tabControl.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tabControl.Controls.Add(tabPage_MSC);
            tabControl.Controls.Add(tabPage_ECM);
            tabControl.Controls.Add(tabPage_HID);
            tabControl.Controls.Add(tabPage_CDC);
            tabControl.Location = new Point(3, 3);
            tabControl.Name = "tabControl";
            tabControl.SelectedIndex = 0;
            tabControl.Size = new Size(378, 123);
            tabControl.TabIndex = 0;
            // 
            // tabPage_MSC
            // 
            tabPage_MSC.Location = new Point(4, 24);
            tabPage_MSC.Name = "tabPage_MSC";
            tabPage_MSC.Padding = new Padding(3);
            tabPage_MSC.Size = new Size(370, 95);
            tabPage_MSC.TabIndex = 0;
            tabPage_MSC.Text = "tabPage1";
            tabPage_MSC.UseVisualStyleBackColor = true;
            // 
            // tabPage_ECM
            // 
            tabPage_ECM.Location = new Point(4, 24);
            tabPage_ECM.Name = "tabPage_ECM";
            tabPage_ECM.Padding = new Padding(3);
            tabPage_ECM.Size = new Size(370, 95);
            tabPage_ECM.TabIndex = 1;
            tabPage_ECM.Text = "tabPage2";
            tabPage_ECM.UseVisualStyleBackColor = true;
            // 
            // tabPage_HID
            // 
            tabPage_HID.Location = new Point(4, 24);
            tabPage_HID.Name = "tabPage_HID";
            tabPage_HID.Padding = new Padding(3);
            tabPage_HID.Size = new Size(370, 95);
            tabPage_HID.TabIndex = 2;
            tabPage_HID.Text = "tabPage3";
            tabPage_HID.UseVisualStyleBackColor = true;
            // 
            // tabPage_CDC
            // 
            tabPage_CDC.Location = new Point(4, 24);
            tabPage_CDC.Name = "tabPage_CDC";
            tabPage_CDC.Padding = new Padding(3);
            tabPage_CDC.Size = new Size(370, 95);
            tabPage_CDC.TabIndex = 3;
            tabPage_CDC.Text = "tabPage4";
            tabPage_CDC.UseVisualStyleBackColor = true;
            // 
            // groupBox_Trace
            // 
            groupBox_Trace.AutoSize = true;
            groupBox_Trace.Controls.Add(tableLayoutPanel_Trace);
            groupBox_Trace.Dock = DockStyle.Fill;
            groupBox_Trace.Location = new Point(3, 132);
            groupBox_Trace.Name = "groupBox_Trace";
            groupBox_Trace.Size = new Size(378, 298);
            groupBox_Trace.TabIndex = 1;
            groupBox_Trace.TabStop = false;
            groupBox_Trace.Text = "Trace";
            // 
            // tableLayoutPanel_Trace
            // 
            tableLayoutPanel_Trace.AutoSize = true;
            tableLayoutPanel_Trace.ColumnCount = 1;
            tableLayoutPanel_Trace.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel_Trace.Controls.Add(tableLayoutPanel_CMD, 0, 1);
            tableLayoutPanel_Trace.Controls.Add(richTextBox_Trace, 0, 0);
            tableLayoutPanel_Trace.Dock = DockStyle.Fill;
            tableLayoutPanel_Trace.Location = new Point(3, 19);
            tableLayoutPanel_Trace.Name = "tableLayoutPanel_Trace";
            tableLayoutPanel_Trace.RowCount = 2;
            tableLayoutPanel_Trace.RowStyles.Add(new RowStyle(SizeType.Percent, 85F));
            tableLayoutPanel_Trace.RowStyles.Add(new RowStyle(SizeType.Percent, 15F));
            tableLayoutPanel_Trace.Size = new Size(372, 276);
            tableLayoutPanel_Trace.TabIndex = 2;
            // 
            // tableLayoutPanel_CMD
            // 
            tableLayoutPanel_CMD.ColumnCount = 2;
            tableLayoutPanel_CMD.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 70F));
            tableLayoutPanel_CMD.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 30F));
            tableLayoutPanel_CMD.Controls.Add(button_CMD, 1, 0);
            tableLayoutPanel_CMD.Controls.Add(comboBox_CMD, 0, 0);
            tableLayoutPanel_CMD.Dock = DockStyle.Fill;
            tableLayoutPanel_CMD.Location = new Point(3, 237);
            tableLayoutPanel_CMD.Name = "tableLayoutPanel_CMD";
            tableLayoutPanel_CMD.RowCount = 1;
            tableLayoutPanel_CMD.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel_CMD.Size = new Size(366, 36);
            tableLayoutPanel_CMD.TabIndex = 1;
            // 
            // button_CMD
            // 
            button_CMD.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            button_CMD.Location = new Point(258, 2);
            button_CMD.Margin = new Padding(2);
            button_CMD.Name = "button_CMD";
            button_CMD.Size = new Size(106, 32);
            button_CMD.TabIndex = 0;
            button_CMD.Text = "Send";
            button_CMD.UseVisualStyleBackColor = true;
            // 
            // comboBox_CMD
            // 
            comboBox_CMD.AccessibleRole = AccessibleRole.None;
            comboBox_CMD.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            comboBox_CMD.FormattingEnabled = true;
            comboBox_CMD.Location = new Point(3, 5);
            comboBox_CMD.Margin = new Padding(3, 5, 3, 3);
            comboBox_CMD.Name = "comboBox_CMD";
            comboBox_CMD.Size = new Size(250, 23);
            comboBox_CMD.TabIndex = 1;
            // 
            // richTextBox_Trace
            // 
            richTextBox_Trace.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            richTextBox_Trace.BackColor = Color.Black;
            richTextBox_Trace.Location = new Point(3, 3);
            richTextBox_Trace.Name = "richTextBox_Trace";
            richTextBox_Trace.ReadOnly = true;
            richTextBox_Trace.Size = new Size(366, 228);
            richTextBox_Trace.TabIndex = 2;
            richTextBox_Trace.Text = "";
            // 
            // Main
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(384, 515);
            Controls.Add(tableLayoutPanel_Main);
            Controls.Add(toolBar);
            Controls.Add(statusStrip);
            Controls.Add(menuStrip);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MainMenuStrip = menuStrip;
            Name = "Main";
            Text = "USB Simulator";
            statusStrip.ResumeLayout(false);
            statusStrip.PerformLayout();
            toolBar.ResumeLayout(false);
            toolBar.PerformLayout();
            menuStrip.ResumeLayout(false);
            menuStrip.PerformLayout();
            tableLayoutPanel_Main.ResumeLayout(false);
            tableLayoutPanel_Main.PerformLayout();
            tabControl.ResumeLayout(false);
            groupBox_Trace.ResumeLayout(false);
            groupBox_Trace.PerformLayout();
            tableLayoutPanel_Trace.ResumeLayout(false);
            tableLayoutPanel_CMD.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private StatusStrip statusStrip;
        private ToolStripStatusLabel toolStripStatusLabel_LED;
        private ToolStripStatusLabel toolStripStatusLabel_Status;
        private ToolStripStatusLabel toolStripStatusLabel_Version;
        private ToolStripStatusLabel toolStripStatusLabel_Date;
        private string Version = "1.0.0";
        private ToolStrip toolBar;
        private MenuStrip menuStrip;
        private ToolStripMenuItem toolStripMenuItem_Calls;
        private ToolStripMenuItem toolStripMenuItem_SSHConnect;
        private ToolStripMenuItem toolStripMenuItem_SSHDisconnect;
        private ToolStripMenuItem toolStripMenuItem_Mount;
        private ToolStripMenuItem toolStripMenuItem_Eject;
        private ToolStripMenuItem toolStripMenuItem_Clear;
        private ToolStripMenuItem toolStripMenuItem_Install;
        private ToolStripMenuItem toolStripMenuItem_Help;
        private ToolStripButton toolStripButton_SSHConnect;
        private ToolStripButton toolStripButton_SSHDisconnect;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripButton toolStripButton_Mount;
        private ToolStripButton toolStripButton_Eject;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private ToolStripSeparator toolStripSeparator2;
        private ToolStripButton toolStripButton_Clear;
        private ToolStripButton toolStripButton_Install;
        private ToolStripSeparator toolStripSeparator3;
        private ToolStripButton toolStripButton_Help;
        private TableLayoutPanel tableLayoutPanel_Main;
        private TabControl tabControl;
        private TabPage tabPage_MSC;
        private TabPage tabPage_ECM;
        private TabPage tabPage_HID;
        private TabPage tabPage_CDC;
        private GroupBox groupBox_Trace;
        private TableLayoutPanel tableLayoutPanel_CMD;
        private Button button_CMD;
        private ComboBox comboBox_CMD;
        private TableLayoutPanel tableLayoutPanel_Trace;
        private RichTextBox richTextBox_Trace;
    }
}