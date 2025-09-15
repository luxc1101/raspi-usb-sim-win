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
using Markdig;

namespace RpiUsbSim.HelpDialog
{
    public partial class HelpDialog : Form
    {
        private readonly MarkDownRead mdRead = new MarkDownRead();
        private string MDHelpFile { get { return mdRead.MakeDownFilePath; } }

        public HelpDialog()
        {
            InitializeComponent();
            LoadWebBrowserContent();
        }

        private void LoadWebBrowserContent()
        {
            string htmlContent = mdRead.LoadMarkdownContentAndConvertToHtml(MDHelpFile);
            webBrowser.DocumentText = htmlContent;
        }

        private void linkLabel_autor_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            var process = new Process();
            process.StartInfo.FileName = "https://github.com/luxc1101";
            process.StartInfo.UseShellExecute = true;
            process.Start();
            
        }
    }
}
