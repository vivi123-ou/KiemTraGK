using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace QLBanHang.DTO
{
    /// Lớp DTO đại diện cho Sản phẩm, chỉ chứa dữ liệu, không có logic nghiệp vụ 
    public class SanPhamDTO
    {
        // Mã sản phẩm (Primary Key)
        public int MaSP { get; set; }

        // Tên sản phẩm
        public string TenSP { get; set; }

        // Đơn giá sản phẩm
        public decimal DonGia { get; set; }

        // Số lượng tồn kho
        public int SoLuong { get; set; }

        // Trạng thái sản phẩm (true: còn bán, false: ngừng bán)
        public bool TrangThai { get; set; }

        // Constructor mặc định
        public SanPhamDTO()
        {
            TrangThai = true; // Mặc định sản phẩm đang hoạt động
        }

        // Constructor đầy đủ tham số
        public SanPhamDTO(int maSP, string tenSP, decimal donGia, int soLuong, bool trangThai)
        {
            MaSP = maSP;
            TenSP = tenSP;
            DonGia = donGia;
            SoLuong = soLuong;
            TrangThai = trangThai;
        }
    }
}
}
