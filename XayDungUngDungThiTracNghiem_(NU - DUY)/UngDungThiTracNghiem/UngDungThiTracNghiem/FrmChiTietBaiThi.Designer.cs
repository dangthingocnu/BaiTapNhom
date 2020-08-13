namespace UngDungThiTracNghiem
{
    partial class FrmChiTietBaiThi
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmChiTietBaiThi));
            this.panelBaiThi = new System.Windows.Forms.Panel();
            this.lbHoTen = new System.Windows.Forms.Label();
            this.lbMonThi = new System.Windows.Forms.Label();
            this.lbDiem = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // panelBaiThi
            // 
            this.panelBaiThi.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.panelBaiThi.AutoScroll = true;
            this.panelBaiThi.BackColor = System.Drawing.Color.White;
            this.panelBaiThi.Location = new System.Drawing.Point(22, 47);
            this.panelBaiThi.Name = "panelBaiThi";
            this.panelBaiThi.Size = new System.Drawing.Size(843, 403);
            this.panelBaiThi.TabIndex = 0;
            // 
            // lbHoTen
            // 
            this.lbHoTen.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lbHoTen.AutoSize = true;
            this.lbHoTen.BackColor = System.Drawing.Color.Transparent;
            this.lbHoTen.Location = new System.Drawing.Point(203, 13);
            this.lbHoTen.Name = "lbHoTen";
            this.lbHoTen.Size = new System.Drawing.Size(108, 13);
            this.lbHoTen.TabIndex = 1;
            this.lbHoTen.Text = "Họ tên: Trần Văn Hải";
            // 
            // lbMonThi
            // 
            this.lbMonThi.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lbMonThi.AutoSize = true;
            this.lbMonThi.BackColor = System.Drawing.Color.Transparent;
            this.lbMonThi.Location = new System.Drawing.Point(390, 13);
            this.lbMonThi.Name = "lbMonThi";
            this.lbMonThi.Size = new System.Drawing.Size(98, 13);
            this.lbMonThi.TabIndex = 2;
            this.lbMonThi.Text = "Môn Thi: Toán học";
            // 
            // lbDiem
            // 
            this.lbDiem.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lbDiem.AutoSize = true;
            this.lbDiem.BackColor = System.Drawing.Color.Transparent;
            this.lbDiem.Location = new System.Drawing.Point(619, 13);
            this.lbDiem.Name = "lbDiem";
            this.lbDiem.Size = new System.Drawing.Size(66, 13);
            this.lbDiem.TabIndex = 3;
            this.lbDiem.Text = "Điểm thi: 8.5";
            // 
            // FrmChiTietBaiThi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(888, 472);
            this.Controls.Add(this.lbDiem);
            this.Controls.Add(this.lbMonThi);
            this.Controls.Add(this.lbHoTen);
            this.Controls.Add(this.panelBaiThi);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmChiTietBaiThi";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmChiTietBaiThi";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelBaiThi;
        private System.Windows.Forms.Label lbHoTen;
        private System.Windows.Forms.Label lbMonThi;
        private System.Windows.Forms.Label lbDiem;
    }
}