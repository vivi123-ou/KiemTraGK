using System;
using System.Collections.Generic;
using System.Linq;
using QLBanHang.DTO;

namespace QLBanHang.DAO
{ 
    /// Lớp DAO xử lý truy vấn dữ liệu cho Sản phẩm
    /// Sử dụng LINQ to SQL, không dùng SqlCommand 
    public class SanPhamDAL
    {
        // Khởi tạo DataContext để kết nối CSDL
        private QLBanHangDataContext db = new QLBanHangDataContext();

        /// Lấy danh sách tất cả sản phẩm 
        public List<SanPhamDTO> GetAllSanPham()
        {
            try
            {
                // Sử dụng LINQ to SQL để truy vấn
                var result = from sp in db.SanPhams
                             select new SanPhamDTO
                             {
                                 MaSP = sp.MaSP,
                                 TenSP = sp.TenSP,
                                 DonGia = sp.DonGia,
                                 SoLuong = sp.SoLuong,
                                 TrangThai = sp.TrangThai ?? true
                             };

                return result.ToList();
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi khi lấy danh sách sản phẩm: " + ex.Message);
            }
        }
         
        /// Thêm sản phẩm mới 
        public bool ThemSanPham(SanPhamDTO sp)
        {
            try
            {
                // Tạo đối tượng SanPham từ LINQ to SQL
                SanPham sanPham = new SanPham
                {
                    TenSP = sp.TenSP,
                    DonGia = sp.DonGia,
                    SoLuong = sp.SoLuong,
                    TrangThai = sp.TrangThai
                };

                // Thêm vào DataContext
                db.SanPhams.InsertOnSubmit(sanPham);

                // Lưu thay đổi vào CSDL
                db.SubmitChanges();

                return true;
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi khi thêm sản phẩm: " + ex.Message);
            }
        }

    
        /// Cập nhật thông tin sản phẩm 
        public bool SuaSanPham(SanPhamDTO sp)
        {
            try
            {
                // Tìm sản phẩm cần sửa bằng LINQ
                var sanPham = db.SanPhams.SingleOrDefault(x => x.MaSP == sp.MaSP);

                if (sanPham != null)
                {
                    // Cập nhật thông tin
                    sanPham.TenSP = sp.TenSP;
                    sanPham.DonGia = sp.DonGia;
                    sanPham.SoLuong = sp.SoLuong;
                    sanPham.TrangThai = sp.TrangThai;

                    // Lưu thay đổi
                    db.SubmitChanges();
                    return true;
                }

                return false;
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi khi sửa sản phẩm: " + ex.Message);
            }
        }
         
        /// Xóa sản phẩm 
        public bool XoaSanPham(int maSP)
        {
            try
            {
                // Tìm sản phẩm cần xóa bằng LINQ
                var sanPham = db.SanPhams.SingleOrDefault(x => x.MaSP == maSP);

                if (sanPham != null)
                {
                    // Xóa khỏi DataContext
                    db.SanPhams.DeleteOnSubmit(sanPham);

                    // Lưu thay đổi
                    db.SubmitChanges();
                    return true;
                }

                return false;
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi khi xóa sản phẩm: " + ex.Message);
            }
        }

  
        /// Tìm kiếm sản phẩm theo tên (sử dụng LINQ) 
        public List<SanPhamDTO> TimKiemSanPham(string tenSP)
        {
            try
            {
                // Sử dụng LINQ để tìm kiếm
                var result = from sp in db.SanPhams
                             where sp.TenSP.Contains(tenSP)
                             select new SanPhamDTO
                             {
                                 MaSP = sp.MaSP,
                                 TenSP = sp.TenSP,
                                 DonGia = sp.DonGia,
                                 SoLuong = sp.SoLuong,
                                 TrangThai = sp.TrangThai ?? true
                             };

                return result.ToList();
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi khi tìm kiếm sản phẩm: " + ex.Message);
            }
        }
         
        /// Lọc sản phẩm còn hàng (SoLuong > 0) 
        public List<SanPhamDTO> LocSanPhamConHang()
        {
            try
            {
                // Sử dụng LINQ để lọc
                var result = from sp in db.SanPhams
                             where sp.SoLuong > 0
                             select new SanPhamDTO
                             {
                                 MaSP = sp.MaSP,
                                 TenSP = sp.TenSP,
                                 DonGia = sp.DonGia,
                                 SoLuong = sp.SoLuong,
                                 TrangThai = sp.TrangThai ?? true
                             };

                return result.ToList();
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi khi lọc sản phẩm còn hàng: " + ex.Message);
            }
        }
    }
}