using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using Bussiness;
namespace UngDungThiTracNghiem
{
    public partial class frmDangNhap : DevExpress.XtraEditors.XtraForm
    {
        private ThiSinhBS tsbs;
        private GiaoVienBS nvbs;
        public delegate string Mydlg();
        public Mydlg GetStringFromAnotherFormdn;
        
        public frmDangNhap()
        {
            InitializeComponent();
          //  DevExpress.LookAndFeel.UserLookAndFeel.Default.SetSkinStyle("Coffee");
        }

        private void radioButton_quanli_CheckedChanged(object sender, EventArgs e)
        {
            textBox_dn.Text = "";
            textBox_pa.Text = "";
            label1.Text = "Tên người quản lý:";
            groupBox1.Text = "Thông tin người quản lý";
           
        }

        private void radioButton_thisinh_CheckedChanged(object sender, EventArgs e)
        {
            textBox_dn.Text = "";
            textBox_pa.Text = "";
            label1.Text = "Tên thí sinh:";
            groupBox1.Text = "Thông tin thí sinh:";
        }

        private void frmDangNhap_Load(object sender, EventArgs e)
        {
            textBox_dn.Focus();
        }
        public void status()
        {
            textBox_dn.Text = "";
            textBox_pa.Text = "";

            radioButton_quanli.Visible = true;
            radioButton_thisinh.Visible = true;
            btn_dn.Visible = true;
            btn_thoat.Visible = true;
            label1.Text = "Tên thí sinh:";
            label2.Text = "Mật khẩu:";
            groupBox1.Text = "Thông tin thí sinh";

        }

        private void btn_dn_Click(object sender, EventArgs e)
        {
            if (radioButton_thisinh.Checked == true)
            {
                if (textBox_dn.Text == "" || textBox_pa.Text == "")
                {
                    MessageBox.Show("Nhập đầy đủ thông tin của thí sinh");
                    textBox_dn.Focus();
                }
                else
                {
                    tsbs = new ThiSinhBS();
                    DataTable dt = new DataTable();
                    dt = tsbs.GetThiSinhDN(textBox_dn.Text, textBox_pa.Text).Tables[0];
                    if (dt.Rows.Count > 0)
                    {
                        ThongtinTS ts = new ThongtinTS(dt);
                        ts.GetStringFromAnotherForm += delegate { return textBox_pa.Text; };
                        ts.Show();
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("Tên đăng nhập hoặc mật khẩu không tồn tại");
                    }
                }
            }
            else
            {
                if (textBox_dn.Text == "" || textBox_pa.Text == "")
                {
                    MessageBox.Show("Nhập đầy đủ thông tin của người quản lý");
                    textBox_dn.Focus();
                }
                else
                {
                    nvbs = new GiaoVienBS();
                    DataTable dt = new DataTable();
                    dt = nvbs.DangNhapNV(textBox_dn.Text, textBox_pa.Text).Tables[0];
                    if (dt.Rows.Count > 0)
                    {
                        DataRow dr;
                        dr = dt.Rows[0];
                        Form_Dieuhanh d = new Form_Dieuhanh();
                        d.GetStringFromAnotherFormdn += delegate { return textBox_pa.Text; };
                        d.GetStringFromAnotherFormdn2 += delegate { return dr[10].ToString(); };
                        MySession.strUserName = dr["MaNguoiDung"].ToString();
                        d.Show();
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("Tên đăng nhập hoặc mật khẩu không đúng");
                    }
                }
            }
        }

        private void btn_thoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void frmDangNhap_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult OK = MessageBox.Show("Bạn muốn thoát khỏi ứng dụng ?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (OK == DialogResult.Yes)
            {
                Application.Exit();
            }
            else
                return;
        }
      }
    
}