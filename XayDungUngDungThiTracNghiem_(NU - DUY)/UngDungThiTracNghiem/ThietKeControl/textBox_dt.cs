using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace ThietKeControl
{
    public class textBox_dt:TextBox
    {
        public textBox_dt()
        {
            this.KeyPress += textBox_dt_KeyPress;
        }

        void textBox_dt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
