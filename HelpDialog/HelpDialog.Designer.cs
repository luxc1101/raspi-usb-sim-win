using System.Windows.Forms;

namespace RpiUsbSim.HelpDialog
{
    partial class HelpDialog
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
            this.Icon = Icon.FromHandle(Resources.help.GetHicon());

            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HelpDialog));
            label_contact = new Label();
            linkLabel_autor = new LinkLabel();
            tableLayoutPanel_contact = new TableLayoutPanel();
            groupBox_helptext = new GroupBox();
            tableLayoutPanel_helpdialog = new TableLayoutPanel();
            webBrowser = new WebBrowser();
            tableLayoutPanel_contact.SuspendLayout();
            tableLayoutPanel_helpdialog.SuspendLayout();
            SuspendLayout();
            // 
            // label_contact
            // 
            label_contact.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label_contact.AutoSize = true;
            label_contact.Location = new Point(3, 0);
            label_contact.Name = "label_contact";
            label_contact.Size = new Size(147, 15);
            label_contact.TabIndex = 0;
            label_contact.Text = "Contact:";
            label_contact.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // linkLabel_autor
            // 
            linkLabel_autor.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            linkLabel_autor.AutoSize = true;
            linkLabel_autor.Location = new Point(156, 0);
            linkLabel_autor.Name = "linkLabel_autor";
            linkLabel_autor.Size = new Size(147, 15);
            linkLabel_autor.TabIndex = 2;
            linkLabel_autor.TabStop = true;
            linkLabel_autor.Text = "Xiaochuan Lu";
            linkLabel_autor.TextAlign = ContentAlignment.MiddleRight;
            linkLabel_autor.LinkClicked += new LinkLabelLinkClickedEventHandler(linkLabel_autor_LinkClicked);
            // 
            // tableLayoutPanel_contact
            // 
            tableLayoutPanel_contact.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tableLayoutPanel_contact.ColumnCount = 2;
            tableLayoutPanel_contact.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel_contact.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel_contact.Controls.Add(linkLabel_autor, 1, 0);
            tableLayoutPanel_contact.Controls.Add(label_contact, 0, 0);
            tableLayoutPanel_contact.Location = new Point(3, 3);
            tableLayoutPanel_contact.Name = "tableLayoutPanel_contact";
            tableLayoutPanel_contact.RowCount = 1;
            tableLayoutPanel_contact.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel_contact.Size = new Size(306, 15);
            tableLayoutPanel_contact.TabIndex = 5;
            tableLayoutPanel_contact.AutoSize = true;
            tableLayoutPanel_contact.Dock = DockStyle.Fill;
            // 
            // groupBox_helptext
            // 
            groupBox_helptext.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            groupBox_helptext.Location = new Point(3, 24);
            groupBox_helptext.Name = "groupBox_helptext";
            groupBox_helptext.Size = new Size(306, 192);
            groupBox_helptext.TabIndex = 6;
            groupBox_helptext.TabStop = false;
            groupBox_helptext.AutoSize = true;
            groupBox_helptext.Dock = DockStyle.Fill;
            // 
            // tableLayoutPanel_helpdialog
            // 
            tableLayoutPanel_helpdialog.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tableLayoutPanel_helpdialog.ColumnCount = 1;
            tableLayoutPanel_helpdialog.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel_helpdialog.Controls.Add(groupBox_helptext, 0, 1);
            tableLayoutPanel_helpdialog.Controls.Add(tableLayoutPanel_contact, 0, 0);
            tableLayoutPanel_helpdialog.Location = new Point(10, 10);
            tableLayoutPanel_helpdialog.Name = "tableLayoutPanel_helpdialog";
            tableLayoutPanel_helpdialog.RowCount = 2;
            tableLayoutPanel_helpdialog.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
            tableLayoutPanel_helpdialog.RowStyles.Add(new RowStyle(SizeType.Percent, 90F));
            tableLayoutPanel_helpdialog.Size = new Size(312, 219);
            tableLayoutPanel_helpdialog.TabIndex = 7;
            tableLayoutPanel_helpdialog.AutoSize = true;
            tableLayoutPanel_helpdialog.Dock = DockStyle.Fill;
            //
            // wevBrowser
            //
            webBrowser.Dock = DockStyle.Fill;
            webBrowser.Location = new Point(3, 19);
            webBrowser.MinimumSize = new Size(20, 20);
            webBrowser.Name = "webBrowser";
            webBrowser.Size = new Size(300, 170);
            webBrowser.TabIndex = 0;
            groupBox_helptext.Controls.Add(webBrowser);
            // 
            // HelpDialog
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(600, 250);
            Controls.Add(tableLayoutPanel_helpdialog);
            Name = "HelpDialog";
            Text = "Help";
            tableLayoutPanel_contact.ResumeLayout(false);
            tableLayoutPanel_contact.PerformLayout();
            tableLayoutPanel_helpdialog.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Label label_contact;
        private LinkLabel linkLabel_autor;
        private TableLayoutPanel tableLayoutPanel_contact;
        private GroupBox groupBox_helptext;
        private TableLayoutPanel tableLayoutPanel_helpdialog;
        private WebBrowser webBrowser;
    }
}