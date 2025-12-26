namespace QLBanHang.GUI
{
    partial class frmBaoCao
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

        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor. 
        private void InitializeComponent()
        {
            this.grpHoaDonTheoNgay = new System.Windows.Forms.GroupBox();
            this.dtpDenNgay = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.btnHoaDonTheoNgay = new System.Windows.Forms.Button();
            this.dtpTuNgay = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.grpTopSanPham = new System.Windows.Forms.GroupBox();
            this.btnTop3SanPham = new System.Windows.Forms.Button();
            this.grpDoanhThu = new System.Windows.Forms.GroupBox();
            this.btnDoanhThuTheoThang = new System.Windows.Forms.Button();
            this.nudNam = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.dgvKetQua = new System.Windows.Forms.DataGridView();
            this.lblKetQua = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();

            this.grpHoaDonTheoNgay.SuspendLayout();
            this.grpTopSanPham.SuspendLayout();
            this.grpDoanhThu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudNam)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKetQua)).BeginInit();
            this.SuspendLayout();

            // grpHoaDonTheoNgay
            this.grpHoaDonTheoNgay.Controls.Add(this.dtpDenNgay);
            this.grpHoaDonTheoNgay.Controls.Add(this.label2);
            this.grpHoaDonTheoNgay.Controls.Add(this.btnHoaDonTheoNgay);
            this.grpHoaDonTheoNgay.Controls.Add(this.dtpTuNgay);
            this.grpHoaDonTheoNgay.Controls.Add(this.label1);
            this.grpHoaDonTheoNgay.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.grpHoaDonTheoNgay.Location = new System.Drawing.Point(12, 60);
            this.grpHoaDonTheoNgay.Name = "grpHoaDonTheoNgay";
            this.grpHoaDonTheoNgay.Size = new System.Drawing.Size(350, 150);
            this.grpHoaDonTheoNgay.TabIndex = 0;
            this.grpHoaDonTheoNgay.TabStop = false;
            this.grpHoaDonTheoNgay.Text = "Hóa đơn theo ngày";

            // dtpTuNgay
            this.dtpTuNgay.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpTuNgay.Location = new System.Drawing.Point(100, 30);
            this.dtpTuNgay.Name = "dtpTuNgay";
            this.dtpTuNgay.Size = new System.Drawing.Size(200, 23);
            this.dtpTuNgay.TabIndex = 0;

            // label1
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Từ ngày";

            // dtpDenNgay
            this.dtpDenNgay.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDenNgay.Location = new System.Drawing.Point(100, 65);
            this.dtpDenNgay.Name = "dtpDenNgay";
            this.dtpDenNgay.Size = new System.Drawing.Size(200, 23);
            this.dtpDenNgay.TabIndex = 2;

            // label2
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Đến ngày";

            // btnHoaDonTheoNgay
            this.btnHoaDonTheoNgay.BackColor = System.Drawing.Color.FromArgb(192, 255, 192);
            this.btnHoaDonTheoNgay.Location = new System.Drawing.Point(100, 100);
            this.btnHoaDonTheoNgay.Name = "btnHoaDonTheoNgay";
            this.btnHoaDonTheoNgay.Size = new System.Drawing.Size(200, 35);
            this.btnHoaDonTheoNgay.TabIndex = 4;
            this.btnHoaDonTheoNgay.Text = "Xem hóa đơn";
            this.btnHoaDonTheoNgay.UseVisualStyleBackColor = false;
            this.btnHoaDonTheoNgay.Click += new System.EventHandler(this.btnHoaDonTheoNgay_Click);

            // grpTopSanPham
            this.grpTopSanPham.Controls.Add(this.btnTop3SanPham);
            this.grpTopSanPham.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.grpTopSanPham.Location = new System.Drawing.Point(380, 60);
            this.grpTopSanPham.Name = "grpTopSanPham";
            this.grpTopSanPham.Size = new System.Drawing.Size(300, 150);
            this.grpTopSanPham.TabIndex = 1;
            this.grpTopSanPham.TabStop = false;
            this.grpTopSanPham.Text = "Sản phẩm bán chạy";

            // btnTop3SanPham
            this.btnTop3SanPham.BackColor = System.Drawing.Color.FromArgb(255, 255, 192);
            this.btnTop3SanPham.Location = new System.Drawing.Point(50, 60);
            this.btnTop3SanPham.Name = "btnTop3SanPham";
            this.btnTop3SanPham.Size = new System.Drawing.Size(200, 50);
            this.btnTop3SanPham.TabIndex = 0;
            this.btnTop3SanPham.Text = "Top 3 sản phẩm\r\nbán chạy";
            this.btnTop3SanPham.UseVisualStyleBackColor = false;
            this.btnTop3SanPham.Click += new System.EventHandler(this.btnTop3SanPham_Click);

            // grpDoanhThu
            this.grpDoanhThu.Controls.Add(this.btnDoanhThuTheoThang);
            this.grpDoanhThu.Controls.Add(this.nudNam);
            this.grpDoanhThu.Controls.Add(this.label3);
            this.grpDoanhThu.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.grpDoanhThu.Location = new System.Drawing.Point(700, 60);
            this.grpDoanhThu.Name = "grpDoanhThu";
            this.grpDoanhThu.Size = new System.Drawing.Size(300, 150);
            this.grpDoanhThu.TabIndex = 2;
            this.grpDoanhThu.TabStop = false;
            this.grpDoanhThu.Text = "Doanh thu";

            // label3
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(20, 40);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 17);
            this.label3.TabIndex = 0;
            this.label3.Text = "Năm";

            // nudNam
            this.nudNam.Location = new System.Drawing.Point(80, 38);
            this.nudNam.Maximum = new decimal(new int[] { 2100, 0, 0, 0 });
            this.nudNam.Minimum = new decimal(new int[] { 2000, 0, 0, 0 });
            this.nudNam.Name = "nudNam";
            this.nudNam.Size = new System.Drawing.Size(120, 23);
            this.nudNam.TabIndex = 1;
            this.nudNam.Value = new decimal(new int[] { 2024, 0, 0, 0 });

            // btnDoanhThuTheoThang
            this.btnDoanhThuTheoThang.BackColor = System.Drawing.Color.FromArgb(192, 255, 255);
            this.btnDoanhThuTheoThang.Location = new System.Drawing.Point(50, 80);
            this.btnDoanhThuTheoThang.Name = "btnDoanhThuTheoThang";
            this.btnDoanhThuTheoThang.Size = new System.Drawing.Size(200, 50);
            this.btnDoanhThuTheoThang.TabIndex = 2;
            this.btnDoanhThuTheoThang.Text = "Xem doanh thu\r\ntheo tháng";
            this.btnDoanhThuTheoThang.UseVisualStyleBackColor = false;
            this.btnDoanhThuTheoThang.Click += new System.EventHandler(this.btnDoanhThuTheoThang_Click);

            // label4
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold);
            this.label4.ForeColor = System.Drawing.Color.Red;
            this.label4.Location = new System.Drawing.Point(400, 15);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(200, 29);
            this.label4.TabIndex = 3;
            this.label4.Text = "BÁO CÁO THỐNG KÊ";

            // lblKetQua
            this.lblKetQua.AutoSize = true;
            this.lblKetQua.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Italic);
            this.lblKetQua.ForeColor = System.Drawing.Color.Blue;
            this.lblKetQua.Location = new System.Drawing.Point(12, 220);
            this.lblKetQua.Name = "lblKetQua";
            this.lblKetQua.Size = new System.Drawing.Size(0, 17);
            this.lblKetQua.TabIndex = 4;

            // dgvKetQua
            this.dgvKetQua.AllowUserToAddRows = false;
            this.dgvKetQua.AllowUserToDeleteRows = false;
            this.dgvKetQua.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvKetQua.Location = new System.Drawing.Point(12, 250);
            this.dgvKetQua.MultiSelect = false;
            this.dgvKetQua.Name = "dgvKetQua";
            this.dgvKetQua.ReadOnly = true;
            this.dgvKetQua.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvKetQua.Size = new System.Drawing.Size(988, 350);
            this.dgvKetQua.TabIndex = 5;

            // frmBaoCao
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1012, 612);
            this.Controls.Add(this.dgvKetQua);
            this.Controls.Add(this.lblKetQua);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.grpDoanhThu);
            this.Controls.Add(this.grpTopSanPham);
            this.Controls.Add(this.grpHoaDonTheoNgay);
            this.Name = "frmBaoCao";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Báo cáo thống kê";
            this.Load += new System.EventHandler(this.frmBaoCao_Load);

            this.grpHoaDonTheoNgay.ResumeLayout(false);
            this.grpHoaDonTheoNgay.PerformLayout();
            this.grpTopSanPham.ResumeLayout(false);
            this.grpDoanhThu.ResumeLayout(false);
            this.grpDoanhThu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudNam)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKetQua)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.GroupBox grpHoaDonTheoNgay;
        private System.Windows.Forms.DateTimePicker dtpTuNgay;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnHoaDonTheoNgay;
        private System.Windows.Forms.DateTimePicker dtpDenNgay;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox grpTopSanPham;
        private System.Windows.Forms.Button btnTop3SanPham;
        private System.Windows.Forms.GroupBox grpDoanhThu;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown nudNam;
        private System.Windows.Forms.Button btnDoanhThuTheoThang;
        private System.Windows.Forms.Label lblKetQua;
        private System.Windows.Forms.DataGridView dgvKetQua;
        private System.Windows.Forms.Label label4;
    }
}