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

namespace RpiUsbSim.SSHLoginDialog.SSHHelpDialog
{
    public partial class SshHelpDialog : Form
    {
        private readonly MarkDownRead mdRead = new MarkDownRead();
        private string? _mdHelpFile;
        private string MDHelpFile
        {
            get => _mdHelpFile ?? mdRead.MakeDownFilePath;
            set => _mdHelpFile = value;
        }
        public SshHelpDialog()
        {
            MDHelpFile = Path.GetFullPath(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"..\..\..\", "Configuration", "SshLoginGuid.md"));
            InitializeComponent();
            LoadWebBrowserContent(MDHelpFile);
        }
        private void LoadWebBrowserContent(string mdHelpFile)
        {
            string htmlContent = mdRead.LoadMarkdownContentAndConvertToHtml(mdHelpFile);
            webBrowser.DocumentText = htmlContent;
        }

    }
}
