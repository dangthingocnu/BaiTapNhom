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
using BAL_DLL;
using Bussiness;
namespace UngDungThiTracNghiem
{
    public partial class Form_XoaGiaoVien : DevExpress.XtraEditors.XtraForm
    {
        Table_GiaoVien gv_current = new Table_GiaoVien();
        GiaoVien_BAL_DLL gv = new GiaoVien_BAL_DLL();
        public Form_XoaGiaoVien()
        {
            InitializeComponent();
            loaComboChucVu();
            loadDgvGiaovien();
            textBoxma.Enabled = false;
        }
        private void loaComboChucVu()
        {
            comboBox_cv.DataSource = gv.getGiaoVien();
            comboBox_cv.DisplayMember = "ChucVu";

        }
        private void loadDgvGiaovien()
        {
            dataGridView1.DataSource = gv.getGiaoVien();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            gv_current.MaGiaoVien = dataGridView1.CurrentRow.Cells[0].Value.ToString().Trim();
            gv_current.HoTen = dataGridView1.CurrentRow.Cells[1].Value.ToString().Trim();
            gv_current.DiaChi = dataGridView1.CurrentRow.Cells[2].Value.ToString().Trim();
            gv_current.SoDienThoai = dataGridView1.CurrentRow.Cells[3].Value.ToString().Trim();
            gv_current.NgaySinh = dataGridView1.CurrentRow.Cells[4].Value.ToString().Trim();
            gv_current.ChucVu = dataGridView1.CurrentRow.Cells[5].Value.ToString().Trim();


            textBoxma.Text = gv_current.MaGiaoVien;
            txtTenGV.Text = gv_current.HoTen;
            textBox_dc.Text = gv_current.DiaChi;
            textBox_dt.Text = gv_current.SoDienThoai;
            textBox_ns.Text = gv_current.NgaySinh;
            comboBox_cv.Text = gv_current.ChucVu;
        }
        private Table_GiaoVien khoiTaoGV()
        {
            Table_GiaoVien d = new Table_GiaoVien();
            d.MaGiaoVien = textBoxma.Text.ToString();
            d.HoTen = txtTenGV.Text.ToString();
            d.DiaChi = textBox_dc.Text.ToString();
            d.NgaySinh = textBox_ns.Text.ToString();
            d.SoDienThoai = textBox_dt.Text.ToString();
            d.ChucVu = comboBox_cv.Text.ToString();
            
            return d;
        }
        private void btnXoa_Click(object sender, EventArgs e)
        {
            Table_GiaoVien d_xoa = khoiTaoGV();
            int result_xoa = gv.deleteGV(d_xoa);
            if (result_xoa == 1)
            {
                MessageBox.Show("Xóa thành công!");
                textBoxma.Text = "";
                txtTenGV.Text = "";
                textBox_dc.Text = "";
                textBox_dt.Text = "";
                textBox_ns.Text = "";
                loadDgvGiaovien();
            }

            else
                MessageBox.Show("Xóa thất bại!");
        }
        //public void updateGiaovien(Table_GiaoVien gvien)
        //{
        //    Table_GiaoVien d = gv.kiemTraTonTai(gvien);
        //    if (d != null)
        //    {
                
        //        int result_update = gv.updateGV(d);
        //        if (result_update == 1)
        //        {
        //            MessageBox.Show("Cập nhật thành công");
        //        }
        //        else
        //            MessageBox.Show("Cập nhật thất bại");
        //    }
        //    else
        //    {
        //        DialogResult rs = MessageBox.Show("Chưa tồn giáo viên này", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
               
        //    }
        //    loadDgvGiaovien();
        //}
        private void btnChinhsua_Click(object sender, EventArgs e)
        {
            
            try
            {
                GiaoVienBS gvBS = new GiaoVienBS();
                gvBS.UpdateGiaoVien(txtTenGV.Text, comboBox_cv.Text, textBox_dc.Text, textBox_dt.Text, textBox_ns.Text,textBoxma.Text);
                MessageBox.Show("Cập nhật thành công");
                loadDgvGiaovien();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Loi:" + ex.Message);
            }
        }
        
    }
}
