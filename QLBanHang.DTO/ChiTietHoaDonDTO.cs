using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
 

namespace QLBanHang.DTO
{ 
    /// Lớp DTO đại diện cho Chi tiết hóa đơn 
    public class ChiTietHoaDonDTO
    {
        // Mã hóa đơn (Foreign Key, Composite Primary Key)
        public int MaHD { get; set; }

        // Mã sản phẩm (Foreign Key, Composite Primary Key)
        public int MaSP { get; set; }

        // Số lượng mua
        public int SoLuong { get; set; }

        // Đơn giá tại thời điểm bán
        public decimal DonGia { get; set; }

        // Tên sản phẩm (không lưu trong DB, dùng để hiển thị)
        public string TenSP { get; set; }

        // Thành tiền (không lưu trong DB, tính toán)
        public decimal ThanhTien
        {
            get { return SoLuong * DonGia; }
        }

        // Constructor mặc định
        public ChiTietHoaDonDTO() { }

        // Constructor đầy đủ tham số
        public ChiTietHoaDonDTO(int maHD, int maSP, int soLuong, decimal donGia)
        {
            MaHD = maHD;
            MaSP = maSP;
            SoLuong = soLuong;
            DonGia = donGia;
        }
    }
}
