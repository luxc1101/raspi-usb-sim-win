using System.Windows.Forms;

namespace RpiUsbSim.SSHLoginDialog.SSHHelpDialog
{
    partial class SshHelpDialog
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
            this.Icon = Icon.FromHandle(Resources.ssh_connect.GetHicon());
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SshHelpDialog));
            groupBox_sshloginhelp = new GroupBox();
            webBrowser = new WebBrowser();
            SuspendLayout();
            // 
            // groupBox_sshloginhelp
            // 
            groupBox_sshloginhelp.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right | AnchorStyles.Left;
            groupBox_sshloginhelp.Location = new Point(12, 12);
            groupBox_sshloginhelp.Name = "groupBox_sshloginhelp";
            groupBox_sshloginhelp.Size = new Size(279, 308);
            groupBox_sshloginhelp.TabIndex = 0;
            groupBox_sshloginhelp.TabStop = false;
            //
            // wevBrowser
            //
            webBrowser.Dock = DockStyle.Fill;
            webBrowser.Location = new Point(0, 0);
            webBrowser.MinimumSize = new Size(20, 20);
            webBrowser.Name = "webBrowser";
            webBrowser.Size = new Size(0, 0);
            webBrowser.TabIndex = 0;
            groupBox_sshloginhelp.Controls.Add(webBrowser);
            // 
            // SshHelpDialog
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(303, 332);
            Controls.Add(groupBox_sshloginhelp);
            Name = "SSH Login Help";
            Text = "SSH Login Help";
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox_sshloginhelp;
        private WebBrowser webBrowser;
    }
}