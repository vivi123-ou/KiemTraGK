using System;
using System.Collections.Generic;
using QLBanHang.DTO;
using QLBanHang.DAO;  

namespace QLBanHang.BUS
{ 
    /// Lớp BUS xử lý nghiệp vụ cho Sản phẩm
    /// Kiểm tra dữ liệu đầu vào và gọi DAO 
    public class SanPhamBUS
    {
        private SanPhamDAL daoSanPham = new SanPhamDAL();  
         
        /// Lấy danh sách tất cả sản phẩm 
        public List<SanPhamDTO> GetAllSanPham()
        {
            return daoSanPham.GetAllSanPham();
        }
         
        /// Thêm sản phẩm mới với kiểm tra dữ liệu 
        public bool ThemSanPham(SanPhamDTO sp)
        {
            // Kiểm tra dữ liệu đầu vào
            if (string.IsNullOrWhiteSpace(sp.TenSP))
            {
                throw new Exception("Tên sản phẩm không được để trống!");
            }

            if (sp.DonGia <= 0)
            {
                throw new Exception("Đơn giá phải lớn hơn 0!");
            }

            if (sp.SoLuong < 0)
            {
                throw new Exception("Số lượng không được âm!");
            }

            // Gọi DAO để thêm
            return daoSanPham.ThemSanPham(sp);
        }
         
        /// Sửa sản phẩm với kiểm tra dữ liệu 
        public bool SuaSanPham(SanPhamDTO sp)
        {
            // Kiểm tra dữ liệu đầu vào
            if (sp.MaSP <= 0)
            {
                throw new Exception("Mã sản phẩm không hợp lệ!");
            }

            if (string.IsNullOrWhiteSpace(sp.TenSP))
            {
                throw new Exception("Tên sản phẩm không được để trống!");
            }

            if (sp.DonGia <= 0)
            {
                throw new Exception("Đơn giá phải lớn hơn 0!");
            }

            if (sp.SoLuong < 0)
            {
                throw new Exception("Số lượng không được âm!");
            }

            // Gọi DAO để sửa
            return daoSanPham.SuaSanPham(sp);
        }
         
        /// Xóa sản phẩm 
        public bool XoaSanPham(int maSP)
        {
            if (maSP <= 0)
            {
                throw new Exception("Mã sản phẩm không hợp lệ!");
            }

            return daoSanPham.XoaSanPham(maSP);
        }
         
        /// Tìm kiếm sản phẩm theo tên 
        public List<SanPhamDTO> TimKiemSanPham(string tenSP)
        {
            if (string.IsNullOrWhiteSpace(tenSP))
            {
                return GetAllSanPham(); // Trả về tất cả nếu không nhập gì
            }

            return daoSanPham.TimKiemSanPham(tenSP);
        }
         
        /// Lọc sản phẩm còn hàng 
        public List<SanPhamDTO> LocSanPhamConHang()
        {
            return daoSanPham.LocSanPhamConHang();
        }
    }
}