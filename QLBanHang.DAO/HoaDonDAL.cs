using System;
using System.Collections.Generic;
using System.Linq;
using QLBanHang.DAL;
using QLBanHang.DTO;

namespace QLBanHang.DAL
{ 
    /// Lớp DAL xử lý truy vấn dữ liệu cho Hóa đơn và Chi tiết hóa đơn 
    public class HoaDonDAL
    {
        private QLBanHangDataContext db = new QLBanHangDataContext();

        /// Thêm hóa đơn mới và chi tiết hóa đơn
        /// Sử dụng Transaction để đảm bảo tính toàn vẹn dữ liệu 
        public bool ThemHoaDon(HoaDonDTO hoaDon, List<ChiTietHoaDonDTO> chiTietList)
        {
            try
            {
                // Tạo hóa đơn mới
                HoaDon hd = new HoaDon
                {
                    NgayLap = hoaDon.NgayLap,
                    MaNV = hoaDon.MaNV,
                    MaKH = hoaDon.MaKH
                };

                // Thêm hóa đơn vào DataContext
                db.HoaDons.InsertOnSubmit(hd);
                db.SubmitChanges(); // Lưu để lấy MaHD tự động tăng

                // Thêm chi tiết hóa đơn
                foreach (var ct in chiTietList)
                {
                    ChiTietHoaDon chiTiet = new ChiTietHoaDon
                    {
                        MaHD = hd.MaHD, // Sử dụng MaHD vừa được tạo
                        MaSP = ct.MaSP,
                        SoLuong = ct.SoLuong,
                        DonGia = ct.DonGia
                    };

                    db.ChiTietHoaDons.InsertOnSubmit(chiTiet);

                    // Cập nhật số lượng tồn kho
                    var sanPham = db.SanPhams.SingleOrDefault(x => x.MaSP == ct.MaSP);
                    if (sanPham != null)
                    {
                        sanPham.SoLuong -= ct.SoLuong;
                    }
                }

                // Lưu tất cả thay đổi
                db.SubmitChanges();
                return true;
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi khi thêm hóa đơn: " + ex.Message);
            }
        }
         
        /// Lấy danh sách hóa đơn theo khoảng ngày (LINQ) 
        public List<HoaDonDTO> GetHoaDonTheoNgay(DateTime tuNgay, DateTime denNgay)
        {
            try
            {
                var result = from hd in db.HoaDons
                             where hd.NgayLap >= tuNgay && hd.NgayLap <= denNgay
                             select new HoaDonDTO
                             {
                                 MaHD = hd.MaHD,
                                 NgayLap = hd.NgayLap,
                                 MaNV = hd.MaNV,
                                 MaKH = hd.MaKH
                             };

                return result.ToList();
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi khi lấy hóa đơn theo ngày: " + ex.Message);
            }
        }
         
        /// Lấy top 3 sản phẩm bán chạy nhất (LINQ) 
        public List<dynamic> GetTop3SanPhamBanChay()
        {
            try
            {
                var result = (from ct in db.ChiTietHoaDons
                              join sp in db.SanPhams on ct.MaSP equals sp.MaSP
                              group ct by new { ct.MaSP, sp.TenSP } into g
                              orderby g.Sum(x => x.SoLuong) descending
                              select new
                              {
                                  MaSP = g.Key.MaSP,
                                  TenSP = g.Key.TenSP,
                                  TongSoLuongBan = g.Sum(x => x.SoLuong)
                              })
                             .Take(3)
                             .ToList<dynamic>();

                return result;
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi khi lấy top 3 sản phẩm: " + ex.Message);
            }
        }
         
        /// Tính tổng doanh thu theo tháng (LINQ) 
        public List<dynamic> GetDoanhThuTheoThang(int nam)
        {
            try
            {
                var result = (from hd in db.HoaDons
                              join ct in db.ChiTietHoaDons on hd.MaHD equals ct.MaHD
                              where hd.NgayLap.Year == nam
                              group ct by hd.NgayLap.Month into g
                              orderby g.Key
                              select new
                              {
                                  Thang = g.Key,
                                  TongDoanhThu = g.Sum(x => x.SoLuong * x.DonGia)
                              })
                             .ToList<dynamic>();

                return result;
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi khi tính doanh thu theo tháng: " + ex.Message);
            }
        }
         
        /// Lấy chi tiết hóa đơn theo mã hóa đơn 
        public List<ChiTietHoaDonDTO> GetChiTietHoaDon(int maHD)
        {
            try
            {
                var result = from ct in db.ChiTietHoaDons
                             join sp in db.SanPhams on ct.MaSP equals sp.MaSP
                             where ct.MaHD == maHD
                             select new ChiTietHoaDonDTO
                             {
                                 MaHD = ct.MaHD,
                                 MaSP = ct.MaSP,
                                 TenSP = sp.TenSP,
                                 SoLuong = ct.SoLuong,
                                 DonGia = ct.DonGia
                             };

                return result.ToList();
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi khi lấy chi tiết hóa đơn: " + ex.Message);
            }
        }
    }
}