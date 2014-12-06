using DataTransferObject;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessTier
{
    public class ChiTietHoaDonBanDAT : DataBases
    {
        public ChiTietHoaDonBanDAT()
        {
           
        }

        public DataTable LayDanhSachHoaDon()
        {
            try
            {
                return this.LoadDataTable("LayDanhSachHoaDon");
            }
            catch (System.Exception ex)
            {
                Console.WriteLine("Message= {1}", ex.Message);
            }       
            return null;
        }

        public bool ThemHoaDon(ChiTietHoaDonBan hd)
        {
            try
            {
                SqlParameter[] para = new SqlParameter[7];
                para[0] = new SqlParameter("@p_MaHoaDon", hd.MaHoaDon);
                para[1] = new SqlParameter("@p_MaKhachHang", hd.KhachHang.MaKhachHang);
                para[2] = new SqlParameter("@p_TrangThai", hd.TrangThai);
                para[3] = new SqlParameter("@p_TongTien", hd.TongTien);
                para[4] = new SqlParameter("@p_TienDaTT", hd.TienDaTT);
                para[5] = new SqlParameter("@p_TienNo", hd.TienNo);
                para[6] = new SqlParameter("@p_NgayTT", hd.NgayTT);

                int result = this.ExecuteNonQuery("HOADONBAN_Ins", para);
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

        public bool CapNhatHoaDon(ChiTietHoaDonBan hd)
        {
              try
              {
                  SqlParameter[] para = new SqlParameter[7];
                  para[0] = new SqlParameter("@p_MaHoaDon", hd.MaHoaDon);
                  para[1] = new SqlParameter("@p_MaKhachHang", hd.KhachHang.MaKhachHang);
                  para[2] = new SqlParameter("@p_TrangThai", hd.TrangThai);
                  para[3] = new SqlParameter("@p_TongTien", hd.TongTien);
                  para[4] = new SqlParameter("@p_TienDaTT", hd.TienDaTT);
                  para[5] = new SqlParameter("@p_TienNo", hd.TienNo);
                  para[6] = new SqlParameter("@p_NgayTT", hd.NgayTT);

                  int result = this.ExecuteNonQuery("HOADONBAN_Upd", para);
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

        public bool XoaHoaDon(String maHoaDon)
        {
            try
            {
                SqlParameter[] para = new SqlParameter[1];
                para[0] = new SqlParameter("@p_MaHoaDon", maHoaDon);
                int result = this.ExecuteNonQuery("HOADONBAN_Del", para);

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

        public DataTable TimKiemHoaDon(ChiTietHoaDonBan hd)
        {
            try
            {
                SqlParameter[] para = new SqlParameter[7];
                para[0] = new SqlParameter("@p_MaHoaDon", hd.MaHoaDon);
                para[1] = new SqlParameter("@p_MaKhachHang", hd.KhachHang.MaKhachHang);
                para[2] = new SqlParameter("@p_TrangThai", hd.TrangThai);
                para[3] = new SqlParameter("@p_TongTien", hd.TongTien);
                para[4] = new SqlParameter("@p_TienDaTT", hd.TienDaTT);
                para[5] = new SqlParameter("@p_TienNo", hd.TienNo);
                para[6] = new SqlParameter("@p_NgayTT", hd.NgayTT);

                DataTable lstHoaDon = this.LoadDataTable("HOADONBAN_Search", para);
            }
            catch (System.Exception ex)
            {
                Console.WriteLine("Message= {1}", ex.Message);
            }    
            return null;
        }
    }
}
