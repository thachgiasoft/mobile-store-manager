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
    public class ChiTietBaoCaoTonKhoDAT : DataBases
    {
        public DataTable LayChiTietTonKho(string thoigian)
        {
            try
            {
                SqlParameter[] para = new SqlParameter[1];
                para[0] = new SqlParameter("@p_MaBCTK", thoigian);
                return this.LoadDataTable("CHITIETBAOCAOTONKHO_Lst", para);
            }
            catch (System.Exception ex)
            {
                Console.WriteLine("Message= {1}", ex.Message);
            }

            return null;
        }

        public DataTable LayThongTinTonKho()
        {
            try
            {
                return this.LoadDataTable("CHITIETBAOCAOTONKHO_LayThongTin");
            }
            catch (System.Exception ex)
            {
                Console.WriteLine("Message= {1}", ex.Message);
            }

            return null;
        }

        public bool XoaChiTietBaoCaoTonKho(string mabaocao)
        {
            try
            {
                SqlParameter[] para = new SqlParameter[1];
                para[0] = new SqlParameter("@MaBCTK", mabaocao);
                int result = this.ExecuteNonQuery("CT_BAOCAOTONKHO_Del", para);
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


        public bool ThemChiTietBaoCaoTonKho(ChiTietBaoCaoTonKho ct)
        {
            try
            {
                SqlParameter[] para = new SqlParameter[3];
                para[0] = new SqlParameter("@p_MaBCTK", ct.MaBCTK);
                para[1] = new SqlParameter("@p_MaMatHang", ct.MaMatHang);
                para[2] = new SqlParameter("@p_SoLuongTon", ct.SoLuongTon);
                int result = this.ExecuteNonQuery("CT_BAOCAOTONKHO_Ins", para);
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
    }
}
