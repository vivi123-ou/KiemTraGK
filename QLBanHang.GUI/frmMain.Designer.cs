namespace QLBanHang.GUI
{
    partial class frmMain
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
            this.btnSanPham = new System.Windows.Forms.Button();
            this.btnHoaDon = new System.Windows.Forms.Button();
            this.btnBaoCao = new System.Windows.Forms.Button();
            this.btnThoat_Click = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();

            // label1
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(150, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(400, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "HỆ THỐNG QUẢN LÝ BÁN HÀNG";

            // btnSanPham
            this.btnSanPham.BackColor = System.Drawing.Color.FromArgb(192, 255, 192);
            this.btnSanPham.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold);
            this.btnSanPham.Location = new System.Drawing.Point(250, 100);
            this.btnSanPham.Name = "btnSanPham";
            this.btnSanPham.Size = new System.Drawing.Size(200, 60);
            this.btnSanPham.TabIndex = 1;
            this.btnSanPham.Text = "Quản lý\r\nSản phẩm";
            this.btnSanPham.UseVisualStyleBackColor = false;

            // btnHoaDon
            this.btnHoaDon.BackColor = System.Drawing.Color.FromArgb(255, 255, 192);
            this.btnHoaDon.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold);
            this.btnHoaDon.Location = new System.Drawing.Point(250, 180);
            this.btnHoaDon.Name = "btnHoaDon";
            this.btnHoaDon.Size = new System.Drawing.Size(200, 60);
            this.btnHoaDon.TabIndex = 2;
            this.btnHoaDon.Text = "Lập hóa đơn\r\nbán hàng";
            this.btnHoaDon.UseVisualStyleBackColor = false;

            // btnBaoCao
            this.btnBaoCao.BackColor = System.Drawing.Color.FromArgb(192, 255, 255);
            this.btnBaoCao.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold);
            this.btnBaoCao.Location = new System.Drawing.Point(250, 260);
            this.btnBaoCao.Name = "btnBaoCao";
            this.btnBaoCao.Size = new System.Drawing.Size(200, 60);
            this.btnBaoCao.TabIndex = 3;
            this.btnBaoCao.Text = "Báo cáo\r\nthống kê";
            this.btnBaoCao.UseVisualStyleBackColor = false;

            // btnThoat_Click
            this.btnThoat_Click.BackColor = System.Drawing.Color.FromArgb(255, 192, 192);
            this.btnThoat_Click.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold);
            this.btnThoat_Click.Location = new System.Drawing.Point(250, 340);
            this.btnThoat_Click.Name = "btnThoat_Click";
            this.btnThoat_Click.Size = new System.Drawing.Size(200, 60);
            this.btnThoat_Click.TabIndex = 4;
            this.btnThoat_Click.Text = "Thoát";
            this.btnThoat_Click.UseVisualStyleBackColor = false;

            // frmMain
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(700, 450);
            this.Controls.Add(this.btnThoat_Click);
            this.Controls.Add(this.btnBaoCao);
            this.Controls.Add(this.btnHoaDon);
            this.Controls.Add(this.btnSanPham);
            this.Controls.Add(this.label1);
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản lý bán hàng";
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Button btnSanPham;
        private System.Windows.Forms.Button btnHoaDon;
        private System.Windows.Forms.Button btnBaoCao;
        private System.Windows.Forms.Button btnThoat_Click;
        private System.Windows.Forms.Label label1;
    }
}