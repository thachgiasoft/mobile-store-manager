using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataTransferObject;
using DataAccessTier;
using System.Data;

namespace BusinessLogicTier
{
   public  class NhaCungCapBLT
    {
        NhaCungCapDAT _NhaCungCapDAT;

        public NhaCungCapBLT()
        {
            this._NhaCungCapDAT = new NhaCungCapDAT();
        }

        public DataTable LoadComBoBox()
        {
            try
            {
                return this._NhaCungCapDAT.LoadComboBox();
            }
            catch (System.Exception ex)
            {
                Console.WriteLine("Message= {1}", ex.Message);
            }
            return null;
        }

        public DataTable layDanhSachNhaCungCap()
        {
            DataTable data = new DataTable();
            try
            {
                data = this._NhaCungCapDAT.layDanhSachNhaCungCap();
                for (int i = 0; i < data.Rows.Count; i++)
                {
                   // data.Rows[i].
                }
                return data;
            }
            catch (System.Exception ex)
            {
                Console.WriteLine("Message= {1}", ex.Message);
            }
            return null;
        }

        public bool ThemNhaCungCap(NhaCungCap nhaCC)
        {
            try
            {
                return this._NhaCungCapDAT.ThemNhaCungCap(nhaCC);
            }
            catch (System.Exception ex)
            {
                Console.WriteLine("Message= {1}", ex.Message);
            }
            return false;
        }

        public bool CapNhatNhaCungCap(NhaCungCap nhaCC)
        {

            try
            {
                return this._NhaCungCapDAT.CapNhatNhaCungCap(nhaCC);
            }
            catch (System.Exception ex)
            {
                Console.WriteLine("Message= {1}", ex.Message);
            }
            return false;
        }

        public bool XoaNhaCungCap(String maNhaCC)
        {

            try
            {
                return this._NhaCungCapDAT.XoaNhaCungCap(maNhaCC);
            }
            catch (System.Exception ex)
            {
                Console.WriteLine("Message= {1}", ex.Message);
            }
            return false;
        }

        public DataTable TimKiemNhaCungCap(NhaCungCap nhaCC)
        {
            try
            {
                return this._NhaCungCapDAT.TimKiemNhaCungCap(nhaCC);
            }
            catch (System.Exception ex)
            {
                Console.WriteLine("Message= {1}", ex.Message);
            }
            return null;
        }

        public string GetMaCCByMaSanPham(string maSanPham)
        {
            DataTable table;
            string maNhaCC = "";
            try
            {
                table = this._NhaCungCapDAT.GetNhaCCByMaSanPham(maSanPham);

                foreach (DataRow row in table.Rows)
                {
                    maNhaCC = row["MaNhaCungCap"].ToString();  
                }

                return maNhaCC;
            }
            catch (System.Exception ex)
            {
                Console.WriteLine("Message= {1}", ex.Message);
            }
            return null;
        }

        public string GetGhiChuByMaSanPham(string maSanPham)
        {
            DataTable table;
            string ghiChuNhaCC = "";
            try
            {
                table = this._NhaCungCapDAT.GetNhaCCByMaSanPham(maSanPham);

                foreach (DataRow row in table.Rows)
                {
                    ghiChuNhaCC = row["GhiChu"].ToString();
                }

                return ghiChuNhaCC;
            }
            catch (System.Exception ex)
            {
                Console.WriteLine("Message= {1}", ex.Message);
            }
            return null;
        }
    }
}
