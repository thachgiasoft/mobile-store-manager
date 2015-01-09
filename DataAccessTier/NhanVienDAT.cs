using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using DataAccessTier;
using DataTransferObject;
using System.Data.SqlClient;

namespace DataAccessTier
{
    public class NhanVienDAT : DataBases
    {        
        public NhanVienDAT()
        {
           
        }

        public NhanVien DangNhap(string taikhoan, string matkhau)
        {
            SqlParameter[] para = new SqlParameter[2];
            para[0] = new SqlParameter("@p_TaiKhoan", taikhoan);
            para[1] = new SqlParameter("@p_MatKhau", matkhau);
            DataTable data = this.LoadDataTable("DangNhap", para);

            if (data != null && data.Rows.Count != 0)
            {
                NhanVien nhanvien = new NhanVien();
                nhanvien.MaNhanVien = data.Rows[0][0].ToString();
                nhanvien.TenNhanVien = data.Rows[0][1].ToString();
                nhanvien.ChucVuNhanVien.MaChucVu = data.Rows[0][2].ToString();
                nhanvien.ChucVuNhanVien.TenChucVu = data.Rows[0][3].ToString();
                return nhanvien;
            }
            return null;
            
        }
        public DataTable LayDanhSachNhanVien()
        {
            try
            {
                return this.LoadDataTable("NHANVIEN_Lst");
            }
            catch (System.Exception ex)
            {
                Console.WriteLine("Message= {1}", ex.Message);
            }       
            return null;
        }

        public bool ThemNhanVien(NhanVien nv)
        {
            try
            {
                SqlParameter[] para = new SqlParameter[11];
                para[0] = new SqlParameter("@p_TenNhanVien", nv.TenNhanVien == null ? "" : nv.TenNhanVien);
                para[1] = new SqlParameter("@p_CMND", nv.CMND == null ? "" : nv.CMND);
                para[2] = new SqlParameter("@p_GioiTinh", nv.GioiTinh == null ? "" : nv.GioiTinh);
                para[3] = new SqlParameter("@p_DiaChi", nv.DiaChi == null ? "" : nv.DiaChi);
                para[4] = new SqlParameter("@p_SoDienThoai", nv.SoDienThoai == null ? "" : nv.SoDienThoai);
                para[5] = new SqlParameter("@p_Email", nv.Email == null ? "" : nv.Email);
                para[6] = new SqlParameter("@p_NgaySinh", nv.NgaySinh == null ? "01-01-2001" : nv.NgaySinh);
                para[7] = new SqlParameter("@p_TaiKhoan", nv.TaiKhoan == null ? "" : nv.TaiKhoan);
                para[8] = new SqlParameter("@p_MatKhau", nv.MatKhau == null ? "" : nv.MatKhau);
                para[9] = new SqlParameter("@p_MaChucVu", nv.ChucVuNhanVien.MaChucVu == null ? "" : nv.ChucVuNhanVien.MaChucVu);
                para[10] = new SqlParameter("@p_GhiChu", nv.GhiChu == null ? "" : nv.GhiChu);

                int result = this.ExecuteNonQuery("NHANVIEN_Ins", para);
                if (result != 0)
                {
                    return true;
                }
            }
            catch (System.Exception ex)
            {
                Console.WriteLine("Message= {1}", ex.Message);
            }

            return false;
        }

