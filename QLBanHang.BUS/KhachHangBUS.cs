using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QLBanHang.DTO;
using QLBanHang.DAL;

namespace QLBanHang.BUS
{ 
    /// Lớp BUS xử lý nghiệp vụ cho Khách hàng 
    public class KhachHangBUS
    {
        private KhachHangDAL dalKhachHang = new KhachHangDAL();

 
        /// Lấy danh sách tất cả khách hàng 
        public List<KhachHangDTO> GetAllKhachHang()
        {
            return dalKhachHang.GetAllKhachHang();
        }
 
        public bool ThemKhachHang(KhachHangDTO kh)
        {
            // Kiểm tra dữ liệu đầu vào
            if (string.IsNullOrWhiteSpace(kh.TenKH))
            {
                throw new Exception("Tên khách hàng không được để trống!");
            }

            if (string.IsNullOrWhiteSpace(kh.DienThoai))
            {
                throw new Exception("Số điện thoại không được để trống!");
            }

            // Kiểm tra định dạng số điện thoại
            if (kh.DienThoai.Length < 10 || kh.DienThoai.Length > 11)
            {
                throw new Exception("Số điện thoại phải có 10-11 số!");
            }

            // Gọi DAL để thêm
            return dalKhachHang.ThemKhachHang(kh);
        }
         
        /// Sửa thông tin khách hàng 
        public bool SuaKhachHang(KhachHangDTO kh)
        {
            // Kiểm tra dữ liệu
            if (kh.MaKH <= 0)
            {
                throw new Exception("Mã khách hàng không hợp lệ!");
            }

            if (string.IsNullOrWhiteSpace(kh.TenKH))
            {
                throw new Exception("Tên khách hàng không được để trống!");
            }

            // Gọi DAL để sửa
            return dalKhachHang.SuaKhachHang(kh);
        }
         
        /// Xóa khách hàng 
        public bool XoaKhachHang(int maKH)
        {
            if (maKH <= 0)
            {
                throw new Exception("Mã khách hàng không hợp lệ!");
            }

            return dalKhachHang.XoaKhachHang(maKH);
        }
    }
}