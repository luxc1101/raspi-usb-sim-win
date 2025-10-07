using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RpiUsbSim.Contracts
{
    public class SSHConnectionInfo
    {
        public string Host { get; set; } = "000.000.000.000";
        public int Port { get; set; } = 22;
        public string Username { get; set; } = "pi";
        public string Password { get; set; } = "pass";
        public string Log { get; set; } = "session.log";
    }
}
