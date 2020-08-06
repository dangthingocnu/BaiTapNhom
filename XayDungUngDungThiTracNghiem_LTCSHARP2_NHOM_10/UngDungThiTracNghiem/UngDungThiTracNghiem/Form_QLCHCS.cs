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
    public partial class Form_QLCHCS : Form
    {
        private ThiSinhBS tsbs;
        public delegate string MyGet();
        public MyGet Laygt;
        public Form_QLCHCS()
        {
            InitializeComponent();
        }
        public void Data()
        {
            tsbs = new ThiSinhBS();
            DataTable dt = tsbs.GetCauHoi().Tables[0];
            dataGridView1.DataSource = dt;

        }
        public void ClearAll()
        {
            textBox1.Text = null;
            textBox2.Text = null;
            textBox3.Text = null;
            textBox4.Text = null;
            textBox5.Text = null;

        }
        public void HienDA()
        {
            tsbs = new ThiSinhBS();
            DataTable dt = tsbs.GetDapAn(dataGridView1.SelectedRows[0].Cells[0].Value.ToString()).Tables[0];
            textBox2.Text = dt.Rows[0][0].ToString();
            textBox3.Text = dt.Rows[1][0].ToString();
            textBox4.Text = dt.Rows[2][0].ToString();
            textBox5.Text = dt.Rows[3][0].ToString();

            txtMaA.Text = dt.Rows[0][2].ToString();
            txtMaB.Text = dt.Rows[1][2].ToString();
            txtMaC.Text = dt.Rows[2][2].ToString();
            txtMaD.Text = dt.Rows[3][2].ToString();

            //Hien thi ket qua dung len radio
            radioButton_a.Checked = (dt.Rows[0]["KieuDapAn"].ToString().Trim() == "1");
            radioButton_b.Checked = (dt.Rows[1]["KieuDapAn"].ToString().Trim() == "1");
            radioButton_c.Checked = (dt.Rows[2]["KieuDapAn"].ToString().Trim() == "1");
            radioButton_d.Checked = (dt.Rows[3]["KieuDapAn"].ToString().Trim() == "1");
        }

        private void Form_QLCHCS_Load(object sender, EventArgs e)
        {
            //label1.Text = Laygt();
            label1.Visible = false;
            tsbs = new ThiSinhBS();
            DataTable dt = tsbs.GetMonThi().Tables[0];
            comboBox_mon.DisplayMember = "TenMon";
            comboBox_mon.ValueMember = "MaMon";
            comboBox_mon.DataSource = dt;

            Data();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                txtMaCH.Text = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
                textBox1.Text = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
                HienDA();
            }
        }

        private void comboBox_mon_SelectedIndexChanged(object sender, EventArgs e)
        {
            tsbs = new ThiSinhBS();
            DataTable dt = tsbs.GetCauHoiNV_Mon(label1.Text, comboBox_mon.SelectedValue.ToString()).Tables[0];
            dataGridView1.DataSource = dt;
        }

        private void btnChinhsua_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                MessageBox.Show("Chọn câu hỏi cần sửa");
            }
            else
            {
                tsbs = new ThiSinhBS();
                int kq = tsbs.UpdateCauHoi(textBox1.Text, label1.Text, txtMaCH.Text, textBox2.Text, txtMaA.Text, textBox3.Text, txtMaB.Text, textBox4.Text, txtMaC.Text, textBox5.Text, txtMaD.Text);
                if (kq != 0)
                {
                    MessageBox.Show("Đã cập nhật câu hỏi");
                    //CAp nhat dap an dung
                    string maCauTraLoi = "";
                    if (radioButton_a.Checked == true)
                        maCauTraLoi = txtMaA.Text;
                    if (radioButton_b.Checked == true)
                        maCauTraLoi = txtMaB.Text;
                    if (radioButton_c.Checked == true)
                        maCauTraLoi = txtMaC.Text;
                    if (radioButton_d.Checked == true)
                        maCauTraLoi = txtMaD.Text;
                    tsbs.UpdateDapAnDung(txtMaCH.Text, maCauTraLoi);
                    Data();
                    ClearAll();
                }
                else
                {
                    MessageBox.Show("Cập nhật thất bại");
                }
            }
        }
    }
}
