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
    public class LoaiMatHangDAT : DataBases
    {
        public LoaiMatHangDAT()
        {
           
        }
        public string GetTenLoaiMatHang(string maloaiMH)
        {
            string result = "";
            DataTable table;
            try
            {
                SqlParameter[] para = new SqlParameter[1];
                para[0] = new SqlParameter("@p_MaLoaiMatHang", maloaiMH);

                table = this.LoadDataTable("GetTenLoaiMatHang", para);
                foreach (DataRow row in table.Rows)
                {
                    result = row["TenLoaiMatHang"].ToString();
                }
            }
            catch (System.Exception ex)
            {
                Console.WriteLine("Message= {1}", ex.Message);
            }

            return result;
        }

        public string GetMaLoaiMatHang(string tenloaiMH)
        {
            string result = "";
            DataTable table;
            try
            {
                SqlParameter[] para = new SqlParameter[1];
                para[0] = new SqlParameter("@p_TenLoaiMatHang", tenloaiMH);

                table = this.LoadDataTable("GetMaLoaiMatHang", para);
                foreach (DataRow row in table.Rows)
                {
                    result = row["MaLoaiMatHang"].ToString();
                }
            }
            catch (System.Exception ex)
            {
                Console.WriteLine("Message= {1}", ex.Message);
            }

            return result;
        }

        public DataTable LoadComboBox()
        {
            try
            {
                return this.LoadDataTable("LOAIMATHANG_Lst");
            }
            catch (System.Exception ex)
            {
                Console.WriteLine("Message= {1}", ex.Message);
            }
            return null;
        }
       

        public DataTable LayDanhSachLoaiMatHang()
        {
            try
            {
                return this.LoadDataTable("LOAIMATHANG_ListLOAIMATHANG");
            }
            catch (System.Exception ex)
            {
                Console.WriteLine("Message= {1}", ex.Message);
            }
            return null;
        }

        public bool ThemLoaiMatHang(LoaiMatHang loaiMH)
        {
            try
            {
                SqlParameter[] para = new SqlParameter[3];
                para[0] = new SqlParameter("@p_TenLoaiMatHang", loaiMH.TenLoaiMatHang);
                para[1] = new SqlParameter("@p_DacDiem", loaiMH.DacDiem);
                para[2] = new SqlParameter("@p_GhiChu", loaiMH.GhiChu);

                int result = this.ExecuteNonQuery("LOAIMATHANG_Ins", para);
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

        public bool CapNhatLoaiMatHang(LoaiMatHang loaiMH)
        {
            try
            {
                SqlParameter[] para = new SqlParameter[4];
                para[0] = new SqlParameter("@p_MaLoaiMatHang", loaiMH.MaLoaiMatHang);
                para[1] = new SqlParameter("@p_TenLoaiMatHang", loaiMH.TenLoaiMatHang);
                para[2] = new SqlParameter("@p_DacDiem", loaiMH.DacDiem);
                para[3] = new SqlParameter("@p_GhiChu", loaiMH.GhiChu);

                int result = this.ExecuteNonQuery("LOAIMATHANG_Upd", para);
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

        public bool XoaLoaiMatHang(String maLoaiMH)
        {
            try
            {
                SqlParameter[] para = new SqlParameter[1];
                para[0] = new SqlParameter("@MaLoaiMatHang", maLoaiMH);
                int result = this.ExecuteNonQuery("LOAIMATHANG_Del", para);

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

        public DataTable TimKiemLoaiMatHang(LoaiMatHang loaiMH)
        {
            try
            {
                SqlParameter[] para = new SqlParameter[4];
                para[0] = new SqlParameter("@p_MaLoaiMatHang", loaiMH.MaLoaiMatHang);
                para[1] = new SqlParameter("@p_TenLoaiMatHang", loaiMH.TenLoaiMatHang);
                para[2] = new SqlParameter("@p_DacDiem", loaiMH.DacDiem);
                para[3] = new SqlParameter("@p_GhiChu", loaiMH.GhiChu);

                DataTable lstLoaiMH = LoadDataTable("LOAIMATHANG_Search", para);

                return lstLoaiMH;
            }
            catch (System.Exception ex)
            {
                Console.WriteLine("Message= {1}", ex.Message);
            }
            return null;
        }
    }
}
