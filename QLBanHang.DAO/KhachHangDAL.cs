using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QLBanHang.DTO;
using QLBanHang.DAL;

namespace QLBanHang.DAL
{
    /// <summary>
    /// Lớp DAL xử lý truy vấn dữ liệu cho Khách hàng
    /// </summary>
    public class KhachHangDAL
    {
        private QLBanHangDataContext db = new QLBanHangDataContext();

        /// Lấy danh sách tất cả khách hàng 
        public List<KhachHangDTO> GetAllKhachHang()
        {
            try
            {
                var result = from kh in db.KhachHangs
                             select new KhachHangDTO
                             {
                                 MaKH = kh.MaKH,
                                 TenKH = kh.TenKH,
                                 DienThoai = kh.DienThoai,
                                 DiaChi = kh.DiaChi
                             };

                return result.ToList();
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi khi lấy danh sách khách hàng: " + ex.Message);
            }
        }
         
        /// Thêm khách hàng mới 
        public bool ThemKhachHang(KhachHangDTO kh)
        {
            try
            {
                KhachHang khachHang = new KhachHang
                {
                    TenKH = kh.TenKH,
                    DienThoai = kh.DienThoai,
                    DiaChi = kh.DiaChi
                };

                db.KhachHangs.InsertOnSubmit(khachHang);
                db.SubmitChanges();

                return true;
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi khi thêm khách hàng: " + ex.Message);
            }
        }
         
        /// Cập nhật thông tin khách hàng 
        public bool SuaKhachHang(KhachHangDTO kh)
        {
            try
            {
                var khachHang = db.KhachHangs.SingleOrDefault(x => x.MaKH == kh.MaKH);

                if (khachHang != null)
                {
                    khachHang.TenKH = kh.TenKH;
                    khachHang.DienThoai = kh.DienThoai;
                    khachHang.DiaChi = kh.DiaChi;

                    db.SubmitChanges();
                    return true;
                }

                return false;
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi khi sửa khách hàng: " + ex.Message);
            }
        }
         
        /// Xóa khách hàng 
        public bool XoaKhachHang(int maKH)
        {
            try
            {
                var khachHang = db.KhachHangs.SingleOrDefault(x => x.MaKH == maKH);

                if (khachHang != null)
                {
                    db.KhachHangs.DeleteOnSubmit(khachHang);
                    db.SubmitChanges();
                    return true;
                }

                return false;
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi khi xóa khách hàng: " + ex.Message);
            }
        }
    }
}