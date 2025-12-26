using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QLBanHang.DTO;
using QLBanHang.DAO;

namespace QLBanHang.DAL
{ 
    /// Lớp DAL xử lý truy vấn dữ liệu cho Nhân viên 
    public class NhanVienDAL
    {
        private QLBanHangDataContext db = new QLBanHangDataContext();
         
        /// Lấy danh sách tất cả nhân viên 
        public List<NhanVienDTO> GetAllNhanVien()
        {
            try
            {
                var result = from nv in db.NhanViens
                             select new NhanVienDTO
                             {
                                 MaNV = nv.MaNV,
                                 TenNV = nv.TenNV,
                                 ChucVu = nv.ChucVu,
                                 DienThoai = nv.DienThoai
                             };

                return result.ToList();
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi khi lấy danh sách nhân viên: " + ex.Message);
            }
        }
         
        /// Thêm nhân viên mới 
        public bool ThemNhanVien(NhanVienDTO nv)
        {
            try
            {
                NhanVien nhanVien = new NhanVien
                {
                    TenNV = nv.TenNV,
                    ChucVu = nv.ChucVu,
                    DienThoai = nv.DienThoai
                };

                db.NhanViens.InsertOnSubmit(nhanVien);
                db.SubmitChanges();

                return true;
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi khi thêm nhân viên: " + ex.Message);
            }
        }
         
        /// Cập nhật thông tin nhân viên 
        public bool SuaNhanVien(NhanVienDTO nv)
        {
            try
            {
                var nhanVien = db.NhanViens.SingleOrDefault(x => x.MaNV == nv.MaNV);

                if (nhanVien != null)
                {
                    nhanVien.TenNV = nv.TenNV;
                    nhanVien.ChucVu = nv.ChucVu;
                    nhanVien.DienThoai = nv.DienThoai;

                    db.SubmitChanges();
                    return true;
                }

                return false;
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi khi sửa nhân viên: " + ex.Message);
            }
        }
         
        /// Xóa nhân viên 
        public bool XoaNhanVien(int maNV)
        {
            try
            {
                var nhanVien = db.NhanViens.SingleOrDefault(x => x.MaNV == maNV);

                if (nhanVien != null)
                {
                    db.NhanViens.DeleteOnSubmit(nhanVien);
                    db.SubmitChanges();
                    return true;
                }

                return false;
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi khi xóa nhân viên: " + ex.Message);
            }
        }
    }
}
