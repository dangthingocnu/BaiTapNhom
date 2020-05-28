using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;
namespace datagirdview
{
    public class girdview : DataGridView
    {
        public girdview()
        {
            this.RowsAdded += girdview_RowsAdded;
        }

        void girdview_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            if (e.RowIndex % 2 == 0)
            {
                this.Rows[e.RowIndex].DefaultCellStyle.BackColor = System.Drawing.Color.Cyan;
            }
            else
            {
                this.Rows[e.RowIndex].DefaultCellStyle.BackColor = System.Drawing.Color.GreenYellow;
            }
        }
    }
}
