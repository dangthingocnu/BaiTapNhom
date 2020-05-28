using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;
namespace button
{
    public class btnbutton:Button
    {
        public btnbutton()
        {
            this.MouseHover += btnbutton_MouseHover;
            this.MouseLeave += btnbutton_MouseLeave;
        }

        void btnbutton_MouseLeave(object sender, EventArgs e)
        {
            this.BackColor = Color.White;
        }

        void btnbutton_MouseHover(object sender, EventArgs e)
        {
            this.BackColor = Color.Cyan;
        }
    }

}
