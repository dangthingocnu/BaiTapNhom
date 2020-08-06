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
    public partial class Form_TTNganHangCauHoi : Form
    {
        
        public ThiSinhBS tsbs;
        public Form_TTNganHangCauHoi()
        {
            InitializeComponent();
            tsbs = new ThiSinhBS();
            dataGridView1.DataSource = tsbs.GetCauHoi().Tables[0];
        }
       
        
        private void Form_TTNganHangCauHoi_Load(object sender, EventArgs e)
        {
            
        }
        public void HienthiDA()
        {
            ThiSinhBS tsbs = new ThiSinhBS();
            DataTable dt = tsbs.GetDapAn(dataGridView1.SelectedRows[0].Cells[0].Value.ToString()).Tables[0];
            richTextBox1.Text = dt.Rows[0][0].ToString();
            richTextBox2.Text = dt.Rows[1][0].ToString();
            richTextBox3.Text = dt.Rows[2][0].ToString();
            richTextBox4.Text = dt.Rows[3][0].ToString();
            richTextBox5.Text = tsbs.GetDapAnDung(dataGridView1.SelectedRows[0].Cells[0].Value.ToString()).Tables[0].Rows[0][0].ToString();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                richTextBox_cauhoi.Text = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
                HienthiDA();
            }
        }

       
    }
}
