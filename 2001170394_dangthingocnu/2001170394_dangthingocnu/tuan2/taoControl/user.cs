using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace userTextBox
{
    public class user:TextBox
    {
        public user()
        {
            this.KeyPress += user_KeyPress;
        }

        void user_KeyPress(object sender, KeyPressEventArgs e)
        {
            ErrorProvider err = new ErrorProvider();
            Control ctr = (Control)sender;
            if (!char.IsLetter(e.KeyChar)&&!char.IsNumber(e.KeyChar)&&!char.IsControl(e.KeyChar))
            {
                e.Handled = true;
                err.SetError(ctr, "nhap sai");
            }
            else
                err.Clear();
        }
    }
}
