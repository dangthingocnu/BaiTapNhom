using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace taoControl
{
    public class numericTextbox:TextBox
    {
        public numericTextbox()
        {
            this.KeyPress += numericTextbox_KeyPress;

        }

        void numericTextbox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
    
}
