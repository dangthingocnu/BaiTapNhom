using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;
namespace MailTextBox_3._2
{
    public class MailTextBox : TextBox
    {
        public MailTextBox()
        {
            this.TextChanged += MailTextBox_TextChanged;
        }

        void MailTextBox_TextChanged(object sender, EventArgs e)
        {
            ErrorProvider err = new ErrorProvider();
            if (!(this.Text.Contains("@") && this.Text.Contains(".com")))
            {
                err.SetError(this, "nhập đúng định dạng email");
            }
            else
            {
                err.SetError(this, null);
            }
        }
    }
}