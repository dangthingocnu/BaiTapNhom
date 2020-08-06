using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Bussiness;
using BAL_DLL;
namespace UngDungThiTracNghiem
{
    public partial class Form_TTDSachGiaoVien : Form
    {
        private GiaoVienBS nvbs;
        GiaoVien_BAL_DLL gv = new GiaoVien_BAL_DLL();
        public Form_TTDSachGiaoVien()
        {
            InitializeComponent();
            loaddgvGiaoVien();
        }
        private void loaddgvGiaoVien()
        {
            dataGridView1.DataSource = gv.getGiaoVien();
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            dataGridView1.DataSource = gv.layGiaovienDH();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            dataGridView1.DataSource = gv.getGiaoVien();
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            dataGridView1.DataSource = gv.layGiaovienQL();
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            dataGridView1.DataSource = gv.layGiaovienThuong();
        }

        private void btnTK_Click(object sender, EventArgs e)
        {
            nvbs = new GiaoVienBS();
            string strSearch = txtTimKiem.Text;
            dataGridView1.DataSource = nvbs.TimKiemGV(strSearch).Tables[0];
        }
    }
}
