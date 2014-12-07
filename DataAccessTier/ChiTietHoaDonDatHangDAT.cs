using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataTransferObject;
using System.Data.SqlClient;
using System.Data;

namespace DataAccessTier
{
    public class ChiTietHoaDonDatHangDAT : DataBases
    {
        public bool ThemChiTietHoaDonDatHang(ChiTietHoaDonDatHang cthd)
        {
            try
            {
                SqlParameter[] para = new SqlParameter[5];
                para[0] = new SqlParameter("@p_MaHoaDon", cthd.MaHoaDonDatHang);
                para[1] = new SqlParameter("@p_MaMatHang", cthd.MaMatHang);
                para[2] = new SqlParameter("@p_SoLuong", cthd.SoLuong);
                para[3] = new SqlParameter("@p_MaNhaCungCap", cthd.NhaCungCap.MaNhaCungCap);
                para[4] = new SqlParameter("@p_GhiChu", cthd.GhiChu);
                int result = this.ExecuteNonQuery("CT_HOADONDATHANG_Ins", para);
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

        public bool XoaChiTietHoaDonDathang(string MaHoaDon)
        {
            try
            {
                SqlParameter[] para = new SqlParameter[1];
                para[0] = new SqlParameter("@MaHoaDon", MaHoaDon);
                int result = this.ExecuteNonQuery("CT_HOADONDATHANG_Del", para);
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

        public DataTable LayChiTietHoaDonDatHangTheoMaHoaDon(string mahoadon)
        {
            SqlParameter[] para = new SqlParameter[1];
            para[0] = new SqlParameter("@MaHoaDon", mahoadon);
            try
            {
                return this.LoadDataTable("CT_HOADONDATHANG_Lst_LayChiTietTheoMaHoaDon", para);
            }
            catch (System.Exception ex)
            {
                Console.WriteLine("Message= {1}", ex.Message);
            }
            return null;
        }
    }
}
