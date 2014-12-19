using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Threading.Tasks;
using DataTransferObject;
using System.Data.SqlClient;

namespace DataAccessTier
{
    public class KhachHangDAT : DataBases
    {
        
        public KhachHangDAT()
        {
            
        }

        public DataTable LayDanhSachKhachHang()
        {
            try
            {
                return this.LoadDataTable("KHACHHANG_Lst");
            }
            catch (System.Exception ex)
            {
                Console.WriteLine("Message = {1}", ex.Message);
            }
            return null;
        }

        public bool ThemKhachHang(KhachHang kh)
        {
            try
            {
                SqlParameter[] para = new SqlParameter[5];
                //para[0] = new SqlParameter("@p_MaKhachHang", kh.MaKhachHang);
                para[0] = new SqlParameter("@p_TenKhachHang", kh.TenKhachHang);
                //para[1] = new SqlParameter("@p_MaLoaiKhachHang", kh.LoaiKhachHang.MaLoaiKhachHang);
                para[1] = new SqlParameter("@p_DiaChi", kh.DiaChi);
                para[2] = new SqlParameter("@p_SoDienThoai", kh.SoDienThoai);
                para[3] = new SqlParameter("@p_Email", kh.Email);
                para[4] = new SqlParameter("@p_GhiChu", kh.GhiChu);

                int result = this.ExecuteNonQuery("KHACHHANG_Ins", para);
                if (result != 0)
                {
                    return true;
                }
            }
            catch (System.Exception ex)
            {
                Console.WriteLine("Message = {1}", ex.Message); 
            }
            return false;
        }

        public bool CapNhatKhachHang(KhachHang kh)
        {
            try
            {
                SqlParameter[] para = new SqlParameter[6];
                para[0] = new SqlParameter("@p_MaKhachHang", kh.MaKhachHang == null ? "" :kh.MaKhachHang);
                para[1] = new SqlParameter("@p_TenKhachHang", kh.TenKhachHang == null ? "" :kh.TenKhachHang);
                para[2] = new SqlParameter("@p_DiaChi", kh.DiaChi == null ? "" :kh.DiaChi);
                para[3] = new SqlParameter("@p_SoDienThoai", kh.SoDienThoai ==  null ? "":kh.SoDienThoai);
                para[4] = new SqlParameter("@p_Email", kh.Email ==  null ? "" :kh.Email);
                para[5] = new SqlParameter("@p_GhiChu", kh.GhiChu ==  null ? "" :kh.GhiChu);

                int result = this.ExecuteNonQuery("KHACHHANG_Upd", para);
                if (result !=0)
                {
                    return true;
                }
            }
            catch (System.Exception ex)
            {
                Console.WriteLine("Message = {1}", ex.Message); 
            }
            return false;
        }

        public bool XoaKhachHang(String maKhachHang)
        {
            try
            {
                SqlParameter[] para = new SqlParameter[1];
                para[0] = new SqlParameter("@p_MaKhachHang", maKhachHang);

                int result = this.ExecuteNonQuery("KHACHHANG_Del", para);
                if (result != 0)
                {
                    return true;
                }
            }
            catch (System.Exception ex)
            {
                Console.WriteLine("Message = {1}", ex.Message);
            }
            return false;
        }

        public DataTable TimKiemKhachHang(KhachHang kh)
        {
            try
            {
                SqlParameter[] para = new SqlParameter[6];
                para[0] = new SqlParameter("@p_MaKhachHang", kh.MaKhachHang == null ? "" : kh.MaKhachHang);
                para[1] = new SqlParameter("@p_TenKhachHang", kh.TenKhachHang == null ? "" : kh.TenKhachHang);
                para[2] = new SqlParameter("@p_DiaChi", kh.DiaChi == null ? "" : kh.DiaChi);
                para[3] = new SqlParameter("@p_SoDienThoai", kh.SoDienThoai ==  null ?  "" : kh.SoDienThoai);
                para[4] = new SqlParameter("@p_Email", kh.Email ==  null ? "" :kh.Email);
                para[5] = new SqlParameter("@p_GhiChu", kh.GhiChu == null ? "" : kh.GhiChu);

                DataTable lstKhachHang =  this.LoadDataTable("KHACHHANG_Search", para);
                return lstKhachHang;
            }
            catch (System.Exception ex)
            {
                Console.WriteLine("Message = {1}", ex.Message);
            }
            return null;
        }
    }
}
