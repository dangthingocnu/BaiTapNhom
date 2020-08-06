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
namespace UngDungThiTracNghiem
{
    public partial class ThongtinTS : Form
    {
        private ThiSinhBS tsbs;
        public delegate string MyDelegate1();
        public MyDelegate1 GetStringFromAnotherForm;
     
        private DataTable dtData = new DataTable();
       
        
        
        public ThongtinTS(DataTable dtData)
        {
            InitializeComponent();
            tsbs = new ThiSinhBS();
            this.dtData = dtData;
           
        }

      

     
        private void ThongtinTS_Load(object sender, EventArgs e)
        {
            label15.Visible = false;
            label11.Text = GetStringFromAnotherForm();
            label11.Visible = false;
            DataTable data = tsbs.GetMonThi().Tables[0];
            comboBox_monthi.DisplayMember = "TenMon";
            comboBox_monthi.ValueMember = "MaMon";
            comboBox_monthi.DataSource = data;
            comboBox_cauhoi.Items.Add("50");
            comboBox_cauhoi.Text = "50";
            tsbs = new ThiSinhBS();
            DataTable dt = new DataTable();
            dt = tsbs.GetThiSinh(label11.Text).Tables[0];
            //lay thong tin tu form dang nhap sang
            foreach (DataRow dr in dtData.Rows)
            {
                label15.Text = dr[0].ToString();
                label8.Text = dr[1].ToString();
                label9.Text = dr[3].ToString();
                label10.Text = dr[2].ToString();
                label7.Text = dr[6].ToString();
                label12.Text = dr[7].ToString();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            tsbs = new ThiSinhBS();
            string a = tsbs.KiemTraMon(comboBox_monthi.SelectedValue.ToString()).Tables[0].Rows[0][0].ToString();
            int b = Int32.Parse(a.ToString());
            if (b < 20)
            {
                MessageBox.Show("Hiện tại môn : " + comboBox_monthi.Text + " chưa đủ câu hỏi để tạo đề thi!");
                return;
            }
            else
            {

                Form_THI f = new Form_THI();
                f.Getten += delegate { return label8.Text; };
                f.Getngaysinh += delegate { return label9.Text; };
                f.Gettruong += delegate { return label7.Text; };
                f.Getlop += delegate { return label12.Text; };
                f.Getmonthi += delegate { return comboBox_monthi.Text; };
                f.Getsocau += delegate { return comboBox_cauhoi.Text; };
                f.Getmamon += delegate { return comboBox_monthi.SelectedValue.ToString(); };
                f.GetMaTS += delegate { return label15.Text; };
                f.Show();
                this.Hide();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult OK;
            OK = MessageBox.Show("Bạn không muốn bắt đầu bài thi ?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (OK == DialogResult.Yes)
            {
                Application.Exit();
            }
            else
                return;
        }
    }
}
