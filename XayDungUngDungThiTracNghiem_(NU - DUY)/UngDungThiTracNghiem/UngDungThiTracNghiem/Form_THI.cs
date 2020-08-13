using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;
using System.Runtime.InteropServices;
using Bussiness;
namespace UngDungThiTracNghiem
{
    public partial class Form_THI : Form
    {
        DateTime time;
        private ThiSinhBS tsbs;
        DataTable dt;

        public delegate string GetText();
        public GetText Getten;
        public GetText Getngaysinh;
        public GetText Gettruong;
        public GetText Getlop;
        public GetText Getmonthi;
        public GetText Getsocau;
        public GetText Getmamon;
        public GetText GetMaTS;

        //Khởi tạo mảng lưu các câu hỏi
        ArrayList Array_Cauhoi = new ArrayList();
        ArrayList Array_Mach = new ArrayList();
        //Khởi tạo mảng lưu các đáp án
        ArrayList Array_Dapan = new ArrayList();
        ArrayList Array_Kieudapan = new ArrayList();

        //Duyệt câu hỏi
        public int socauhoi;
        public int place = 0;
        int sch;
        double diem;
        //Khởi tạo mảng GroupBox
        GroupBox[,] GroupBoXCauHoi = new GroupBox[50, 1];
        RadioButton[,] RadioCauTraLoi = new RadioButton[1, 4];
        string str1 = "";
        public Form_THI()
        {
            InitializeComponent();
        }
        public void HienThiGroupBox()
        {
            GroupBox GrpBox;
            Size sideGrpBox = new Size(50, 133);//Kích cỡ

            if (label_socauhoi.Text == "10")
            {
                sch = 10;
                diem = 10;
            }
            else
            {
                sch = 50;
                diem = 2;//Chia theo ti le: 50 cau <->10 diem => 1 cau=10/50=0.2 diem
            }
            for (int i = 0; i < sch; i++)
                for (int j = 0; j < 1; j++)
                {
                    GrpBox = new GroupBox();//Tạo GroupBox
                    int cau = i + 1;
                    GrpBox.Text = cau.ToString();//Text
                    GrpBox.Size = sideGrpBox;//Kích cỡ
                    GrpBox.Location = new Point(5 + i * 40, 5 + 133 * j);//Vị trí trong Form
                    RadioButton Radiobt;
                    Size sideradio = new Size(20, 20);//Kích cỡ
                    for (int k = 0; k < 1; k++)
                        for (int l = 0; l < 4; l++)
                        {
                            Radiobt = new RadioButton();//Tạo Radiobutton
                            Radiobt.Size = sideradio;//Kích cỡ
                            Radiobt.Location = new Point(14 + k * 20, 20 + l * 27);//Vị trí trong GroupBox
                            //Radiobt.CheckedChanged += new EventHandler(Radiobt_CheckedChanged);//Tạo sự kiện
                            GrpBox.Controls.Add(Radiobt);//Add Radio vào GroupBox
                            RadioCauTraLoi[k, l] = Radiobt;
                        }
                    panelSroll.Controls.Add(GrpBox);
                    // this.groupBox2.Controls.Add(GrpBox);//Add GroupBox vào Form
                    GroupBoXCauHoi[i, j] = GrpBox;
                }
        }
        public void KetThuc()
        {
            //Lấy GruopBox các đáp án trong GruopBox Đáp án
            //IEnumerator ie=this.groupBox2.Controls.GetEnumerator();
            IEnumerator ie = panelSroll.Controls.GetEnumerator();
            int i = 0;
            int j = 0;
            GroupBox[] mgroupbox = new GroupBox[sch];
            while (ie.MoveNext())
            {
                i++;
                if (i <= sch)
                {
                    try
                    {
                        GroupBox r = (GroupBox)ie.Current;
                        mgroupbox[j] = r;
                        j++;
                    }
                    catch
                    {
                        MessageBox.Show("Khong phai groupbox" + i);
                    }
                }

            }

            //Lấy Radiobutton trong GroupBox trả lời 
            int[] mangdapan = new int[sch];

            for (int k = 0; k < mgroupbox.Length; k++)
            {
                RadioButton[] ra = new RadioButton[4];
                IEnumerator ie2 = mgroupbox[k].Controls.GetEnumerator();
                i = 0;
                while (ie2.MoveNext())
                {
                    ra[i] = (RadioButton)ie2.Current;
                    i++;


                }
                mangdapan[k] = XetRadio(ra);
            }

            //Message Box kiểm tra các đáp án được chọn
            String str = "";
            int cdd = 0;
            for (int y = 0; y < sch; y++)
            {
                str += mangdapan[y];
                if (mangdapan[y].ToString().Trim() != "0")
                {
                    cdd++;
                }
            }

            foreach (object s in madapandung)
            {
                str1 += s.ToString();
            }
            //MessageBox.Show(str1);
            double socaudung = Chamdiem(madapandung, mangdapan);
            double ketqua = (socaudung * diem) / 10;

            //Thêm kết quả của thí sinh
            tsbs = new ThiSinhBS();
            string maTS = lbMaTS.Text;
            string maMon = label_mamon.Text;
            string ngayThi = label_ngaythi.Text;

            tsbs.ThemKetQua(maTS, ketqua.ToString(), maMon, ngayThi);
            //---Luu lua chon tung cau hoi cho bai thi---
            for (int index = 0; index < sch; index++)
            {
                try
                {
                    string maCH = Array_Mach[index].ToString();
                    string luaChon = mangdapan[index].ToString();
                    string dapAn = madapandung[index].ToString();
                    tsbs.LuuBaiThi(maTS, maCH, maMon, ngayThi, luaChon, dapAn);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Loi:" + ex.Message);
                }
            }

            //Hiện kết quả
            Form_KetQua f = new Form_KetQua();
            f.GetTen += delegate { return label_ten.Text; };
            f.GetCDD += delegate { return cdd.ToString(); };
            f.GetTS += delegate { return label_socauhoi.Text; };
            f.GetSoCau += delegate { return socaudung.ToString(); };
            f.GetDiem += delegate { return ketqua.ToString(); };
            f.Show();
            this.Hide();
        }
        ArrayList madapandung = new ArrayList();
        public void Hienthicauhoi(int cau)
        {
            label_noidungcauhoi.Text = "Câu " + (cau + 1) + " : " + Array_Cauhoi[cau].ToString();
            label_macauhoi.Text = Array_Mach[cau].ToString();
            Hienthidapan(cau);
        }

