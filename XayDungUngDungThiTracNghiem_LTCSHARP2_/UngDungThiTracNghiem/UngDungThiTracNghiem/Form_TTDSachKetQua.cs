using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using Bussiness;
using BAL_DLL;
namespace UngDungThiTracNghiem
{
    public partial class Form_TTDSachKetQua : DevExpress.XtraEditors.XtraForm
    {
        private ThiSinhBS tsbs;
        MonThi_BAL_DLL monthibll = new MonThi_BAL_DLL();
        KetQua_BAL_DLL kqbll = new KetQua_BAL_DLL();
        public Form_TTDSachKetQua()
        {
            InitializeComponent();
            loadCboMonThi();
            loaddgvKetQua();
        }
        private void loadCboMonThi()
        {
            cboMonthi.DataSource = monthibll.getMon();
            cboMonthi.DisplayMember = "TenMon";
            cboMonthi.ValueMember = "MaMon";
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            string maTS = txtTimKiem.Text;
            string tenTs = txtTimKiem.Text;
            try
            {
                tsbs = new ThiSinhBS();
                dataGridView1.DataSource = tsbs.TimKiemThiSinh(maTS, tenTs);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Loi:" + ex.Message);
            }
        }
        private void loaddgvKetQua()
        {
            dataGridView1.DataSource = kqbll.getKetQua();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            dataGridView1.DataSource = kqbll.getKetQua();
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            tsbs = new ThiSinhBS();
            dataGridView1.DataSource = tsbs.GetKetQuaDiemCN(cboMonthi.SelectedValue.ToString()).Tables[0];
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            dataGridView1.DataSource = kqbll.layKQDat();
        }

        private void radioButton5_CheckedChanged(object sender, EventArgs e)
        {
            dataGridView1.DataSource = kqbll.layKQTruot();
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            tsbs = new ThiSinhBS();
            dataGridView1.DataSource = tsbs.GetKetQuaDiemTN(cboMonthi.SelectedValue.ToString()).Tables[0];
        }

        private void cboMonthi_SelectedIndexChanged(object sender, EventArgs e)
        {
            radioButton2.Checked = false;
            radioButton3.Checked = false;
            tsbs = new ThiSinhBS();
            dataGridView1.DataSource = tsbs.GetKetQuaCSDL(cboMonthi.SelectedValue.ToString()).Tables[0];
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
                return;
            //lay thong tin ve thi sinh va hien thi le man hinh
            try
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                string hoTen = row.Cells["HoTen"].Value.ToString();
                string monThi = row.Cells["TenMon"].Value.ToString();
                string diem = row.Cells["Diem"].Value.ToString();
                string MaTS = row.Cells["MaThiSinh"].Value.ToString();
                string maMon = cboMonthi.SelectedValue.ToString();
                string ngayThi = row.Cells["NgayThi"].Value.ToString();
                FrmChiTietBaiThi fmChiTiet = new FrmChiTietBaiThi(hoTen, monThi, diem, MaTS, maMon, ngayThi);
                fmChiTiet.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Loi:" + ex.Message);
            }
        }

        
        
    }
}
