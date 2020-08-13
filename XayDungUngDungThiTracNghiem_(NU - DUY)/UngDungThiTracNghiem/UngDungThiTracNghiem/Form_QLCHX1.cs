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
using DevExpress.XtraEditors;
namespace UngDungThiTracNghiem
{
    public partial class Form_QLCHX1 : DevExpress.XtraEditors.XtraForm
    {
        private ThiSinhBS tsbs;
        public delegate string MyGet();
        public MyGet Laygt;
        public Form_QLCHX1()
        {
            InitializeComponent();
        }

        private void Form_QLCHX_Load(object sender, EventArgs e)
        {
            //label1.Text = Laygt();
            label1.Visible = false;
            label4.Visible = false;

            tsbs = new ThiSinhBS();
            DataTable dt = tsbs.GetMonThi().Tables[0];
            comboBox_mon.DisplayMember = "TenMon";
            comboBox_mon.ValueMember = "MaMon";
            comboBox_mon.DataSource = dt;

            Data();
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
            try
            {
                tsbs = new ThiSinhBS();
                DataTable dt = tsbs.GetDapAn(dataGridView1.SelectedRows[0].Cells[0].Value.ToString()).Tables[0];
                textBox2.Text = dt.Rows[0][0].ToString();
                textBox3.Text = dt.Rows[1][0].ToString();
                textBox4.Text = dt.Rows[2][0].ToString();
                textBox5.Text = dt.Rows[3][0].ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Loi:" + ex.Message);
            }

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {

                label4.Text = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
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

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                MessageBox.Show("Chọn câu hỏi muốn xóa");
            }
            else
            {
                try
                {
                    tsbs = new ThiSinhBS();
                    int kq = tsbs.DeleteCauHoi(label4.Text);
                    if (kq != 0)
                    {
                        MessageBox.Show("Xóa thành công");
                        ClearAll();
                        Data();
                    }
                    else
                    {

                        MessageBox.Show("Không xóa được");
                        ClearAll();
                        Data();
                    }
                }
                catch (Exception)
                {
                    MessageBox.Show("Không xóa được");
                }
            }

        }
    }
}
