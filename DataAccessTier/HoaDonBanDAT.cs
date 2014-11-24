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
    public class HoaDonBanDAT : DataBases
    {
        public HoaDonBanDAT()
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

        public bool ThemHoaDon(HoaDonBan hd)
        {
            try
            {
                SqlParameter[] para = new SqlParameter[7];
                para[0] = new SqlParameter("@p_MaHoaDon", hd.MaHoaDon);
                para[1] = new SqlParameter("@p_MaKhachHang", hd.MaKhachHang);
                para[2] = new SqlParameter("@p_TrangThai", hd.TrangThai);
                para[3] = new SqlParameter("@p_TongTien", hd.TongTien);
                para[4] = new SqlParameter("@p_TienDaTT", hd.TienDaTT);
                para[5] = new SqlParameter("@p_TienNo", hd.TienNo);
                para[6] = new SqlParameter("@p_NgayTT", hd.NgayTT);

                int result = this.ExecuteNonQuery("ThemHoaDon", para);
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

        public bool CapNhatHoaDon(HoaDonBan hd)
        {
              try
              {
                  SqlParameter[] para = new SqlParameter[7];
                  para[0] = new SqlParameter("@p_MaHoaDon", hd.MaHoaDon);
                  para[1] = new SqlParameter("@p_MaKhachHang", hd.MaKhachHang);
                  para[2] = new SqlParameter("@p_TrangThai", hd.TrangThai);
                  para[3] = new SqlParameter("@p_TongTien", hd.TongTien);
                  para[4] = new SqlParameter("@p_TienDaTT", hd.TienDaTT);
                  para[5] = new SqlParameter("@p_TienNo", hd.TienNo);
                  para[6] = new SqlParameter("@p_NgayTT", hd.NgayTT);

                  int result = this.ExecuteNonQuery("CapNhatHoaDon", para);
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
                int result = this.ExecuteNonQuery("XoaHoaDon", para);

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

        public DataTable TimKiemHoaDon(HoaDonBan hd)
        {
            try
            {
                SqlParameter[] para = new SqlParameter[7];
                para[0] = new SqlParameter("@p_MaHoaDon", hd.MaHoaDon);
                para[1] = new SqlParameter("@p_MaKhachHang", hd.MaKhachHang);
                para[2] = new SqlParameter("@p_TrangThai", hd.TrangThai);
                para[3] = new SqlParameter("@p_TongTien", hd.TongTien);
                para[4] = new SqlParameter("@p_TienDaTT", hd.TienDaTT);
                para[5] = new SqlParameter("@p_TienNo", hd.TienNo);
                para[6] = new SqlParameter("@p_NgayTT", hd.NgayTT);

                DataTable lstHoaDon = this.LoadDataTable("TimKiemHoaDon", para);
            }
            catch (System.Exception ex)
            {
                Console.WriteLine("Message= {1}", ex.Message);
            }    
            return null;
        }
    }
}
