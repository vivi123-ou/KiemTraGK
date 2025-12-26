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