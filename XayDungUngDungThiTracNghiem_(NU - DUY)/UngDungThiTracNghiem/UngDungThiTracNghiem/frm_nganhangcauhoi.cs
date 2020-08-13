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
    public partial class frm_nganhangcauhoi : DevExpress.XtraEditors.XtraForm
    {
        public ThiSinhBS tsbs;
        public GiaoVienBS nvbs;
        public frm_nganhangcauhoi()
        {
            InitializeComponent();
        }

        private void frm_nganhangcauhoi_Load(object sender, EventArgs e)
        {
            tsbs = new ThiSinhBS();
            DataTable dt = tsbs.GetMonThi().Tables[0];
            comboBox_mon.DisplayMember = "TenMon";
            comboBox_mon.ValueMember = "MaMon";
            comboBox_mon.DataSource = dt;

          

            tsbs = new ThiSinhBS();
            dataGridView1.DataSource = tsbs.GetCauHoi().Tables[0];
        }

        private void comboBox_mon_SelectedIndexChanged(object sender, EventArgs e)
        {
            tsbs = new ThiSinhBS();
            dataGridView1.DataSource = tsbs.GetCauHoi_Mon(comboBox_mon.SelectedValue.ToString()).Tables[0];
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            
            if (dataGridView1.SelectedRows.Count > 0)
            {
                richTextBox_cauhoi.Text=dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
                HienthiDA();
            }
        }
        public void HienthiDA()
        {
            tsbs = new ThiSinhBS();
            DataTable dt = tsbs.GetDapAn(dataGridView1.SelectedRows[0].Cells[0].Value.ToString()).Tables[0];
            richTextBox1.Text = dt.Rows[0][0].ToString();
            richTextBox2.Text = dt.Rows[1][0].ToString();
            richTextBox3.Text = dt.Rows[2][0].ToString();
            richTextBox4.Text = dt.Rows[3][0].ToString();
            richTextBox5.Text = tsbs.GetDapAnDung(dataGridView1.SelectedRows[0].Cells[0].Value.ToString()).Tables[0].Rows[0][0].ToString();
        }
    }
}
