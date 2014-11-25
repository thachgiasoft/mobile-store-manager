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
                para[0] = new SqlParameter("@p_MaNhanVien", nv.MaNhanVien);
                para[1] = new SqlParameter("@p_TenNhanVien", nv.TenNhanVien);
                para[2] = new SqlParameter("@p_CMND", nv.cMND);
                para[3] = new SqlParameter("@p_GioTinh", nv.GioiTinh);
                para[4] = new SqlParameter("@p_DiaChi", nv.DiaChi);
                para[5] = new SqlParameter("@p_SoDienThoai", nv.SoDienThoai);
                para[6] = new SqlParameter("@p_Email", nv.Email);
                para[7] = new SqlParameter("@p_NgaySinh", nv.NgaySinh);
                para[8] = new SqlParameter("@p_TaiKhoan", nv.TaiKhoan);
                para[9] = new SqlParameter("@p_MatKhau", nv.MatKhau);
                para[10] = new SqlParameter("@p_ChucVu", nv.ChucVuNhanVien.MaChucVu);
                para[11] = new SqlParameter("@p_GhiChu", nv.GhiChu);

                int result = this.ExecuteNonQuery("NHANVIEN_Ins", para);
                if (result == 1)
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
                  SqlParameter[] para = new SqlParameter[11];
                  para[0] = new SqlParameter("@p_MaNhanVien", nv.MaNhanVien);
                  para[1] = new SqlParameter("@p_TenNhanVien", nv.TenNhanVien);
                  para[2] = new SqlParameter("@p_CMND", nv.cMND);
                  para[3] = new SqlParameter("@p_GioTinh", nv.GioiTinh);
                  para[4] = new SqlParameter("@p_DiaChi", nv.DiaChi);
                  para[5] = new SqlParameter("@p_SoDienThoai", nv.SoDienThoai);
                  para[6] = new SqlParameter("@p_Email", nv.Email);
                  para[7] = new SqlParameter("@p_NgaySinh", nv.NgaySinh);
                  para[8] = new SqlParameter("@p_TaiKhoan", nv.TaiKhoan);
                  para[9] = new SqlParameter("@p_MatKhau", nv.MatKhau);
                  para[10] = new SqlParameter("@p_ChucVu", nv.ChucVuNhanVien.MaChucVu);
                  para[11] = new SqlParameter("@p_GhiChu", nv.GhiChu);

                  int result = this.ExecuteNonQuery("NHANVIEN_Upd", para);
                  if (result == 1)
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
                para[0] = new SqlParameter("@p_MaNhanVien", maNhanVien);
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
                SqlParameter[] para = new SqlParameter[11];
                para[0] = new SqlParameter("@p_MaNhanVien", nv.MaNhanVien);
                para[1] = new SqlParameter("@p_TenNhanVien", nv.TenNhanVien);
                para[2] = new SqlParameter("@p_CMND", nv.cMND);
                para[3] = new SqlParameter("@p_GioTinh", nv.GioiTinh);
                para[4] = new SqlParameter("@p_DiaChi", nv.DiaChi);
                para[5] = new SqlParameter("@p_SoDienThoai", nv.SoDienThoai);
                para[6] = new SqlParameter("@p_Email", nv.Email);
                para[7] = new SqlParameter("@p_NgaySinh", nv.NgaySinh);
                para[8] = new SqlParameter("@p_TaiKhoan", nv.TaiKhoan);
                para[9] = new SqlParameter("@p_MatKhau", nv.MatKhau);
                para[10] = new SqlParameter("@p_ChucVu", nv.ChucVuNhanVien.MaChucVu);
                para[11] = new SqlParameter("@p_GhiChu", nv.GhiChu);
                DataTable lstNhanVien = LoadDataTable("NHANVIEN_Search", para);
            }
            catch (System.Exception ex)
            {
                Console.WriteLine("Message= {1}", ex.Message);
            }    
            return null;
        }
    }
}
