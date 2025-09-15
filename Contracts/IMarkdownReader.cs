using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RpiUsbSim.Contracts
{
    internal interface IMarkdownReader
    {
        string MakeDownFilePath { get; set; }
        bool IsFileExist(string filePath);
        string LoadMarkdownContentAndConvertToHtml(string filePath);
        string GetGlobalStyle();
    }
}
