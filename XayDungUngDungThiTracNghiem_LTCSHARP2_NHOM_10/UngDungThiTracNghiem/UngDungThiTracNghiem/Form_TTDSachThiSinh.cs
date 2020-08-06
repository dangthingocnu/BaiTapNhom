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
    public partial class Form_TTDSachThiSinh : Form
    {
        
        private ThiSinhBS tsbs;
        public Form_TTDSachThiSinh()
        {
            InitializeComponent();
            
            tsbs = new ThiSinhBS();
            DataTable dt = new DataTable();
            dt = tsbs.GetThiSinh().Tables[0];
           
            dataGridView1.DataSource = dt;
            lb_ma.Text = "";
            lb_ten.Text = "";
            lb_dc.Text = "";
            lb_ns.Text = "";
            lb_tr.Text = "";
            lb_l.Text = "";
        }
        

        
        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            
            if (dataGridView1.SelectedRows.Count > 0)
            {
                lb_ma.Text = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
                lb_ten.Text = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
                lb_dc.Text = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
                lb_ns.Text = dataGridView1.SelectedRows[0].Cells[3].Value.ToString();
                lb_tr.Text = dataGridView1.SelectedRows[0].Cells[4].Value.ToString();
                lb_l.Text = dataGridView1.SelectedRows[0].Cells[5].Value.ToString();
            }
        }

        private void comboBox_ma_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        
    }
}
