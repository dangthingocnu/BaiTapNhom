using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data.Sql;
using System.Security.Cryptography;
using System.IO;
namespace DangThiNgocNu_Tuan4
{
    public partial class frmCauHinh : Form
    {
        QL_NguoiDung CauHinh = new QL_NguoiDung();
        public frmCauHinh()
        {
            InitializeComponent();
        }

        public DataTable GetServerName()
        {
            SqlDataSourceEnumerator instance =
            SqlDataSourceEnumerator.Instance;
            System.Data.DataTable table = instance.GetDataSources();
            return table;
        }
        private void cboServer_DropDown(object sender, EventArgs e)
        {
            //cboServer.DataSource = CauHinh.GetServerName();
            //cboServer.DisplayMember = "ServerName";
            DataTable dt = GetServerName();
            cboServer.Items.Clear();
            foreach (System.Data.DataRow row in dt.Rows)
            {
                foreach (System.Data.DataColumn col in dt.Columns)
                {
                    cboServer.Items.Add(string.Format(@"{0}\{1}", row[col], "SQLEXPRESS"));
                }
            }
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            CauHinh.SaveConfig(cboServer.Text, txtuser.Text, txtpass.Text,cboDatabase.Text);
            this.Close();
        }

        private void cboDatabase_DropDown(object sender, EventArgs e)
        {
            cboDatabase.DataSource = CauHinh.GetDBName(cboServer.Text, txtuser.Text, txtpass.Text);
            cboDatabase.DisplayMember="name";
        }

      
    }
}
