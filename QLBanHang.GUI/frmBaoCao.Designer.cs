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

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.grpHoaDonTheoNgay = new System.Windows.Forms.GroupBox();
            this.btnHoaDonTheoNgay = new System.Windows.Forms.Button();
            this.dtpDenNgay = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.dtpTuNgay = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.grpTopSanPham = new System.Windows.Forms.GroupBox();
            this.btnTop3SanPham = new System.Windows.Forms.Button();
            this.grpDoanhThu = new System.Windows.Forms.GroupBox();
            this.btnDoanhThuTheoThang = new System.Windows.Forms.Button();
            this.nudNam = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.lblKetQua = new System.Windows.Forms.Label();
            this.dgvKetQua = new System.Windows.Forms.DataGridView();
            this.label4 = new System.Windows.Forms.Label();
            this.grpHoaDonTheoNgay.SuspendLayout();
            this.grpTopSanPham.SuspendLayout();
            this.grpDoanhThu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudNam)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKetQua)).BeginInit();
            this.SuspendLayout();
            // 
            // grpHoaDonTheoNgay
            // 
            this.grpHoaDonTheoNgay.Controls.Add(this.btnHoaDonTheoNgay);
            this.grpHoaDonTheoNgay.Controls.Add(this.dtpDenNgay);
            this.grpHoaDonTheoNgay.Controls.Add(this.label2);
            this.grpHoaDonTheoNgay.Controls.Add(this.dtpTuNgay);
            this.grpHoaDonTheoNgay.Controls.Add(this.label1);
            this.grpHoaDonTheoNgay.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpHoaDonTheoNgay.Location = new System.Drawing.Point(12, 90);
            this.grpHoaDonTheoNgay.Name = "grpHoaDonTheoNgay";
            this.grpHoaDonTheoNgay.Size = new System.Drawing.Size(460, 120);
            this.grpHoaDonTheoNgay.TabIndex = 0;
            this.grpHoaDonTheoNgay.TabStop = false;
            this.grpHoaDonTheoNgay.Text = "1. Hóa đơn theo khoảng ngày";
            // 
            // btnHoaDonTheoNgay
            // 
            this.btnHoaDonTheoNgay.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnHoaDonTheoNgay.Location = new System.Drawing.Point(280, 40);
            this.btnHoaDonTheoNgay.Name = "btnHoaDonTheoNgay";
            this.btnHoaDonTheoNgay.Size = new System.Drawing.Size(150, 40);
            this.btnHoaDonTheoNgay.TabIndex = 5;
            this.btnHoaDonTheoNgay.Text = "Xem";
            this.btnHoaDonTheoNgay.UseVisualStyleBackColor = false;
            // 
            // dtpDenNgay
            // 
            this.dtpDenNgay.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDenNgay.Location = new System.Drawing.Point(100, 62);
            this.dtpDenNgay.Name = "dtpDenNgay";
            this.dtpDenNgay.Size = new System.Drawing.Size(150, 27);
            this.dtpDenNgay.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Đến ngày";
            // 
            // dtpTuNgay
            // 
            this.dtpTuNgay.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpTuNgay.Location = new System.Drawing.Point(100, 27);
            this.dtpTuNgay.Name = "dtpTuNgay";
            this.dtpTuNgay.Size = new System.Drawing.Size(150, 27);
            this.dtpTuNgay.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Từ ngày";
            // 
            // grpTopSanPham
            // 
            this.grpTopSanPham.Controls.Add(this.btnTop3SanPham);
            this.grpTopSanPham.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpTopSanPham.Location = new System.Drawing.Point(490, 90);
            this.grpTopSanPham.Name = "grpTopSanPham";
            this.grpTopSanPham.Size = new System.Drawing.Size(490, 120);
            this.grpTopSanPham.TabIndex = 1;
            this.grpTopSanPham.TabStop = false;
            this.grpTopSanPham.Text = "2. Top sản phẩm bán chạy";
            // 
            // btnTop3SanPham
            // 
            this.btnTop3SanPham.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnTop3SanPham.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTop3SanPham.Location = new System.Drawing.Point(30, 45);
            this.btnTop3SanPham.Name = "btnTop3SanPham";
            this.btnTop3SanPham.Size = new System.Drawing.Size(430, 50);
            this.btnTop3SanPham.TabIndex = 6;
            this.btnTop3SanPham.Text = "Xem Top 3 sản phẩm bán chạy nhất";
            this.btnTop3SanPham.UseVisualStyleBackColor = false;
            // 
            // grpDoanhThu
            // 
            this.grpDoanhThu.Controls.Add(this.btnDoanhThuTheoThang);
            this.grpDoanhThu.Controls.Add(this.nudNam);
            this.grpDoanhThu.Controls.Add(this.label3);
            this.grpDoanhThu.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpDoanhThu.Location = new System.Drawing.Point(12, 228);
            this.grpDoanhThu.Name = "grpDoanhThu";
            this.grpDoanhThu.Size = new System.Drawing.Size(460, 120);
            this.grpDoanhThu.TabIndex = 7;
            this.grpDoanhThu.TabStop = false;
            this.grpDoanhThu.Text = "3. Doanh thu theo tháng";
            // 
            // btnDoanhThuTheoThang
            // 
            this.btnDoanhThuTheoThang.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnDoanhThuTheoThang.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDoanhThuTheoThang.Location = new System.Drawing.Point(200, 40);
            this.btnDoanhThuTheoThang.Name = "btnDoanhThuTheoThang";
            this.btnDoanhThuTheoThang.Size = new System.Drawing.Size(230, 50);
            this.btnDoanhThuTheoThang.TabIndex = 7;
            this.btnDoanhThuTheoThang.Text = "Xem doanh thu";
            this.btnDoanhThuTheoThang.UseVisualStyleBackColor = false;
            // 
            // nudNam
            // 
            this.nudNam.Location = new System.Drawing.Point(70, 47);
            this.nudNam.Maximum = new decimal(new int[] {
            2100,
            0,
            0,
            0});
            this.nudNam.Minimum = new decimal(new int[] {
            2000,
            0,
            0,
            0});
            this.nudNam.Name = "nudNam";
            this.nudNam.Size = new System.Drawing.Size(100, 27);
            this.nudNam.TabIndex = 7;
            this.nudNam.Value = new decimal(new int[] {
            2024,
            0,
            0,
            0});
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(20, 50);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 20);
            this.label3.TabIndex = 6;
            this.label3.Text = "Năm";
            // 
            // lblKetQua
            // 
            this.lblKetQua.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblKetQua.ForeColor = System.Drawing.Color.Blue;
            this.lblKetQua.Location = new System.Drawing.Point(12, 363);
            this.lblKetQua.Name = "lblKetQua";
            this.lblKetQua.Size = new System.Drawing.Size(968, 30);
            this.lblKetQua.TabIndex = 8;
            // 
            // dgvKetQua
            // 
            this.dgvKetQua.AllowUserToAddRows = false;
            this.dgvKetQua.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvKetQua.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvKetQua.Location = new System.Drawing.Point(12, 408);
            this.dgvKetQua.MultiSelect = false;
            this.dgvKetQua.Name = "dgvKetQua";
            this.dgvKetQua.ReadOnly = true;
            this.dgvKetQua.RowHeadersWidth = 51;
            this.dgvKetQua.RowTemplate.Height = 24;
            this.dgvKetQua.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvKetQua.Size = new System.Drawing.Size(968, 240);
            this.dgvKetQua.TabIndex = 9;
            this.dgvKetQua.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvKetQua_CellContentClick);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Blue;
            this.label4.Location = new System.Drawing.Point(323, 23);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(345, 39);
            this.label4.TabIndex = 10;
            this.label4.Text = "Báo cáo và thống kê";
            // 
            // frmBaoCao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(993, 667);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dgvKetQua);
            this.Controls.Add(this.lblKetQua);
            this.Controls.Add(this.grpDoanhThu);
            this.Controls.Add(this.grpTopSanPham);
            this.Controls.Add(this.grpHoaDonTheoNgay);
            this.Name = "frmBaoCao";
            this.Text = "Báo cáo và thống kê";
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