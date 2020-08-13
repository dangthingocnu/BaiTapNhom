namespace UngDungThiTracNghiem
{
    partial class frmDangNhap
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btn_thoat = new System.Windows.Forms.Button();
            this.btn_dn = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.textBox_pa = new System.Windows.Forms.TextBox();
            this.textBox_dn = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.radioButton_quanli = new System.Windows.Forms.RadioButton();
            this.radioButton_thisinh = new System.Windows.Forms.RadioButton();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_thoat
            // 
            this.btn_thoat.Location = new System.Drawing.Point(467, 363);
            this.btn_thoat.Margin = new System.Windows.Forms.Padding(4);
            this.btn_thoat.Name = "btn_thoat";
            this.btn_thoat.Size = new System.Drawing.Size(194, 75);
            this.btn_thoat.TabIndex = 11;
            this.btn_thoat.Text = "Thoát";
            this.btn_thoat.UseVisualStyleBackColor = true;
            this.btn_thoat.Click += new System.EventHandler(this.btn_thoat_Click);
            // 
            // btn_dn
            // 
            this.btn_dn.Location = new System.Drawing.Point(233, 363);
            this.btn_dn.Margin = new System.Windows.Forms.Padding(4);
            this.btn_dn.Name = "btn_dn";
            this.btn_dn.Size = new System.Drawing.Size(194, 75);
            this.btn_dn.TabIndex = 10;
            this.btn_dn.Text = "Đăng nhập";
            this.btn_dn.UseVisualStyleBackColor = true;
            this.btn_dn.Click += new System.EventHandler(this.btn_dn_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.textBox_pa);
            this.groupBox1.Controls.Add(this.textBox_dn);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(60, 113);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(6);
            this.groupBox1.Size = new System.Drawing.Size(616, 214);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin thí sinh";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // textBox_pa
            // 
            this.textBox_pa.Location = new System.Drawing.Point(272, 120);
            this.textBox_pa.Margin = new System.Windows.Forms.Padding(6);
            this.textBox_pa.Multiline = true;
            this.textBox_pa.Name = "textBox_pa";
            this.textBox_pa.PasswordChar = '*';
            this.textBox_pa.Size = new System.Drawing.Size(405, 54);
            this.textBox_pa.TabIndex = 3;
            // 
            // textBox_dn
            // 
            this.textBox_dn.Location = new System.Drawing.Point(272, 52);
            this.textBox_dn.Margin = new System.Windows.Forms.Padding(6);
            this.textBox_dn.Multiline = true;
            this.textBox_dn.Name = "textBox_dn";
            this.textBox_dn.Size = new System.Drawing.Size(405, 56);
            this.textBox_dn.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 117);
            this.label2.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 22);
            this.label2.TabIndex = 1;
            this.label2.Text = "Mật khẩu:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 55);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 22);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tên thí sinh:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // radioButton_quanli
            // 
            this.radioButton_quanli.AutoSize = true;
            this.radioButton_quanli.BackColor = System.Drawing.Color.Transparent;
            this.radioButton_quanli.Location = new System.Drawing.Point(493, 29);
            this.radioButton_quanli.Margin = new System.Windows.Forms.Padding(6);
            this.radioButton_quanli.Name = "radioButton_quanli";
            this.radioButton_quanli.Size = new System.Drawing.Size(228, 26);
            this.radioButton_quanli.TabIndex = 8;
            this.radioButton_quanli.TabStop = true;
            this.radioButton_quanli.Text = "Đăng nhập quyền quản lý";
            this.radioButton_quanli.UseVisualStyleBackColor = false;
            this.radioButton_quanli.CheckedChanged += new System.EventHandler(this.radioButton_quanli_CheckedChanged);
            // 
            // radioButton_thisinh
            // 
            this.radioButton_thisinh.AutoSize = true;
            this.radioButton_thisinh.BackColor = System.Drawing.Color.Transparent;
            this.radioButton_thisinh.Location = new System.Drawing.Point(56, 29);
            this.radioButton_thisinh.Margin = new System.Windows.Forms.Padding(6);
            this.radioButton_thisinh.Name = "radioButton_thisinh";
            this.radioButton_thisinh.Size = new System.Drawing.Size(235, 26);
            this.radioButton_thisinh.TabIndex = 7;
            this.radioButton_thisinh.TabStop = true;
            this.radioButton_thisinh.Text = "Đăng nhập thi trắc nghiệm";
            this.radioButton_thisinh.UseVisualStyleBackColor = false;
            this.radioButton_thisinh.CheckedChanged += new System.EventHandler(this.radioButton_thisinh_CheckedChanged);
            // 
            // frmDangNhap
            // 
            this.Appearance.Options.UseFont = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(752, 451);
            this.Controls.Add(this.btn_thoat);
            this.Controls.Add(this.btn_dn);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.radioButton_quanli);
            this.Controls.Add(this.radioButton_thisinh);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmDangNhap";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Đăng nhập";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmDangNhap_FormClosing);
            this.Load += new System.EventHandler(this.frmDangNhap_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_thoat;
        private System.Windows.Forms.Button btn_dn;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox textBox_pa;
        private System.Windows.Forms.TextBox textBox_dn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton radioButton_quanli;
        private System.Windows.Forms.RadioButton radioButton_thisinh;
    }
}