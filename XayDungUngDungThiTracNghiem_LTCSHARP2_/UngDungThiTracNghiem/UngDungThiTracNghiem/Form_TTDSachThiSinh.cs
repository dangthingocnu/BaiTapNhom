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
    public partial class Form_TTDSachThiSinh : DevExpress.XtraEditors.XtraForm
    {

        Table_ThiSinh ts_current = new Table_ThiSinh();
        ThiSinh_BAL_DLL thisinhbll = new ThiSinh_BAL_DLL();
        public Form_TTDSachThiSinh()
        {
            InitializeComponent();

            loaddgvThiSinh();
            lb_ma.Text = "";
            lb_ten.Text = "";
            lb_dc.Text = "";
            lb_ns.Text = "";
            lb_tr.Text = "";
            lb_l.Text = "";
        }

        private void loaddgvThiSinh()
        {
            dataGridView1.DataSource = thisinhbll.getThiSinh();
        }
        
        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {

            ts_current.MaThiSinh = dataGridView1.CurrentRow.Cells[0].Value.ToString().Trim();
            ts_current.HoTen = dataGridView1.CurrentRow.Cells[1].Value.ToString().Trim();
            ts_current.DiaChi = dataGridView1.CurrentRow.Cells[2].Value.ToString().Trim();
            ts_current.NgaySinh = dataGridView1.CurrentRow.Cells[3].Value.ToString().Trim();
            ts_current.Truong = dataGridView1.CurrentRow.Cells[4].Value.ToString().Trim();
           
            ts_current.Lop = dataGridView1.CurrentRow.Cells[5].Value.ToString().Trim();
           

            lb_ma.Text = ts_current.MaThiSinh;
            lb_ten.Text = ts_current.HoTen;
            lb_dc.Text = ts_current.DiaChi;
            lb_tr.Text = ts_current.Truong;
            lb_ns.Text = ts_current.NgaySinh;
            lb_l.Text = ts_current.Lop;
        }

        private void comboBox_ma_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        
    }
}