        //Hàm hiển thị các đáp án
        public void Hienthidapan(int b)
        {
            label_dapan1.Text = Array_Dapan[0 + (b * 4)].ToString();
            label_dapan2.Text = Array_Dapan[1 + (b * 4)].ToString();
            label_dapan3.Text = Array_Dapan[2 + (b * 4)].ToString();
            label_dapan4.Text = Array_Dapan[3 + (b * 4)].ToString();
        }

        //Hàm thông báo thời gian
        public void Thongbao()
        {
            if (lblTime.Text == "00:05:00")
            {
                MessageBox.Show("Thời gian còn lại là 5 phút");
            }
            if (lblTime.Text == "00:03:00")
            {
                lblTime.Text = "Thời gian làm bài sắp hết,thí sinh kiểm tra phần trả lời của mình!";
            }
            if (lblTime.Text == "00:01:00")
            {
                lblTime.ForeColor = Color.FromName("Red");
                lblTime.ForeColor = Color.FromName("Red");
            }
            if (lblTime.Text == "00:00:00")
            {
                timer1.Stop();
                lblTime.Text = "";
                MessageBox.Show("Đã hết thời gian làm bài thi");
                KetThuc();
            }
        }
        public int Chamdiem(ArrayList dapan, int[] traloi)
        {
            int dem = 0;
            for (int i = 0; i < dapan.Count; i++)
            {
                if (dapan[i].ToString().Equals(traloi[i].ToString()))
                {
                    dem++;
                }
            }
            return dem;
        }

        //Kiểm tra Radiobutton có được check hay ko? nếu check=1-4, không check=0
        public int XetRadio(RadioButton[] radio)
        {
            for (int i = 0; i < radio.Length; i++)
            {
                if (radio[i].Checked)
                {
                    return i + 1;
                }
            }
            return 0;

        }
       
        public void Label()
        {
            Label a = new Label(); a.Text = "A"; a.Location = new Point(20, 45); groupBox2.Controls.Add(a);
            Label b = new Label(); b.Text = "B"; b.Location = new Point(20, 72); groupBox2.Controls.Add(b);
            Label c = new Label(); c.Text = "C"; c.Location = new Point(20, 99); groupBox2.Controls.Add(c);
            Label d = new Label(); d.Text = "D"; d.Location = new Point(20, 126); groupBox2.Controls.Add(d);

        }

