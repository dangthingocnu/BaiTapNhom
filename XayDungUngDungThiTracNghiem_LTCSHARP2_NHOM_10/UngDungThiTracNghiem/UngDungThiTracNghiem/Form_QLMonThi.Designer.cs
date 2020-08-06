namespace UngDungThiTracNghiem
{
    partial class Form_QLMonThi
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
            this.textBox_soch = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox_themma = new System.Windows.Forms.TextBox();
            this.textBox_themmon = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox_mamon = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBox_tenmon = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBox_soch
            // 
            this.textBox_soch.Location = new System.Drawing.Point(264, 78);
            this.textBox_soch.Name = "textBox_soch";
            this.textBox_soch.Size = new System.Drawing.Size(85, 26);
            this.textBox_soch.TabIndex = 23;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Location = new System.Drawing.Point(35, 81);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(226, 19);
            this.label6.TabIndex = 22;
            this.label6.Text = "Số câu hỏi  trong ngân hàng câu hỏi:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Location = new System.Drawing.Point(320, 222);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(164, 19);
            this.label5.TabIndex = 21;
            this.label5.Text = "Mã môn thi tối đa 4 ký tự";
            // 
            // textBox_themma
            // 
            this.textBox_themma.Location = new System.Drawing.Point(184, 219);
            this.textBox_themma.MaxLength = 4;
            this.textBox_themma.Name = "textBox_themma";
            this.textBox_themma.Size = new System.Drawing.Size(130, 26);
            this.textBox_themma.TabIndex = 20;
            // 
            // textBox_themmon
            // 
            this.textBox_themmon.Location = new System.Drawing.Point(184, 152);
            this.textBox_themmon.Name = "textBox_themmon";
            this.textBox_themmon.Size = new System.Drawing.Size(411, 26);
            this.textBox_themmon.TabIndex = 19;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Location = new System.Drawing.Point(36, 222);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(142, 19);
            this.label4.TabIndex = 18;
            this.label4.Text = "Nhập vào mã môn thi:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Location = new System.Drawing.Point(36, 155);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(142, 19);
            this.label3.TabIndex = 17;
            this.label3.Text = "Nhập vào tên môn thi:";
            // 
            // textBox_mamon
            // 
            this.textBox_mamon.Location = new System.Drawing.Point(467, 27);
            this.textBox_mamon.Name = "textBox_mamon";
            this.textBox_mamon.Size = new System.Drawing.Size(128, 26);
            this.textBox_mamon.TabIndex = 16;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(375, 30);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 19);
            this.label2.TabIndex = 15;
            this.label2.Text = "Mã môn thi:";
            // 
            // comboBox_tenmon
            // 
            this.comboBox_tenmon.FormattingEnabled = true;
            this.comboBox_tenmon.Location = new System.Drawing.Point(161, 29);
            this.comboBox_tenmon.Name = "comboBox_tenmon";
            this.comboBox_tenmon.Size = new System.Drawing.Size(188, 27);
            this.comboBox_tenmon.TabIndex = 14;
            this.comboBox_tenmon.SelectedIndexChanged += new System.EventHandler(this.comboBox_tenmon_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(36, 30);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 19);
            this.label1.TabIndex = 13;
            this.label1.Text = "Tên môn thi:";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(103, 295);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(126, 34);
            this.button1.TabIndex = 24;
            this.button1.Text = "Thêm môn";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(361, 295);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(112, 34);
            this.button2.TabIndex = 25;
            this.button2.Text = "Xóa môn";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Form_QLMonThi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.NavajoWhite;
            this.ClientSize = new System.Drawing.Size(631, 348);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox_soch);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textBox_themma);
            this.Controls.Add(this.textBox_themmon);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBox_mamon);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.comboBox_tenmon);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form_QLMonThi";
            this.Text = "Quản lí môn thi";
            this.Load += new System.EventHandler(this.Form_QLMonThi_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox_soch;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox_themma;
        private System.Windows.Forms.TextBox textBox_themmon;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox_mamon;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBox_tenmon;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;

    }
}