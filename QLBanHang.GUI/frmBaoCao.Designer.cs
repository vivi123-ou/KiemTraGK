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
            this.dtpTuNgay = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.btnHoaDonTheoNgay = new System.Windows.Forms.Button();
            this.dtpDenNgay = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.grpTopSanPham = new System.Windows.Forms.GroupBox();
            this.btnTop3SanPham = new System.Windows.Forms.Button();
            this.grpDoanhThu = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.nudNam = new System.Windows.Forms.NumericUpDown();
            this.btnDoanhThuTheoThang = new System.Windows.Forms.Button();
            this.lblKetQua = new System.Windows.Forms.Label();
            this.dgvKetQua = new System.Windows.Forms.DataGridView();
            this.label4 = new System.Windows.Forms.Label();
            this.grpHoaDonTheoNgay.SuspendLayout();
            this.grpTopSanPham.SuspendLayout();
            this.grpDoanhThu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudNam)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKetQua)).BeginInit();
            // (Thêm code thiết kế các controls ở đây - tham khảo frmSanPham.Designer.cs để biết cách thiết lập)
            this.SuspendLayout();
            // 
            // frmBaoCao
            // 
            this.ClientSize = new System.Drawing.Size(282, 253);
            this.Name = "frmBaoCao";
            this.Load += new System.EventHandler(this.frmBaoCao_Load_1);
            this.ResumeLayout(false);

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