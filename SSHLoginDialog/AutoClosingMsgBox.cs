using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RpiUsbSim.SSHLoginDialog
{
    internal class AutoClosingMsgBox
    {
        public AutoClosingMsgBox()
        {
            
        }
        public static DialogResult Show(string text, string caption=null, int timeout = 1000, MessageBoxButtons buttons = MessageBoxButtons.OK, MessageBoxIcon boxIcon = MessageBoxIcon.None) 
        {
            var Msg = AutoClosingMessageBox.Factory(showMethod: (caption, buttons) => MessageBox.Show(text, caption, buttons, boxIcon), caption: caption);
            DialogResult result =  Msg.Show(
                    timeout: timeout,
                    buttons: buttons,
                    defaultResult: DialogResult.OK
                );
            return result;
        }
    }
}