        public bool CapNhatNhanVien(NhanVien nv)
        {
              try
              {
                  SqlParameter[] para = new SqlParameter[12];
                  para[0] = new SqlParameter("@p_MaNhanVien", nv.MaNhanVien == null ? "" : nv.MaNhanVien);
                  para[1] = new SqlParameter("@p_TenNhanVien", nv.TenNhanVien == null ? "" : nv.TenNhanVien);
                  para[2] = new SqlParameter("@p_CMND", nv.CMND == null ? "" : nv.CMND);
                  para[3] = new SqlParameter("@p_GioiTinh", nv.GioiTinh != null ? nv.GioiTinh : nv.GioiTinh);
                  para[4] = new SqlParameter("@p_DiaChi", nv.DiaChi == null ? "" : nv.DiaChi);
                  para[5] = new SqlParameter("@p_SoDienThoai", nv.SoDienThoai == null ? "" : nv.SoDienThoai);
                  para[6] = new SqlParameter("@p_Email", nv.Email == null ? "" : nv.Email);
                  para[7] = new SqlParameter("@p_NgaySinh", nv.NgaySinh == null ? "01-01-2001" : nv.NgaySinh);
                  para[8] = new SqlParameter("@p_TaiKhoan", nv.TaiKhoan == null ? "" : nv.TaiKhoan);
                  para[9] = new SqlParameter("@p_MatKhau", nv.MatKhau == null ? "" : nv.MatKhau);
                  para[10] = new SqlParameter("@p_MaChucVu", nv.ChucVuNhanVien.MaChucVu == null ? "" : nv.ChucVuNhanVien.MaChucVu);
                  para[11] = new SqlParameter("@p_GhiChu", nv.GhiChu == null ? "" : nv.GhiChu);

                  int result = this.ExecuteNonQuery("NHANVIEN_Upd", para);
                  if (result != 0)
                  {
                      return true;
                  }
              }
              catch (System.Exception ex)
              {
                  Console.WriteLine("Message= {1}", ex.Message);
              }
                   
            return false;
        }

        public bool XoaNhanVien(String maNhanVien)
        {
            try
            {
                SqlParameter[] para = new SqlParameter[1];
                para[0] = new SqlParameter("@MaNhanVien", maNhanVien);
                int result = this.ExecuteNonQuery("NHANVIEN_Del", para);

                if (result != 0)
                {
                    return true;
                }
            }
            catch (System.Exception ex)
            {
                Console.WriteLine("Message= {1}", ex.Message);
            }           
            return false;
        }

        public DataTable TimKiemNhanVien(NhanVien nv)
        {
            try
            {
                SqlParameter[] para = new SqlParameter[12];
                para[0] = new SqlParameter("@p_MaNhanVien", nv.MaNhanVien == null ? "" : nv.MaNhanVien);
                para[1] = new SqlParameter("@p_TenNhanVien", nv.TenNhanVien == null ? "" : nv.TenNhanVien);
                para[2] = new SqlParameter("@p_CMND", nv.CMND == null ? "" : nv.CMND);
                para[3] = new SqlParameter("@p_GioiTinh", nv.GioiTinh == null ? "" : nv.GioiTinh);
                para[4] = new SqlParameter("@p_DiaChi", nv.DiaChi == null ? "" : nv.DiaChi);
                para[5] = new SqlParameter("@p_SoDienThoai", nv.SoDienThoai == null ? "" : nv.SoDienThoai);
                para[6] = new SqlParameter("@p_Email", nv.Email == null ? "" : nv.Email);
                para[7] = new SqlParameter("@p_NgaySinh", nv.NgaySinh == null ? "01/01/2001" : nv.NgaySinh);
                para[8] = new SqlParameter("@p_TaiKhoan", nv.TaiKhoan == null ? "" : nv.TaiKhoan);
                para[9] = new SqlParameter("@p_MatKhau", nv.MatKhau == null ? "" : nv.MatKhau);
                para[10] = new SqlParameter("@p_MaChucVu", nv.ChucVuNhanVien.MaChucVu == null ? "" : nv.ChucVuNhanVien.MaChucVu);
                para[11] = new SqlParameter("@p_GhiChu", nv.GhiChu == null ? "" : nv.GhiChu);
              
                DataTable lstNhanVien = LoadDataTable("NHANVIEN_Search", para);

                return lstNhanVien;
            }
            catch (System.Exception ex)
            {
                Console.WriteLine("Message= {1}", ex.Message);
            }    
            return null;
        }
    }
}
