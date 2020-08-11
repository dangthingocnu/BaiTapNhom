namespace UngDungThiTracNghiem
{
    partial class Form_QLGV
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
            this.label6 = new System.Windows.Forms.Label();
            this.comboBox_cv = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox_dc = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox_ma = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnThemGV = new System.Windows.Forms.Button();
            this.btnLuu = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.textBox_ten = new System.Windows.Forms.TextBox();
            this.textBox_ns = new System.Windows.Forms.MaskedTextBox();
            this.textBox_dt = new ThietKeControl.textBox_dt();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Location = new System.Drawing.Point(33, 620);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(64, 19);
            this.label6.TabIndex = 26;
            this.label6.Text = "Chức vụ:";
            // 
            // comboBox_cv
            // 
            this.comboBox_cv.FormattingEnabled = true;
            this.comboBox_cv.Location = new System.Drawing.Point(208, 617);
            this.comboBox_cv.Margin = new System.Windows.Forms.Padding(4);
            this.comboBox_cv.Name = "comboBox_cv";
            this.comboBox_cv.Size = new System.Drawing.Size(496, 27);
            this.comboBox_cv.TabIndex = 25;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Location = new System.Drawing.Point(31, 575);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(72, 19);
            this.label5.TabIndex = 23;
            this.label5.Text = "Ngày sinh:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Location = new System.Drawing.Point(31, 526);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 19);
            this.label4.TabIndex = 21;
            this.label4.Text = "Địện thoại:";
            // 
            // textBox_dc
            // 
            this.textBox_dc.Location = new System.Drawing.Point(208, 476);
            this.textBox_dc.Margin = new System.Windows.Forms.Padding(4);
            this.textBox_dc.Name = "textBox_dc";
            this.textBox_dc.Size = new System.Drawing.Size(591, 26);
            this.textBox_dc.TabIndex = 20;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Location = new System.Drawing.Point(31, 480);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 19);
            this.label3.TabIndex = 19;
            this.label3.Text = "Địa chỉ:";
            // 
            // textBox_ma
            // 
            this.textBox_ma.Location = new System.Drawing.Point(208, 430);
            this.textBox_ma.Margin = new System.Windows.Forms.Padding(4);
            this.textBox_ma.MaxLength = 4;
            this.textBox_ma.Name = "textBox_ma";
            this.textBox_ma.Size = new System.Drawing.Size(591, 26);
            this.textBox_ma.TabIndex = 18;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(31, 433);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 19);
            this.label2.TabIndex = 17;
            this.label2.Text = "Mã Giáo Viên:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(31, 385);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 19);
            this.label1.TabIndex = 15;
            this.label1.Text = "Tên Giáo Viên:";
            // 
            // btnThemGV
            // 
            this.btnThemGV.Location = new System.Drawing.Point(839, 571);
            this.btnThemGV.Name = "btnThemGV";
            this.btnThemGV.Size = new System.Drawing.Size(100, 44);
            this.btnThemGV.TabIndex = 28;
            this.btnThemGV.Text = "Thêm";
            this.btnThemGV.UseVisualStyleBackColor = true;
            this.btnThemGV.Click += new System.EventHandler(this.btnThemGV_Click);
            // 
            // btnLuu
            // 
            this.btnLuu.Location = new System.Drawing.Point(839, 620);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(100, 42);
            this.btnLuu.TabIndex = 29;
            this.btnLuu.Text = "Lưu";
            this.btnLuu.UseVisualStyleBackColor = true;
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(20, 13);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(1134, 304);
            this.dataGridView1.TabIndex = 30;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // textBox_ten
            // 
            this.textBox_ten.Location = new System.Drawing.Point(208, 384);
            this.textBox_ten.Name = "textBox_ten";
            this.textBox_ten.Size = new System.Drawing.Size(591, 26);
            this.textBox_ten.TabIndex = 31;
            // 
            // textBox_ns
            // 
            this.textBox_ns.Location = new System.Drawing.Point(208, 569);
            this.textBox_ns.Mask = "00/00/0000";
            this.textBox_ns.Name = "textBox_ns";
            this.textBox_ns.Size = new System.Drawing.Size(496, 26);
            this.textBox_ns.TabIndex = 32;
            this.textBox_ns.ValidatingType = typeof(System.DateTime);
            // 
            // textBox_dt
            // 
            this.textBox_dt.Location = new System.Drawing.Point(208, 527);
            this.textBox_dt.Name = "textBox_dt";
            this.textBox_dt.Size = new System.Drawing.Size(591, 26);
            this.textBox_dt.TabIndex = 33;
            // 
            // Form_QLGV
            // 
            this.Appearance.Options.UseFont = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1138, 670);
            this.Controls.Add(this.textBox_dt);
            this.Controls.Add(this.textBox_ns);
            this.Controls.Add(this.textBox_ten);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnLuu);
            this.Controls.Add(this.btnThemGV);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.comboBox_cv);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBox_dc);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBox_ma);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form_QLGV";
            this.Text = "Quản lý giáo viên";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox comboBox_cv;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox_dc;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox_ma;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnThemGV;
        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox textBox_ten;
        private System.Windows.Forms.MaskedTextBox textBox_ns;
        private ThietKeControl.textBox_dt textBox_dt;
    }
}