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
            tableLayoutPanel3 = new TableLayoutPanel();
            checkBox_sharedFolder = new CheckBox();
            checkBox_autoMount = new CheckBox();
            pictureBox_statusLed = new PictureBox();
            label_status = new Label();
            tableLayoutPanel2 = new TableLayoutPanel();
            button_assign = new Button();
            numericUpDown_filesystemSize = new NumericUpDown();
            progressBar_space = new ProgressBar();
            tableLayoutPanel1 = new TableLayoutPanel();
            comboBox_MSC = new ComboBox();
            button_NAS = new Button();
            button_Delect = new Button();
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
            tabPage_MSC.SuspendLayout();
            tableLayoutPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox_statusLed).BeginInit();
            tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDown_filesystemSize).BeginInit();
            tableLayoutPanel1.SuspendLayout();
            groupBox_Trace.SuspendLayout();
            tableLayoutPanel_Trace.SuspendLayout();
            tableLayoutPanel_CMD.SuspendLayout();
            SuspendLayout();
            // 
            // statusStrip
            // 
            statusStrip.Items.AddRange(new ToolStripItem[] { toolStripStatusLabel_LED, toolStripStatusLabel_Status, toolStripStatusLabel_Version, toolStripStatusLabel_Date });
            statusStrip.Location = new Point(0, 489);
            statusStrip.Name = "statusStrip";
            statusStrip.RenderMode = ToolStripRenderMode.Professional;
            statusStrip.Size = new Size(384, 22);
            statusStrip.TabIndex = 0;
            statusStrip.Text = "statusStrip";
            // 
            // toolStripStatusLabel_LED
            // 
            toolStripStatusLabel_LED.DisplayStyle = ToolStripItemDisplayStyle.Image;
            toolStripStatusLabel_LED.Image = Resources.led_red;
            toolStripStatusLabel_LED.Margin = new Padding(5, 0, 5, 0);
            toolStripStatusLabel_LED.Name = "toolStripStatusLabel_LED";
            toolStripStatusLabel_LED.Size = new Size(16, 22);
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
            toolStripStatusLabel_Version.Margin = new Padding(10, 3, 0, 3);
            toolStripStatusLabel_Version.Name = "toolStripStatusLabel_Version";
            toolStripStatusLabel_Version.Size = new Size(110, 16);
            toolStripStatusLabel_Version.Spring = true;
            toolStripStatusLabel_Version.Text = "Version: 1.0.0";
            toolStripStatusLabel_Version.TextAlign = ContentAlignment.MiddleRight;
            // 
            // toolStripStatusLabel_Date
            // 
            toolStripStatusLabel_Date.Margin = new Padding(0, 3, 0, 3);
            toolStripStatusLabel_Date.Name = "toolStripStatusLabel_Date";
            toolStripStatusLabel_Date.Size = new Size(120, 16);
            toolStripStatusLabel_Date.Spring = true;
            toolStripStatusLabel_Date.Text = "Date: 2025-10-03";
            toolStripStatusLabel_Date.TextAlign = ContentAlignment.MiddleRight;
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
            toolBar.MinimumSize = new Size(384, 36);
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
            toolStripButton_Clear.Click += toolStripButton_Clear_Click;
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
            tableLayoutPanel_Main.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tableLayoutPanel_Main.ColumnCount = 1;
            tableLayoutPanel_Main.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel_Main.Controls.Add(tabControl, 0, 0);
            tableLayoutPanel_Main.Controls.Add(groupBox_Trace, 0, 1);
            tableLayoutPanel_Main.Location = new Point(0, 60);
            tableLayoutPanel_Main.Name = "tableLayoutPanel_Main";
            tableLayoutPanel_Main.RowCount = 2;
            tableLayoutPanel_Main.RowStyles.Add(new RowStyle(SizeType.Percent, 30F));
            tableLayoutPanel_Main.RowStyles.Add(new RowStyle(SizeType.Percent, 70F));
            tableLayoutPanel_Main.Size = new Size(384, 429);
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
            tabControl.MaximumSize = new Size(0, 122);
            tabControl.MinimumSize = new Size(378, 0);
            tabControl.Name = "tabControl";
            tabControl.SelectedIndex = 0;
            tabControl.Size = new Size(378, 122);
            tabControl.SizeMode = TabSizeMode.Fixed;
            tabControl.TabIndex = 0;
            tabControl.Tag = "";
            // 
            // tabPage_MSC
            // 
            tabPage_MSC.BackColor = Color.Gainsboro;
            tabPage_MSC.Controls.Add(tableLayoutPanel3);
            tabPage_MSC.Controls.Add(tableLayoutPanel2);
            tabPage_MSC.Controls.Add(tableLayoutPanel1);
            tabPage_MSC.Location = new Point(4, 24);
            tabPage_MSC.Name = "tabPage_MSC";
            tabPage_MSC.Padding = new Padding(3);
            tabPage_MSC.Size = new Size(370, 94);
            tabPage_MSC.TabIndex = 0;
            tabPage_MSC.Text = "Mass Storage Class";
            // 
            // tableLayoutPanel3
            // 
            tableLayoutPanel3.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tableLayoutPanel3.BackColor = Color.Transparent;
            tableLayoutPanel3.ColumnCount = 4;
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 9.52381F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 28.57143F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 28.57143F));
            tableLayoutPanel3.Controls.Add(checkBox_sharedFolder, 2, 0);
            tableLayoutPanel3.Controls.Add(checkBox_autoMount, 3, 0);
            tableLayoutPanel3.Controls.Add(pictureBox_statusLed, 1, 0);
            tableLayoutPanel3.Controls.Add(label_status, 0, 0);
            tableLayoutPanel3.Location = new Point(3, 67);
            tableLayoutPanel3.Name = "tableLayoutPanel3";
            tableLayoutPanel3.RowCount = 1;
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel3.Size = new Size(365, 25);
            tableLayoutPanel3.TabIndex = 12;
            // 
            // checkBox_sharedFolder
            // 
            checkBox_sharedFolder.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            checkBox_sharedFolder.BackColor = Color.Transparent;
            checkBox_sharedFolder.Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            checkBox_sharedFolder.Location = new Point(160, 1);
            checkBox_sharedFolder.Margin = new Padding(5, 1, 3, 3);
            checkBox_sharedFolder.MaximumSize = new Size(100, 25);
            checkBox_sharedFolder.MinimumSize = new Size(100, 25);
            checkBox_sharedFolder.Name = "checkBox_sharedFolder";
            checkBox_sharedFolder.Size = new Size(100, 25);
            checkBox_sharedFolder.TabIndex = 8;
            checkBox_sharedFolder.Text = "Shared Folder";
            checkBox_sharedFolder.UseVisualStyleBackColor = false;
            // 
            // checkBox_autoMount
            // 
            checkBox_autoMount.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            checkBox_autoMount.Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            checkBox_autoMount.Location = new Point(267, 1);
            checkBox_autoMount.Margin = new Padding(8, 1, 3, 3);
            checkBox_autoMount.MaximumSize = new Size(100, 25);
            checkBox_autoMount.MinimumSize = new Size(100, 25);
            checkBox_autoMount.Name = "checkBox_autoMount";
            checkBox_autoMount.Size = new Size(100, 25);
            checkBox_autoMount.TabIndex = 9;
            checkBox_autoMount.Text = "Auto Mount";
            checkBox_autoMount.UseVisualStyleBackColor = true;
            // 
            // pictureBox_statusLed
            // 
            pictureBox_statusLed.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            pictureBox_statusLed.BackgroundImage = Resources.led_red;
            pictureBox_statusLed.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox_statusLed.ErrorImage = null;
            pictureBox_statusLed.Location = new Point(121, 3);
            pictureBox_statusLed.Margin = new Padding(0, 3, 3, 3);
            pictureBox_statusLed.Name = "pictureBox_statusLed";
            pictureBox_statusLed.Size = new Size(20, 19);
            pictureBox_statusLed.TabIndex = 10;
            pictureBox_statusLed.TabStop = false;
            // 
            // label_status
            // 
            label_status.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label_status.Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label_status.Location = new Point(3, 0);
            label_status.Name = "label_status";
            label_status.Size = new Size(115, 25);
            label_status.TabIndex = 11;
            label_status.Text = "Status of Filesystem";
            label_status.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tableLayoutPanel2.AutoScroll = true;
            tableLayoutPanel2.AutoScrollMinSize = new Size(365, 30);
            tableLayoutPanel2.AutoSize = true;
            tableLayoutPanel2.ColumnCount = 3;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 70F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 70F));
            tableLayoutPanel2.Controls.Add(button_assign, 2, 0);
            tableLayoutPanel2.Controls.Add(numericUpDown_filesystemSize, 1, 0);
            tableLayoutPanel2.Controls.Add(progressBar_space, 0, 0);
            tableLayoutPanel2.Location = new Point(3, 36);
            tableLayoutPanel2.Margin = new Padding(0);
            tableLayoutPanel2.MinimumSize = new Size(365, 30);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 1;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 19F));
            tableLayoutPanel2.Size = new Size(365, 30);
            tableLayoutPanel2.TabIndex = 11;
            // 
            // button_assign
            // 
            button_assign.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            button_assign.AutoSize = true;
            button_assign.Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button_assign.Location = new Point(296, 3);
            button_assign.Margin = new Padding(1, 3, 3, 3);
            button_assign.MaximumSize = new Size(68, 23);
            button_assign.MinimumSize = new Size(68, 23);
            button_assign.Name = "button_assign";
            button_assign.Size = new Size(68, 23);
            button_assign.TabIndex = 7;
            button_assign.Text = "Assign";
            button_assign.UseVisualStyleBackColor = true;
            // 
            // numericUpDown_filesystemSize
            // 
            numericUpDown_filesystemSize.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            numericUpDown_filesystemSize.AutoSize = true;
            numericUpDown_filesystemSize.Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            numericUpDown_filesystemSize.Location = new Point(226, 3);
            numericUpDown_filesystemSize.Margin = new Padding(1, 3, 3, 3);
            numericUpDown_filesystemSize.MaximumSize = new Size(67, 0);
            numericUpDown_filesystemSize.MinimumSize = new Size(67, 0);
            numericUpDown_filesystemSize.Name = "numericUpDown_filesystemSize";
            numericUpDown_filesystemSize.Size = new Size(67, 22);
            numericUpDown_filesystemSize.TabIndex = 6;
            // 
            // progressBar_space
            // 
            progressBar_space.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            progressBar_space.Location = new Point(3, 3);
            progressBar_space.Name = "progressBar_space";
            progressBar_space.Size = new Size(219, 20);
            progressBar_space.TabIndex = 8;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tableLayoutPanel1.ColumnCount = 3;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 35F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 35F));
            tableLayoutPanel1.Controls.Add(comboBox_MSC, 0, 0);
            tableLayoutPanel1.Controls.Add(button_NAS, 2, 0);
            tableLayoutPanel1.Controls.Add(button_Delect, 1, 0);
            tableLayoutPanel1.Location = new Point(3, 0);
            tableLayoutPanel1.Margin = new Padding(0);
            tableLayoutPanel1.MinimumSize = new Size(365, 20);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Size = new Size(365, 36);
            tableLayoutPanel1.TabIndex = 10;
            // 
            // comboBox_MSC
            // 
            comboBox_MSC.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            comboBox_MSC.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox_MSC.FormattingEnabled = true;
            comboBox_MSC.Location = new Point(3, 6);
            comboBox_MSC.Margin = new Padding(3, 6, 3, 3);
            comboBox_MSC.MinimumSize = new Size(150, 0);
            comboBox_MSC.Name = "comboBox_MSC";
            comboBox_MSC.Size = new Size(289, 23);
            comboBox_MSC.TabIndex = 1;
            comboBox_MSC.SelectedIndexChanged += comboBox_MSC_SelectedIndexChanged;
            // 
            // button_NAS
            // 
            button_NAS.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            button_NAS.AutoSize = true;
            button_NAS.BackgroundImage = Resources.remote;
            button_NAS.BackgroundImageLayout = ImageLayout.Stretch;
            button_NAS.Location = new Point(333, 3);
            button_NAS.MaximumSize = new Size(30, 30);
            button_NAS.MinimumSize = new Size(30, 30);
            button_NAS.Name = "button_NAS";
            button_NAS.Size = new Size(30, 30);
            button_NAS.TabIndex = 2;
            button_NAS.TabStop = false;
            button_NAS.UseVisualStyleBackColor = true;
            // 
            // button_Delect
            // 
            button_Delect.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            button_Delect.AutoSize = true;
            button_Delect.BackgroundImage = Resources.delete;
            button_Delect.BackgroundImageLayout = ImageLayout.Stretch;
            button_Delect.Location = new Point(298, 3);
            button_Delect.MaximumSize = new Size(30, 30);
            button_Delect.MinimumSize = new Size(30, 30);
            button_Delect.Name = "button_Delect";
            button_Delect.Size = new Size(30, 30);
            button_Delect.TabIndex = 3;
            button_Delect.UseVisualStyleBackColor = true;
            // 
            // tabPage_ECM
            // 
            tabPage_ECM.Location = new Point(4, 24);
            tabPage_ECM.Name = "tabPage_ECM";
            tabPage_ECM.Padding = new Padding(3);
            tabPage_ECM.Size = new Size(370, 94);
            tabPage_ECM.TabIndex = 1;
            tabPage_ECM.Text = "Ethernet Adapter";
            tabPage_ECM.UseVisualStyleBackColor = true;
            // 
            // tabPage_HID
            // 
            tabPage_HID.Location = new Point(4, 24);
            tabPage_HID.Name = "tabPage_HID";
            tabPage_HID.Padding = new Padding(3);
            tabPage_HID.Size = new Size(370, 94);
            tabPage_HID.TabIndex = 2;
            tabPage_HID.Text = "Human Interface Device";
            tabPage_HID.UseVisualStyleBackColor = true;
            // 
            // tabPage_CDC
            // 
            tabPage_CDC.Location = new Point(4, 24);
            tabPage_CDC.Name = "tabPage_CDC";
            tabPage_CDC.Padding = new Padding(3);
            tabPage_CDC.Size = new Size(370, 94);
            tabPage_CDC.TabIndex = 3;
            tabPage_CDC.Text = "Communications Device Class";
            tabPage_CDC.UseVisualStyleBackColor = true;
            // 
            // groupBox_Trace
            // 
            groupBox_Trace.Controls.Add(tableLayoutPanel_Trace);
            groupBox_Trace.Dock = DockStyle.Fill;
            groupBox_Trace.Location = new Point(3, 131);
            groupBox_Trace.MinimumSize = new Size(0, 295);
            groupBox_Trace.Name = "groupBox_Trace";
            groupBox_Trace.Padding = new Padding(3, 0, 3, 3);
            groupBox_Trace.Size = new Size(378, 295);
            groupBox_Trace.TabIndex = 1;
            groupBox_Trace.TabStop = false;
            groupBox_Trace.Text = "Trace";
            // 
            // tableLayoutPanel_Trace
            // 
            tableLayoutPanel_Trace.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tableLayoutPanel_Trace.AutoSize = true;
            tableLayoutPanel_Trace.ColumnCount = 1;
            tableLayoutPanel_Trace.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel_Trace.Controls.Add(tableLayoutPanel_CMD, 0, 1);
            tableLayoutPanel_Trace.Controls.Add(richTextBox_Trace, 0, 0);
            tableLayoutPanel_Trace.Location = new Point(3, 16);
            tableLayoutPanel_Trace.Name = "tableLayoutPanel_Trace";
            tableLayoutPanel_Trace.RowCount = 2;
            tableLayoutPanel_Trace.RowStyles.Add(new RowStyle(SizeType.Percent, 85F));
            tableLayoutPanel_Trace.RowStyles.Add(new RowStyle(SizeType.Percent, 15F));
            tableLayoutPanel_Trace.Size = new Size(372, 280);
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
            tableLayoutPanel_CMD.Location = new Point(3, 241);
            tableLayoutPanel_CMD.Name = "tableLayoutPanel_CMD";
            tableLayoutPanel_CMD.RowCount = 1;
            tableLayoutPanel_CMD.RowStyles.Add(new RowStyle(SizeType.Absolute, 31F));
            tableLayoutPanel_CMD.Size = new Size(366, 36);
            tableLayoutPanel_CMD.TabIndex = 1;
            // 
            // button_CMD
            // 
            button_CMD.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            button_CMD.Location = new Point(258, 2);
            button_CMD.Margin = new Padding(2);
            button_CMD.MaximumSize = new Size(105, 30);
            button_CMD.MinimumSize = new Size(105, 30);
            button_CMD.Name = "button_CMD";
            button_CMD.Size = new Size(105, 30);
            button_CMD.TabIndex = 0;
            button_CMD.Text = "Send";
            button_CMD.UseVisualStyleBackColor = true;
            button_CMD.Click += button_CMD_Click;
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
            richTextBox_Trace.Size = new Size(366, 232);
            richTextBox_Trace.TabIndex = 2;
            richTextBox_Trace.Text = "";
            // 
            // Main
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(384, 511);
            Controls.Add(tableLayoutPanel_Main);
            Controls.Add(toolBar);
            Controls.Add(statusStrip);
            Controls.Add(menuStrip);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MainMenuStrip = menuStrip;
            MinimumSize = new Size(400, 550);
            Name = "Main";
            Text = "USB Simulator";
            statusStrip.ResumeLayout(false);
            statusStrip.PerformLayout();
            toolBar.ResumeLayout(false);
            toolBar.PerformLayout();
            menuStrip.ResumeLayout(false);
            menuStrip.PerformLayout();
            tableLayoutPanel_Main.ResumeLayout(false);
            tabControl.ResumeLayout(false);
            tabPage_MSC.ResumeLayout(false);
            tabPage_MSC.PerformLayout();
            tableLayoutPanel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox_statusLed).EndInit();
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDown_filesystemSize).EndInit();
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
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
        private GroupBox groupBox_Trace;
        private TableLayoutPanel tableLayoutPanel_CMD;
        private Button button_CMD;
        private ComboBox comboBox_CMD;
        private TableLayoutPanel tableLayoutPanel_Trace;
        private RichTextBox richTextBox_Trace;
        private TabControl tabControl;
        private TabPage tabPage_MSC;
        private TabPage tabPage_ECM;
        private TabPage tabPage_HID;
        private TabPage tabPage_CDC;
        private Button button_Delect;
        private Button button_NAS;
        private ComboBox comboBox_MSC;
        private Button button_assign;
        private NumericUpDown numericUpDown_filesystemSize;
        private CheckBox checkBox_autoMount;
        private TableLayoutPanel tableLayoutPanel1;
        private TableLayoutPanel tableLayoutPanel2;
        private CheckBox checkBox_sharedFolder;
        private ProgressBar progressBar_space;
        private TableLayoutPanel tableLayoutPanel3;
        private PictureBox pictureBox_statusLed;
        private Label label_status;
    }
}