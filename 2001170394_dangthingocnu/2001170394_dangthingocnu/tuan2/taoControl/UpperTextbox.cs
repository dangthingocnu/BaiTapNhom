using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace UpperTextBox_3._1
{
    public class UpperTextbox:TextBox
    {
        public UpperTextbox()
        {
            this.KeyPress += UpperTextbox_KeyPress;
        }

        void UpperTextbox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsUpper(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
