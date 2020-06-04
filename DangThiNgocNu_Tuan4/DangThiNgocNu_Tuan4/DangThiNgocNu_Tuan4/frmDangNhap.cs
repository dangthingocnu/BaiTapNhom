using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DangThiNgocNu_Tuan4
{
    public partial class frmDangNhap : Form
    {
        QL_NguoiDung CauHinh = new QL_NguoiDung();
        public frmDangNhap()
        {
            InitializeComponent();
            CenterToScreen();
        }

        private void btndangNhap_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtUsername.Text.Trim()))
            {
                MessageBox.Show("Không được bỏ trống" + lblUsername.Text.ToLower());
                this.txtUsername.Focus();
                return;
            }
            if (string.IsNullOrEmpty(this.txtPassword.Text))
            {
                MessageBox.Show("Không được bỏ trống" + lblPassword.Text.ToLower());
                this.txtPassword.Focus();
                return;
            }
            int kq = CauHinh.Check_Config();
            if (kq == 0)
            {
                ProcessLogin();
            }
            if (kq == 1)
            {
                MessageBox.Show("Chuỗi cấu hình không tồn tại");
                ProcessConfig();
            }
            if (kq == 2)
            {
                MessageBox.Show("Chuỗi cấu hình không phù hợp");
               ProcessConfig();
            }
        }
        public void ProcessConfig()
        {
            frmCauHinh fcauhinh = new frmCauHinh();
            fcauhinh.Show();
        }
        public void ProcessLogin()
        {
            string pw = QL_NguoiDung.Encrypt(txtPassword.Text, QL_NguoiDung.PUBLIC_KEY);
           
            LoginResult result;
            result = CauHinh.Check_User(txtUsername.Text, txtPassword.Text);
            if (result == LoginResult.Invalid)
            {
                MessageBox.Show("Sai " + lblUsername.Text + " Hoặc " + lblPassword.Text);
                return;
            }
            else if (result == LoginResult.Disabled)
            {
                 MessageBox.Show("Tài khoản bị khóa");
                 return;
            }
            if (Program.mainForm == null || Program.mainForm.IsDisposed)
            {
                 
                Program.mainForm = new frmMain();
            }
            this.Visible = false;
            Program.mainForm.Show();

     

        }
    }
 }
