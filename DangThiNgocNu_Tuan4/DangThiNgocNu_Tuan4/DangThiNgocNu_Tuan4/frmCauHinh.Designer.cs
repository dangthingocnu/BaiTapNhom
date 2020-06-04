namespace DangThiNgocNu_Tuan4
{
    partial class frmCauHinh
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
            this.cboServer = new System.Windows.Forms.ComboBox();
            this.cboDatabase = new System.Windows.Forms.ComboBox();
            this.txtuser = new System.Windows.Forms.TextBox();
            this.txtpass = new System.Windows.Forms.TextBox();
            this.btnLuu = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cboServer
            // 
            this.cboServer.FormattingEnabled = true;
            this.cboServer.Location = new System.Drawing.Point(228, 11);
            this.cboServer.Margin = new System.Windows.Forms.Padding(6);
            this.cboServer.Name = "cboServer";
            this.cboServer.Size = new System.Drawing.Size(315, 41);
            this.cboServer.TabIndex = 0;
            this.cboServer.DropDown += new System.EventHandler(this.cboServer_DropDown);
            // 
            // cboDatabase
            // 
            this.cboDatabase.FormattingEnabled = true;
            this.cboDatabase.Location = new System.Drawing.Point(228, 137);
            this.cboDatabase.Margin = new System.Windows.Forms.Padding(6);
            this.cboDatabase.Name = "cboDatabase";
            this.cboDatabase.Size = new System.Drawing.Size(315, 41);
            this.cboDatabase.TabIndex = 1;
            this.cboDatabase.DropDown += new System.EventHandler(this.cboDatabase_DropDown);
            // 
            // txtuser
            // 
            this.txtuser.Location = new System.Drawing.Point(228, 55);
            this.txtuser.Margin = new System.Windows.Forms.Padding(6);
            this.txtuser.Name = "txtuser";
            this.txtuser.Size = new System.Drawing.Size(315, 40);
            this.txtuser.TabIndex = 2;
            // 
            // txtpass
            // 
            this.txtpass.Location = new System.Drawing.Point(228, 96);
            this.txtpass.Margin = new System.Windows.Forms.Padding(6);
            this.txtpass.Name = "txtpass";
            this.txtpass.Size = new System.Drawing.Size(315, 40);
            this.txtpass.TabIndex = 3;
            // 
            // btnLuu
            // 
            this.btnLuu.Location = new System.Drawing.Point(114, 180);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(92, 43);
            this.btnLuu.TabIndex = 4;
            this.btnLuu.Text = "Lưu Lại";
            this.btnLuu.UseVisualStyleBackColor = true;
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(262, 180);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(188, 43);
            this.button2.TabIndex = 5;
            this.button2.Text = "Hủy Bỏ";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(169, 33);
            this.label1.TabIndex = 6;
            this.label1.Text = "SeverName";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(155, 33);
            this.label2.TabIndex = 7;
            this.label2.Text = "UserName";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 103);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(143, 33);
            this.label3.TabIndex = 8;
            this.label3.Text = "Password";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 141);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(139, 33);
            this.label4.TabIndex = 9;
            this.label4.Text = "Database";
            // 
            // frmCauHinh
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(17F, 33F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(643, 334);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btnLuu);
            this.Controls.Add(this.txtpass);
            this.Controls.Add(this.txtuser);
            this.Controls.Add(this.cboDatabase);
            this.Controls.Add(this.cboServer);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "frmCauHinh";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cboServer;
        private System.Windows.Forms.ComboBox cboDatabase;
        private System.Windows.Forms.TextBox txtuser;
        private System.Windows.Forms.TextBox txtpass;
        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}