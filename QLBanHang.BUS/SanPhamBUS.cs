using System;
using System.Collections.Generic;
using QLBanHang.DTO;
using QLBanHang.DAL;  

namespace QLBanHang.BUS
{
    /// <summary>
    /// Lớp BUS xử lý nghiệp vụ cho Sản phẩm
    /// Kiểm tra dữ liệu đầu vào và gọi DAL
    /// </summary>
    public class SanPhamBUS
    {
        private SanPhamDAL dalSanPham = new SanPhamDAL();

        /// <summary>
        /// Lấy danh sách tất cả sản phẩm
        /// </summary>
        public List<SanPhamDTO> GetAllSanPham()
        {
            return dalSanPham.GetAllSanPham();
        }

        /// <summary>
        /// Thêm sản phẩm mới với kiểm tra dữ liệu
        /// </summary>
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

            // Gọi DAL để thêm
            return dalSanPham.ThemSanPham(sp);
        }

        /// <summary>
        /// Sửa sản phẩm với kiểm tra dữ liệu
        /// </summary>
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

            // Gọi DAL để sửa
            return dalSanPham.SuaSanPham(sp);
        }

        /// <summary>
        /// Xóa sản phẩm
        /// </summary>
        public bool XoaSanPham(int maSP)
        {
            if (maSP <= 0)
            {
                throw new Exception("Mã sản phẩm không hợp lệ!");
            }

            return dalSanPham.XoaSanPham(maSP);
        }

        /// <summary>
        /// Tìm kiếm sản phẩm theo tên
        /// </summary>
        public List<SanPhamDTO> TimKiemSanPham(string tenSP)
        {
            if (string.IsNullOrWhiteSpace(tenSP))
            {
                return GetAllSanPham(); // Trả về tất cả nếu không nhập gì
            }

            return dalSanPham.TimKiemSanPham(tenSP);
        }

        /// <summary>
        /// Lọc sản phẩm còn hàng
        /// </summary>
        public List<SanPhamDTO> LocSanPhamConHang()
        {
            return dalSanPham.LocSanPhamConHang();
        }
    }
}