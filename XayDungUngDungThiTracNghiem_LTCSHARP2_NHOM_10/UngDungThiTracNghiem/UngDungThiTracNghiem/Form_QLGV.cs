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
    public partial class Form_QLGV : Form
    {
        Table_GiaoVien gv_current = new Table_GiaoVien();
        GiaoVien_BAL_DLL gv = new GiaoVien_BAL_DLL();
        public Form_QLGV()
        {
            InitializeComponent();
            loaComboChucVu();
            loadDgvGiaovien();
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


            textBox_ma.Text = gv_current.MaGiaoVien;
            textBox_ten.Text = gv_current.HoTen;
            textBox_dc.Text = gv_current.DiaChi;
            textBox_dt.Text = gv_current.SoDienThoai;
            textBox_ns.Text = gv_current.NgaySinh;
            comboBox_cv.Text = gv_current.ChucVu;
        }

        private void btnThemGV_Click(object sender, EventArgs e)
        {
            textBox_ma.Text = "";
            textBox_ten.Text = "";
            textBox_dc.Text = "";
            textBox_dt.Text = "";
            textBox_ns.Text = "";
            textBox_ten.Focus();
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            Table_GiaoVien gv_them = khoiTaoGV();
            insertGV(gv_them);

        }
        private void insertGV(Table_GiaoVien gvien)
        {

            Table_GiaoVien d = gv.kiemTraTonTai(gvien);
            if (d == null)
            {
                int result_insert = gv.insertGV(gvien);
                if (result_insert == 1)
                {
                    
                    MessageBox.Show("Hệ thống đã lưu thành công");
                    
                    textBox_ma.Text = "";
                    textBox_ten.Text = "";
                    textBox_dc.Text = "";
                    textBox_dt.Text = "";
                    textBox_ns.Text = "";
                    textBox_ten.Focus();

                    loadDgvGiaovien();

                }
                else
                {
                    MessageBox.Show("Thêm thất bại");
                }
            }
            else
            {
                DialogResult rs = MessageBox.Show("Trùng mã giáo viên?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            }
            
        }
        private Table_GiaoVien khoiTaoGV()
        {
            Table_GiaoVien d = new Table_GiaoVien();
            d.MaGiaoVien = textBox_ma.Text.ToString();
            d.HoTen = textBox_ten.Text.ToString();
            d.DiaChi = textBox_dc.Text.ToString();
            d.NgaySinh = textBox_ns.Text.ToString();
            d.SoDienThoai = textBox_dt.Text.ToString();
            d.ChucVu = comboBox_cv.Text.ToString();
            
            return d;
        }
        
    }
}
