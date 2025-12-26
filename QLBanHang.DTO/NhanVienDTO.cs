using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks; 

namespace QLBanHang.DTO
{ 
    /// Lớp DTO đại diện cho Nhân viên 
    public class NhanVienDTO
    {
        // Mã nhân viên (Primary Key)
        public int MaNV { get; set; }

        // Tên nhân viên
        public string TenNV { get; set; }

        // Chức vụ
        public string ChucVu { get; set; }

        // Số điện thoại
        public string DienThoai { get; set; }

        // Constructor mặc định
        public NhanVienDTO() { }

        // Constructor đầy đủ tham số
        public NhanVienDTO(int maNV, string tenNV, string chucVu, string dienThoai)
        {
            MaNV = maNV;
            TenNV = tenNV;
            ChucVu = chucVu;
            DienThoai = dienThoai;
        }
    }
}