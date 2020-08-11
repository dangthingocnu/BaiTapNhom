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

namespace UngDungThiTracNghiem
{
    public partial class Form_KetQua : DevExpress.XtraEditors.XtraForm
    {
        public delegate string GetKetQua();
        public GetKetQua GetTen;
        public GetKetQua GetCDD;
        public GetKetQua GetSoCau;
        public GetKetQua GetDiem;
        public GetKetQua GetTS;
        public Form_KetQua()
        {
            InitializeComponent();
        }

        private void Form_KetQua_Load(object sender, EventArgs e)
        {
            label4.Visible = false;
            label4.Text = GetTS();
            label3.Text = "Kết quả bài thi của bạn: " + GetTen();
            label5.Text = "- Số câu đã trả lời: " + GetCDD() + "/" + label4.Text;
            label1.Text = "- Số câu trả lời đúng: " + GetSoCau() + "/" + label4.Text;
            label2.Text = "- Điểm của bài thi: " + GetDiem();
        }

        private void button1_Click(object sender, EventArgs e)
        {
          //  Form_KetQua f1 = new Form_KetQua();
          //  f1.Close();
          ////Application.Exit();
            frmDangNhap f = new frmDangNhap();
            this.Hide();
            f.Show();
        }
    }
}
