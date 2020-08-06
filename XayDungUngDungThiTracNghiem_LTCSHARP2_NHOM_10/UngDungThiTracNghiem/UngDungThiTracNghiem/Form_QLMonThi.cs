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
    public partial class Form_QLMonThi : Form
    {
        private ThiSinhBS tsbs;
        public Form_QLMonThi()
        {
            InitializeComponent();
        }
        //public void LoadFormMin()
        //{
        //    this.ClientSize = new Size(533, 134);
        //    LoadCombo();
        //    label3.Visible = false;
        //    label4.Visible = false;
        //    label5.Visible = false;
        //    textBox_themma.Visible = false;
        //    textBox_themmon.Visible = false;
        //    textBox_soch.Text = "";
        //    textBox_mamon.Text = "";
        //    comboBox_tenmon.Enabled = true;
        //    textBox_mamon.Enabled = true;
        //    textBox_soch.Enabled = true;
        //}
        ////public void LoadFormMax()
        //{
        //    this.ClientSize = new Size(533, 230);
        //    comboBox_tenmon.Enabled = false;
        //    textBox_mamon.Enabled = false;
        //    textBox_soch.Enabled = false;
        //    label3.Visible = true;
        //    label4.Visible = true;
        //    label5.Visible = true;
        //    textBox_themma.Visible = true;
        //    textBox_themmon.Visible = true;
        //}
        public void LoadCombo()
        {
            tsbs = new ThiSinhBS();
            DataTable dt = tsbs.GetMonThi().Tables[0];
            comboBox_tenmon.DisplayMember = "TenMon";
            comboBox_tenmon.ValueMember = "MaMon";
            comboBox_tenmon.DataSource = dt;

        }
        public void LoadSoCH()
        {
            tsbs = new ThiSinhBS();
            textBox_soch.Text = tsbs.SoCH_Mon(comboBox_tenmon.SelectedValue.ToString()).Tables[0].Rows[0][0].ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (button1.Text == "Thêm môn")
            {
                //LoadFormMax();
                button1.Text = "Hủy";
                button2.Text = "Lưu";
            }
            else
            {
                //LoadFormMin();
                button1.Text = "Thêm môn";
                button2.Text = "Xóa môn";
            }
        }

        private void comboBox_tenmon_SelectedIndexChanged(object sender, EventArgs e)
        {
            textBox_mamon.Text = comboBox_tenmon.SelectedValue.ToString();
            LoadSoCH();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (button2.Text == "Lưu")
            {
                if (textBox_themma.Text == "" || textBox_themmon.Text == "")
                {
                    MessageBox.Show("Nhập đầy đủ thông tin");
                }
                else
                {
                    try
                    {
                        tsbs = new ThiSinhBS();
                        int kq = tsbs.ThemMon(textBox_themma.Text, textBox_themmon.Text);
                        if (kq == 1)
                        {
                            MessageBox.Show("Đã thêm môn: " + textBox_themmon.Text);
                            //LoadFormMin();
                            button1.Text = "Thêm môn";
                            button2.Text = "Xóa môn";
                            textBox_themma.Text = "";
                            textBox_themmon.Text = "";
                        }
                        else
                        {
                            MessageBox.Show("Không thể thêm được");
                            //LoadFormMin();
                            button1.Text = "Thêm môn";
                            button2.Text = "Xóa môn";
                            textBox_themma.Text = "";
                            textBox_themmon.Text = "";
                        }
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("Trùng mã môn");
                    }
                }
            }
            else
            {
                if (textBox_mamon.Text == "")
                {
                    MessageBox.Show("Chọn môn muốn xóa");
                }
                else
                {
                    if (textBox_soch.Text != "0")
                    {
                        MessageBox.Show("Không thể xóa môn: " + comboBox_tenmon.Text + " Môn này có: " + textBox_soch.Text + " câu hỏi trong ngân hàng câu hỏi");
                        textBox_mamon.Text = "";
                        textBox_soch.Text = "";
                    }
                    else
                    {
                        DialogResult OK;
                        OK = MessageBox.Show("Bạn muốn xóa môn: " + comboBox_tenmon.Text + " Môn này không có câu hỏi nào trong ngân hàng câu hỏi. Bạn chắc chắn muốn xóa!", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                        if (OK == DialogResult.Yes)
                        {
                            tsbs = new ThiSinhBS();
                            int kq = tsbs.XoaMon_0(comboBox_tenmon.SelectedValue.ToString()); ;
                            if (kq != 0)
                            {
                                MessageBox.Show("Đã xóa môn: " + comboBox_tenmon.Text);
                                //LoadFormMin();

                            }
                        }
                        else
                        {
                            //LoadFormMin();
                            return;
                        }
                    }
                }
            }
        }

        private void Form_QLMonThi_Load(object sender, EventArgs e)
        {
            LoadCombo();
            LoadSoCH();
        }
        

    }
}
