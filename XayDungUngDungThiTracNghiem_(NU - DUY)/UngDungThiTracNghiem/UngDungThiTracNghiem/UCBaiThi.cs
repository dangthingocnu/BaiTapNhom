using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UngDungThiTracNghiem
{
    public partial class UCBaiThi : UserControl
    {
        public UCBaiThi(string noiDung, string DAA, string DAB, string DAC, string DAD, int luaChon, int dapAn)
        {
            InitializeComponent();
            lbNoiDung.Text = noiDung;
            lbA.Text = DAA;
            lbB.Text = DAB;
            lbC.Text = DAC;
            lbD.Text = DAD;
            switch (dapAn)
            {
                case 1: lbA.ForeColor = Color.Green;
                    break;
                case 2: lbB.ForeColor = Color.Green;
                    break;
                case 3: lbC.ForeColor = Color.Green;
                    break;
                case 4: lbD.ForeColor = Color.Green;
                    break;
            }
            if (luaChon == dapAn)
            {
                lbNoiDung.ForeColor = Color.Green;
            }
            else
            {
                lbNoiDung.ForeColor = Color.Red;
                switch (luaChon)
                {
                    case 1: lbA.ForeColor = Color.Red;
                        break;
                    case 2: lbB.ForeColor = Color.Red;
                        break;
                    case 3: lbC.ForeColor = Color.Red;
                        break;
                    case 4: lbD.ForeColor = Color.Red;
                        break;
                }
            }

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
