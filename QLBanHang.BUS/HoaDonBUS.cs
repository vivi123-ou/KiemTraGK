using System;
using System.Collections.Generic;
using System.Linq;
using QLBanHang.DTO;
using QLBanHang.DAL;

namespace QLBanHang.BUS
{ 
    /// Lớp BUS xử lý nghiệp vụ cho Hóa đơn 
    public class HoaDonBUS
    {
        private HoaDonDAL dalHoaDon = new HoaDonDAL();
         
        /// Thêm hóa đơn mới với kiểm tra dữ liệu 
        public bool ThemHoaDon(HoaDonDTO hoaDon, List<ChiTietHoaDonDTO> chiTietList)
        {
            // Kiểm tra dữ liệu hóa đơn
            if (hoaDon.MaNV <= 0)
            {
                throw new Exception("Vui lòng chọn nhân viên!");
            }

            if (hoaDon.MaKH <= 0)
            {
                throw new Exception("Vui lòng chọn khách hàng!");
            }

            // Kiểm tra chi tiết hóa đơn
            if (chiTietList == null || chiTietList.Count == 0)
            {
                throw new Exception("Hóa đơn phải có ít nhất một sản phẩm!");
            }

            // Kiểm tra từng chi tiết
            foreach (var ct in chiTietList)
            {
                if (ct.SoLuong <= 0)
                {
                    throw new Exception("Số lượng sản phẩm phải lớn hơn 0!");
                }

                if (ct.DonGia <= 0)
                {
                    throw new Exception("Đơn giá sản phẩm phải lớn hơn 0!");
                }
            }

            // Gọi DAL để thêm
            return dalHoaDon.ThemHoaDon(hoaDon, chiTietList);
        }
         
        /// Tính tổng tiền hóa đơn sử dụng LINQ (THEO YÊU CẦU ĐỀ BÀI)
        /// TongTien = ChiTietHoaDon.Sum(ct => ct.SoLuong * ct.DonGia); 
        public decimal TinhTongTien(List<ChiTietHoaDonDTO> chiTietList)
        {
            if (chiTietList == null || chiTietList.Count == 0)
            {
                return 0;
            }

            // Sử dụng LINQ để tính tổng như yêu cầu đề bài
            decimal tongTien = chiTietList.Sum(ct => ct.SoLuong * ct.DonGia);

            return tongTien;
        }
         
        /// Lấy danh sách hóa đơn theo khoảng ngày 
        public List<HoaDonDTO> GetHoaDonTheoNgay(DateTime tuNgay, DateTime denNgay)
        {
            if (tuNgay > denNgay)
            {
                throw new Exception("Ngày bắt đầu phải nhỏ hơn hoặc bằng ngày kết thúc!");
            }

            return dalHoaDon.GetHoaDonTheoNgay(tuNgay, denNgay);
        }
         
        /// Lấy top 3 sản phẩm bán chạy nhất 
        public List<dynamic> GetTop3SanPhamBanChay()
        {
            return dalHoaDon.GetTop3SanPhamBanChay();
        }
         
        /// Tính tổng doanh thu theo tháng 
        public List<dynamic> GetDoanhThuTheoThang(int nam)
        {
            if (nam < 2000 || nam > DateTime.Now.Year)
            {
                throw new Exception("Năm không hợp lệ!");
            }

            return dalHoaDon.GetDoanhThuTheoThang(nam);
        }
         
        /// Lấy chi tiết hóa đơn 
        public List<ChiTietHoaDonDTO> GetChiTietHoaDon(int maHD)
        {
            if (maHD <= 0)
            {
                throw new Exception("Mã hóa đơn không hợp lệ!");
            }

            return dalHoaDon.GetChiTietHoaDon(maHD);
        }
    }
}