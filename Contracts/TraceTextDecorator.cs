using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;


namespace RpiUsbSim.Contracts
{
    internal class TraceTextDecorator
    {
        /*
         * string --> categories string --> decorate with color code --> decorated string
         */
        public TraceTextDecorator()
        {

        }

        public string CategoriesString(string msg) 
        {
            if (msg.Contains("ERROR")) 
            {
                string cleanMsg = msg.Replace("[ERROR]: ", "").Trim();
                return DecorateText(cleanMsg, 1);
            }
            else if (msg.Contains("WARN")) 
            {
                string cleanMsg = msg.Replace("[WARN]: ", "").Trim();
                return DecorateText(cleanMsg, 2);
            }
            else if (msg.Contains("INFO")) 
            {
                string cleanMsg = msg.Replace("[INFO]: ", "").Trim();
                return DecorateText(cleanMsg, 3);
            }
            else if (msg.Contains("USER")) 
            {
                string cleanMsg = msg.Replace("[USER]: ", "").Trim();
                return DecorateText(cleanMsg, 4);
            }
            else 
            {
                return DecorateText(msg, 5);
            }

        }

        private string DecorateText(string msg, int colorIndex) 
        {
            // Generate RTF with the specified color
            StringBuilder rtf = new StringBuilder();
            rtf.Append(@"{\rtf1\ansi\deff0");
            rtf.Append(@"{\colortbl;
                        \red255\green0\blue0;
                        \red255\green165\blue0;
                        \red173\green216\blue230;
                        \red198\green157\blue235;
                        \red50\green205\blue50;}");
            rtf.Append($@"\cf{colorIndex}\b {msg}\b0\cf0 "); // Apply bold and color and reset to default
            rtf.Append(@"}");
            return rtf.ToString();
        }


    }
}
