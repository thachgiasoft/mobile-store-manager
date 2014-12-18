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
    public class CPUDAT : DataBases
    {
        public CPUDAT()
        {
           
        }

        public DataTable LoadComboBox()
        {
            try
            {
                return this.LoadDataTable("CPUDIENTHOAI_Lst");
            }
            catch (System.Exception ex)
            {
                Console.WriteLine("Message= {1}", ex.Message);
            }
            return null;
        }

        public DataTable LayDanhSachCPU()
        {
            try
            {
                return this.LoadDataTable("CPUDIENTHOAI_ListCPU");
            }
            catch (System.Exception ex)
            {
                Console.WriteLine("Message= {1}", ex.Message);
            }
            return null;
        }

        public bool ThemCPU(CPU cpu)
        {
            try
            {
                SqlParameter[] para = new SqlParameter[2];
                para[0] = new SqlParameter("@p_TenCPU", cpu.TenCPU);
                para[1] = new SqlParameter("@p_SoNhan", cpu.SonhanCPU);

                int result = this.ExecuteNonQuery("CPUDIENTHOAI_Ins", para);
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

        public bool CapNhatCPU(CPU cpu)
        {
            try
            {
                SqlParameter[] para = new SqlParameter[3];
                para[0] = new SqlParameter("@p_MaCPU", cpu.MaCPU);
                para[1] = new SqlParameter("@p_TenCPU", cpu.TenCPU);
                para[2] = new SqlParameter("@p_SoNhan", cpu.SonhanCPU);

                int result = this.ExecuteNonQuery("CPUDIENTHOAI_Upd", para);
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

        public bool XoaCPU(String maCPU)
        {
            try
            {
                SqlParameter[] para = new SqlParameter[1];
                para[0] = new SqlParameter("@p_MaCPU", maCPU);
                int result = this.ExecuteNonQuery("CPUDIENTHOAI_Del", para);

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

        public DataTable TimKiemCPU(CPU cpu)
        {
            try
            {
                SqlParameter[] para = new SqlParameter[3];
                para[0] = new SqlParameter("@p_MaCPU", cpu.MaCPU);
                para[1] = new SqlParameter("@p_TenCPU", cpu.TenCPU);
                para[2] = new SqlParameter("@p_SoNhan", cpu.SonhanCPU);

                DataTable lstCPU = LoadDataTable("CPUDIENTHOAI_Search", para);

                return lstCPU;
            }
            catch (System.Exception ex)
            {
                Console.WriteLine("Message= {1}", ex.Message);
            }
            return null;
        }
    }
}
