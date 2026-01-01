using RpiUsbSim.Contracts;

namespace RpiUsbSim.Main
{
    partial class InstallDialog
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
        private void InitializeComponent()
        {
            this.Icon = Icon.FromHandle(Resources.install.GetHicon());
            tableLayoutPanel_upload = new TableLayoutPanel();
            textProgressBar_installprogress = new TextProgressBar();
            tableLayoutPanel_path = new TableLayoutPanel();
            label_upload = new Label();
            textBox_path = new TextBox();
            button_browser = new Button();
            tableLayoutPanel1 = new TableLayoutPanel();
            button_install = new Button();
            button_cancel = new Button();
            tableLayoutPanel_upload.SuspendLayout();
            tableLayoutPanel_path.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel_upload
            // 
            tableLayoutPanel_upload.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tableLayoutPanel_upload.ColumnCount = 1;
            tableLayoutPanel_upload.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel_upload.Controls.Add(textProgressBar_installprogress, 0, 1);
            tableLayoutPanel_upload.Controls.Add(tableLayoutPanel_path, 0, 0);
            tableLayoutPanel_upload.Controls.Add(tableLayoutPanel1, 0, 2);
            tableLayoutPanel_upload.Location = new Point(12, 12);
            tableLayoutPanel_upload.Name = "tableLayoutPanel_upload";
            tableLayoutPanel_upload.RowCount = 3;
            tableLayoutPanel_upload.RowStyles.Add(new RowStyle(SizeType.Percent, 35F));
            tableLayoutPanel_upload.RowStyles.Add(new RowStyle(SizeType.Percent, 30F));
            tableLayoutPanel_upload.RowStyles.Add(new RowStyle(SizeType.Percent, 35F));
            tableLayoutPanel_upload.Size = new Size(310, 97);
            tableLayoutPanel_upload.TabIndex = 0;
            // 
            // textProgressBar_installprogress
            // 
            textProgressBar_installprogress.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            textProgressBar_installprogress.CustomText = $"installation progress {textProgressBar_installprogress.Minimum}%";
            textProgressBar_installprogress.Location = new Point(3, 38);
            textProgressBar_installprogress.Name = "textProgressBar_installprogress";
            textProgressBar_installprogress.ProgressColor = Color.LightGreen;
            textProgressBar_installprogress.Size = new Size(304, 18);
            textProgressBar_installprogress.Style = ProgressBarStyle.Continuous;
            textProgressBar_installprogress.TabIndex = 1;
            textProgressBar_installprogress.Value = textProgressBar_installprogress.Minimum;
            textProgressBar_installprogress.TextFont = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textProgressBar_installprogress.VisualMode = ProgressBarDisplayMode.CustomText;
            // 
            // tableLayoutPanel_path
            // 
            tableLayoutPanel_path.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tableLayoutPanel_path.ColumnCount = 3;
            tableLayoutPanel_path.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 18F));
            tableLayoutPanel_path.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 64F));
            tableLayoutPanel_path.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 18F));
            tableLayoutPanel_path.Controls.Add(label_upload, 0, 0);
            tableLayoutPanel_path.Controls.Add(textBox_path, 1, 0);
            tableLayoutPanel_path.Controls.Add(button_browser, 2, 0);
            tableLayoutPanel_path.Location = new Point(0, 0);
            tableLayoutPanel_path.Margin = new Padding(0);
            tableLayoutPanel_path.Name = "tableLayoutPanel_path";
            tableLayoutPanel_path.RowCount = 1;
            tableLayoutPanel_path.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel_path.Size = new Size(310, 33);
            tableLayoutPanel_path.TabIndex = 2;
            // 
            // label_upload
            // 
            label_upload.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label_upload.AutoSize = true;
            label_upload.Location = new Point(0, 3);
            label_upload.Margin = new Padding(0, 3, 3, 5);
            label_upload.Name = "label_upload";
            label_upload.Size = new Size(52, 25);
            label_upload.TabIndex = 0;
            label_upload.Text = "upload";
            label_upload.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // textBox_path
            // 
            textBox_path.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            textBox_path.BorderStyle = BorderStyle.Fixed3D;
            textBox_path.Location = new Point(55, 5);
            textBox_path.Margin = new Padding(0, 5, 0, 0);
            textBox_path.Name = "textBox_path";
            textBox_path.PlaceholderText = "Select installation folder";
            textBox_path.Size = new Size(198, 23);
            textBox_path.TabIndex = 1;
            textBox_path.TabStop = false;
            textBox_path.TextAlign = HorizontalAlignment.Left;
            // 
            // button_browser
            // 
            button_browser.Location = new Point(256, 4);
            button_browser.Margin = new Padding(3, 4, 3, 0);
            button_browser.Name = "button_browser";
            button_browser.Size = new Size(51, 23);
            button_browser.TabIndex = 2;
            button_browser.Text = "button_install";
            button_browser.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Controls.Add(button_install, 0, 0);
            tableLayoutPanel1.Controls.Add(button_cancel, 1, 0);
            tableLayoutPanel1.Location = new Point(107, 65);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.Size = new Size(200, 29);
            tableLayoutPanel1.TabIndex = 3;
            // 
            // button_install
            // 
            button_install.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            button_install.ImageAlign = ContentAlignment.MiddleRight;
            button_install.Location = new Point(3, 3);
            button_install.Name = "button_install";
            button_install.Size = new Size(94, 23);
            button_install.TabIndex = 0;
            button_install.Text = "Install";
            button_install.UseVisualStyleBackColor = true;
            // 
            // button_cancel
            // 
            button_cancel.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            button_cancel.Location = new Point(103, 3);
            button_cancel.Name = "button_cancel";
            button_cancel.Size = new Size(94, 23);
            button_cancel.TabIndex = 1;
            button_cancel.Text = "Cancel";
            button_cancel.UseVisualStyleBackColor = true;
            // 
            // InstallDialog
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            ClientSize = new Size(334, 121);
            Controls.Add(tableLayoutPanel_upload);
            MaximumSize = new Size(350, 160);
            MinimumSize = new Size(350, 160);
            Name = "InstallDialog";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Installation";
            Load += InstallDialog_Load;
            tableLayoutPanel_upload.ResumeLayout(false);
            tableLayoutPanel_path.ResumeLayout(false);
            tableLayoutPanel_path.PerformLayout();
            tableLayoutPanel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel_upload;
        private Label label_upload;
        private TextProgressBar textProgressBar_installprogress;
        private TableLayoutPanel tableLayoutPanel_path;
        private TextBox textBox_path;
        private Button button_browser;
        private TableLayoutPanel tableLayoutPanel1;
        private Button button_install;
        private Button button_cancel;
    }
}