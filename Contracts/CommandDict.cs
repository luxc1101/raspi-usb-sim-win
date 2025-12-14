using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RpiUsbSim.Contracts
{
    internal class CommandDict
    {
        public Dictionary<string, string> commandDictionary = new Dictionary<string, string>()
        {
            ["REMOUNT FILESYSTEM"] = "REMOUNT",
            ["QUIT"] = "QUIT",
            ["REBOOT"] = "sudo reboot",
            ["POWER OFF"] = "sudo halt"
        };
    }
}
