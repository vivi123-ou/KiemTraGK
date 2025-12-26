using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QLBanHang.DTO;
using QLBanHang.DAL;

namespace QLBanHang.BUS
{ 
    /// Lớp BUS xử lý nghiệp vụ cho Nhân viên 
    public class NhanVienBUS
    {
        private NhanVienDAL dalNhanVien = new NhanVienDAL();
         
        /// Lấy danh sách tất cả nhân viên 
        public List<NhanVienDTO> GetAllNhanVien()
        {
            return dalNhanVien.GetAllNhanVien();
        }
         
        /// Thêm nhân viên mới 
        public bool ThemNhanVien(NhanVienDTO nv)
        {
            // Kiểm tra dữ liệu đầu vào
            if (string.IsNullOrWhiteSpace(nv.TenNV))
            {
                throw new Exception("Tên nhân viên không được để trống!");
            }

            if (string.IsNullOrWhiteSpace(nv.DienThoai))
            {
                throw new Exception("Số điện thoại không được để trống!");
            }

            // Kiểm tra định dạng số điện thoại (10 số)
            if (nv.DienThoai.Length < 10 || nv.DienThoai.Length > 11)
            {
                throw new Exception("Số điện thoại phải có 10-11 số!");
            }

            // Gọi DAL để thêm
            return dalNhanVien.ThemNhanVien(nv);
        }
         
        /// Sửa thông tin nhân viên 
        public bool SuaNhanVien(NhanVienDTO nv)
        {
            // Kiểm tra dữ liệu
            if (nv.MaNV <= 0)
            {
                throw new Exception("Mã nhân viên không hợp lệ!");
            }

            if (string.IsNullOrWhiteSpace(nv.TenNV))
            {
                throw new Exception("Tên nhân viên không được để trống!");
            }

            // Gọi DAL để sửa
            return dalNhanVien.SuaNhanVien(nv);
        } 
        /// Xóa nhân viên 
        public bool XoaNhanVien(int maNV)
        {
            if (maNV <= 0)
            {
                throw new Exception("Mã nhân viên không hợp lệ!");
            }

            return dalNhanVien.XoaNhanVien(maNV);
        }
    }
}