using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace PassTextBox
{
    public class txtpasstextbox : TextBox
    {
        ErrorProvider error = new ErrorProvider();
        string[] specialChar = { "!", "@", "#", "$", "%", "^", "&", "*", "(", ")", "-", "_", "+", "=", "{", "[", "}", "]", "\\", "|", ";", ":", "'", "<", ",", ">", "/", "?", "+", "*" };
        public txtpasstextbox()
        {
            this.TextChanged += txtpasstextbox_TextChanged;
        }

        void txtpasstextbox_TextChanged(object sender, EventArgs e)
        {
            foreach (string c in specialChar)
            {
                if (this.Text.Contains(c))
                {
                    if (this.Text.Length >= 6)
                    {
                        error.SetError(this, null);
                        break;
                    }
                }
                else
                {
                    error.SetError(this, "Phải có 1 ký tự đặc biệt và chứa ít nhất 6 ký tự");
                }
            }
        }
    }
}
