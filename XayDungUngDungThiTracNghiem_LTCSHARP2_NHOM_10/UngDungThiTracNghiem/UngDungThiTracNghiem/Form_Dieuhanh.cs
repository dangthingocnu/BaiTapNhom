using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraBars;
using Bussiness;
namespace UngDungThiTracNghiem
{
    public partial class Form_Dieuhanh : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        private GiaoVienBS nvbs;
        private ThiSinhBS tsbs;
        public delegate string Mydlg();
        public Mydlg GetStringFromAnotherFormdn;
        public Mydlg GetStringFromAnotherFormdn2;
        public int sl;
        public int flag = 0;
        public Form_Dieuhanh()
        {
            InitializeComponent();
            DevExpress.LookAndFeel.UserLookAndFeel.Default.SetSkinStyle("Coffee");
        }
        public bool Check_View_Form(Form frm)
        {
            bool isOpen = false;
            if (MdiChildren.Count() > 0)
            {
                foreach (var item in MdiChildren)
                {
                    if (frm.Name == item.Name)
                    {
                        xtraTabbedMdiManager1.Pages[item].MdiChild.Activate();
                        isOpen = true;
                    }
                }
            }
            return isOpen;
        }
        public void View_Main(Form frm)
        {
            if (!Check_View_Form(frm))
            {
                frm.MdiParent = this;
                frm.Show();
            }
        }
        Boolean KiemTraTonTai(string Frmname)
        {
            foreach (Form frm in this.MdiChildren)
            {
                if (frm.Name.Equals(Frmname))
                {
                    frm.Activate();
                    return true;
                }
            }
            return false;
        }
        private void barButtonItem1_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (KiemTraTonTai("Form_DangNhap") == false)
            {
                Form_DangNhap f = new Form_DangNhap();
                View_Main(f);
            }
        }

        private void barButtonItem2_ItemClick(object sender, ItemClickEventArgs e)
        {
            Application.Exit();
        }

        private void barButtonItem3_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (KiemTraTonTai("Form_TTNganHangCauHoi") == false)
            {
                Form_TTNganHangCauHoi f = new Form_TTNganHangCauHoi();
                View_Main(f);
            }
        }

        private void barButtonItem4_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (KiemTraTonTai("Form_TTDSachThiSinh") == false)
            {
                Form_TTDSachThiSinh f = new Form_TTDSachThiSinh();
                View_Main(f);
            }
        }

        private void barButtonItem5_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (KiemTraTonTai("Form_TTDSachGiaoVien") == false)
            {
                Form_TTDSachGiaoVien f = new Form_TTDSachGiaoVien();
                View_Main(f);
            }
        }

        private void barButtonItem6_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (KiemTraTonTai("Form_TTDSachKetQua") == false)
            {
                Form_TTDSachKetQua f = new Form_TTDSachKetQua();
                View_Main(f);
            }
        }

        private void barButtonItem7_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (KiemTraTonTai("Form_QLGV") == false)
            {
                Form_QLGV f = new Form_QLGV();
                View_Main(f);
            }
        }

        private void barButtonItem8_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (KiemTraTonTai("Form_XoaGiaoVien") == false)
            {
                Form_XoaGiaoVien f = new Form_XoaGiaoVien();
                View_Main(f);
            }
        }

        private void barButtonItem9_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (KiemTraTonTai("Form_QLMonThi") == false)
            {
                Form_QLMonThi f = new Form_QLMonThi();
                View_Main(f);
            }
        }

        private void barButtonItem10_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (KiemTraTonTai("Form_QLCH") == false)
            {
                Form_QLCH f = new Form_QLCH();
                View_Main(f);
            }
        }

        private void barButtonItem11_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (KiemTraTonTai("Form_QLCHCS") == false)
            {
                Form_QLCHCS f = new Form_QLCHCS();
                View_Main(f);
            }
        }

        private void barButtonItem12_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (KiemTraTonTai("Form_QLCHX") == false)
            {
                Form_QLCHX f = new Form_QLCHX();
                View_Main(f);
            }
        }

        private void barButtonItem13_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (KiemTraTonTai("Form_LienHe") == false)
            {
                Form_LienHe f = new Form_LienHe();
                View_Main(f);
            }
        }

    }
}