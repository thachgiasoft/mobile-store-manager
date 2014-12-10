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
    public class HoaDonDAT : DataBases
    {
        public bool ThemHoaDon(HoaDon hd)
        {
            try
            {
                SqlParameter[] para = new SqlParameter[8];
                para[0] = new SqlParameter("@p_MaNhanVien", hd.NhanVien.MaNhanVien);
                para[1] = new SqlParameter("@p_TongTien", hd.TongTien);
                para[2] = new SqlParameter("@p_TienDaTT", hd.TienThanhToan);
                para[3] = new SqlParameter("@p_TienNo", hd.TienNo);
                para[4] = new SqlParameter("@p_TinhTrang", hd.MaTinhTrang);
                para[5] = new SqlParameter("@p_NgayGiaoHang", hd.NgayGiaoHang);
                para[6] = new SqlParameter("@p_NgayLap", hd.NgayLap);
                para[7] = new SqlParameter("@p_GhiChu", hd.GhiChu);

                int result = this.ExecuteNonQuery("HOADON_Ins", para);
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
        public string LayMaHoaDonMoiNhat()
        {
            try
            {
                return this.LoadDataTable("HOADONDATHANGMOINHAT_Lst").Rows[0].ItemArray[0].ToString();
            }
            catch (System.Exception ex)
            {
                Console.WriteLine("Message= {1}", ex.Message);
            }
            return null;
        }
        public DataTable LayDanhSachHoaDonDatHang()
        {
            try
            {
                return this.LoadDataTable("HOADONDATHANG_Lst");
            }
            catch (System.Exception ex)
            {
                Console.WriteLine("Message= {1}", ex.Message);
            }
            return null;
        }
    }
}