        private void btnNopbai_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            DialogResult OK;
            OK = MessageBox.Show("Thời gian vẫn còn! Bạn muốn kết thúc bài thi?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (OK == DialogResult.Yes)
            {
                KetThuc();
            }
            else
            {
                timer1.Start();
                return;
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            DialogResult OK;
            OK = MessageBox.Show("Bạn muốn hủy bỏ bài thi? Nếu chấp nhận, kết quả sẽ không được ghi nhận! Bạn có chắc không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (OK == DialogResult.Yes)
            {
                Application.Exit();
            }
            else
            {
                timer1.Start();
                return;
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Hienthicauhoi(socauhoi - 1);
            place = socauhoi - 1;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (place == socauhoi - 1)
            {
                Hienthicauhoi(socauhoi - 1);
            }
            else
            {
                place++;
                Hienthicauhoi(place);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (place == 0)
            {
                Hienthicauhoi(0);
            }
            else
            {
                place--;
                Hienthicauhoi(place);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Hienthicauhoi(0);
            place = 0;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            TimeSpan timespan = new TimeSpan(0, 0, 1);
            time = time.Subtract(timespan);
            if (time.Minute < 10)
            {
                if (time.Second < 10)
                {
                    lblTime.Text = "00:0" + time.Minute.ToString() + ":0" + time.Second.ToString();
                }
                else
                {
                    lblTime.Text = "00:0" + time.Minute.ToString() + ":" + time.Second.ToString();
                }
            }
            else
            {
                if (time.Second < 10)
                {
                    lblTime.Text = "00:" + time.Minute.ToString() + ":0" + time.Second.ToString();
                }
                else
                {
                    lblTime.Text = "00:" + time.Minute.ToString() + ":" + time.Second.ToString();
                }
            }
            Thongbao();
        }

        private void Form_THI_Load(object sender, EventArgs e)
        {
            //Khởi động thời gian đếm ngược
            time = new DateTime(2014, 09, 09, 00, 59, 59, 999);
            timer1.Interval = 1000;
            timer1.Start();

            //Lấy thông tin thí sinh
            label_ten.Text = Getten();
            label_ngaysinh.Text = Getngaysinh();
            label_lop.Text = Getlop();
            label_truong.Text = Gettruong();
            label_monthi.Text = Getmonthi();
            label_socauhoi.Text = Getsocau();
            lbMaTS.Text = GetMaTS();
            lbMaTS.Visible = false;


            //Lấy mã môn thi
            label_mamon.Text = Getmamon();
            label_mamon.Visible = false;


            label_macauhoi.Visible = false;

            //Hiển thị ngày/tháng/năm hiện hành
            label_ngaythi.Text = System.DateTime.Now.Day.ToString() + "/" + System.DateTime.Now.Month.ToString() + "/" + System.DateTime.Now.Year.ToString();

            //Lấy giá trị câu hỏi
            if (label_socauhoi.Text == "10")
            {
                socauhoi = 10;
            }
            else
            {
                //socauhoi = 20;
                socauhoi = 50;
            }

            //Lấy câu hỏi và lưu vào mảng--------------------------------------------
            tsbs = new ThiSinhBS();
            dt = tsbs.RanDom50CauHoi(label_mamon.Text);
            for (int i = 0; i < socauhoi; i++)
            {
                Array_Cauhoi.Add(dt.Rows[i][1].ToString());
                Array_Mach.Add(dt.Rows[i][0].ToString());
                DataTable dt2 = tsbs.GetDapAn(Array_Mach[i].ToString()).Tables[0];
                for (int j = 0; j < 4; j++)
                {
                    Array_Dapan.Add(dt2.Rows[j][0].ToString());
                    Array_Kieudapan.Add(dt2.Rows[j][1].ToString());
                    if (dt2.Rows[j][1].ToString().Trim().Equals("1"))
                    {
                        madapandung.Add(Convert.ToString(j + 1));
                    }
                }
            }
            //------------------------------------------------------------------------
            //Hiển thị câu hỏi đầu tiên
            Hienthicauhoi(0);

            //Thông báo

            //Hiển thị GroupBox
            HienThiGroupBox();

            Label();
            string tr = "";
            foreach (object o in madapandung)
            {
                tr += o.ToString() + ";";
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
