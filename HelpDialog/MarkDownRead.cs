using RpiUsbSim.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RpiUsbSim.HelpDialog
{
    internal class MarkDownRead: IMarkdownReader
    {
        public MarkDownRead() { }

        public string MakeDownFilePath { get; set; } = Path.GetFullPath(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"..\..\..\", "Configuration", "UserGuids.md"));

        public bool IsFileExist(string filePath)
        {
            return File.Exists(filePath);
        }

        public string LoadMarkdownContentAndConvertToHtml(string filePath)
        {
            if (!IsFileExist(filePath))
            {
                throw new FileNotFoundException($"The file at path {filePath} does not exist.");
            }
            string markdownFile = File.ReadAllText(filePath);
            string markdownString = $"{GetGlobalStyle()}\n{markdownFile}";
            string convertedHtmlString = Markdig.Markdown.ToHtml(markdownString);
            return convertedHtmlString;
        }

        public string GetGlobalStyle()
        {
            return @"
<style>
    body {
        font-size: 11px; /* Adjust the font size globally */
        font-family: Arial, sans-serif; /* Optional: Set a default font family */
        line-height: 1;
    }
    h1 {
        font-size: 13px; /* Adjust the size of headings */
        line-height: 0; /* Optional: Adjust line spacing for headings */
    }
    h2 {
        font-size: 12px;
        line-height: 0; /* Optional: Adjust line spacing for headings */
    }
    h3 {
        font-size: 11px;
        line-height: 0; /* Optional: Adjust line spacing for headings */
    }
    p, li {
        font-size: 11px; /* Adjust the size of paragraphs and list items */
        line-height: 1.2;
    }
</style>";
        }
    }
}
