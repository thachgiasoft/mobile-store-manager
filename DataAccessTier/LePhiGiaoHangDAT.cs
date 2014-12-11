using DataTransferObject;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace DataAccessTier
{
    public class LePhiGiaoHangDAT : DataBases
    {
        public LePhiGiaoHangDAT()
        {

        }

        public DataTable LayDanhSachLePhiGiaoHang()
        {
            try
            {
                return this.LoadDataTable("LEPHIGIAOHANG_Lst");
            }
            catch (System.Exception ex)
            {
                Console.WriteLine("Message= {1}", ex.Message);
            }
            return null;
        }

        public bool ThemLePhiGiaoHang(LePhiGiaoHang lp)
        {
            try
            {
                SqlParameter[] para = new SqlParameter[2];
                para[0] = new SqlParameter("@p_TenKhuVuc", lp.TenKhuVuc == null ? "" : lp.TenKhuVuc);
                para[1] = new SqlParameter("@p_DonGia", lp.Dongia == null ? 0 : lp.Dongia);

                int result = this.ExecuteNonQuery("LEPHIGIAOHANG_Ins", para);
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

        public bool CapNhatLePhiGiaoHang(LePhiGiaoHang lp)
        {
            try
            {
                SqlParameter[] para = new SqlParameter[3];
                para[0] = new SqlParameter("@p_MaKhuVuc", lp.MaKhuVuc == null ? "" : lp.MaKhuVuc);
                para[1] = new SqlParameter("@p_TenKhuVuc", lp.TenKhuVuc == null ? "" : lp.TenKhuVuc);
                para[2] = new SqlParameter("@p_DonGia", lp.Dongia == null ? 0 : lp.Dongia);

                int result = this.ExecuteNonQuery("LEPHIGIAOHANG_Upd", para);
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

        public bool XoaLePhiGiaoHang(String maKhuVuc)
        {
            try
            {
                SqlParameter[] para = new SqlParameter[1];
                para[0] = new SqlParameter("@MaKhuVuc", maKhuVuc);
                int result = this.ExecuteNonQuery("LEPHIGIAOHANG_Del", para);

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

        public DataTable TimKiemLePhiGiaoHang(LePhiGiaoHang lp)
        {
            try
            {
                SqlParameter[] para = new SqlParameter[4];
                para[0] = new SqlParameter("@p_MaKhuVuc", lp.MaKhuVuc == null ? "" : lp.MaKhuVuc);
                para[1] = new SqlParameter("@p_TenKhuVuc", lp.TenKhuVuc == null ? "" : lp.TenKhuVuc);
                para[2] = new SqlParameter("@p_DonGia", lp.Dongia == null ? 0 : lp.Dongia);
                para[3] = new SqlParameter("@p_TOP", 100);
                DataTable lstKhuyenMai = LoadDataTable("LEPHIGIAOHANG_Search", para);

                return lstKhuyenMai;
            }
            catch (System.Exception ex)
            {
                Console.WriteLine("Message= {1}", ex.Message);
            }
            return null;
        }   
    }
}
