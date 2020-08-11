using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using Bussiness;


namespace UngDungThiTracNghiem
{
    public partial class FrmChiTietBaiThi : Form
    {
        string maTS = "0001      ";
        string maMon = "CS1";
        string ngayThi = "16/6/2014";
        public FrmChiTietBaiThi(string hoTen,string monThi,string diem, string maTS,string maMon,string ngayThi)
        {
            InitializeComponent();
            HienThiKetQua(maTS, maMon, ngayThi);
            lbHoTen.Text ="Họ tên: "+ hoTen;
            lbMonThi.Text ="Môn thi: "+ monThi;
            lbDiem.Text ="Điểm số: "+ diem;
        }
      
        private void HienThiKetQua(string maTS, string maMon, string ngayThi)
        {
            ThiSinhBS tsbs = new ThiSinhBS();
            DataTable dtData=tsbs.ChiTietBaiThi(maTS,maMon,ngayThi);
            int x = 0, y = 0;
            for (int i = 0; i < dtData.Rows.Count; i++)
            {
                DataRow row = dtData.Rows[i];
                string noiDung ="Câu "+(i+1)+": "+ row["NoiDung"].ToString();
                string DAA = row["DAA"].ToString();
                string DAB = row["DAB"].ToString();
                string DAC = row["DAC"].ToString();
                string DAD = row["DAD"].ToString();
                int luaChon = int.Parse(row["LuaChon"].ToString());
                int dapAn = int.Parse(row["DapAn"].ToString());
                UCBaiThi ucBaiThi = new UCBaiThi(noiDung,DAA,DAB,DAC,DAD,luaChon,dapAn);
                ucBaiThi.Location = new Point(x, y);
                ucBaiThi.Width = panelBaiThi.Width-2;
                panelBaiThi.Controls.Add(ucBaiThi);
                y += ucBaiThi.Height;
            }
           
        }
    }
}
