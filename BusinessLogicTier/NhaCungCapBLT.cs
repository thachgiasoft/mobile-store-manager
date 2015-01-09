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

        public string LayMaCCBangMaSanPham(string maSanPham)
        {
            DataTable table;
            string maNhaCC = "";
            try
            {
                table = this._NhaCungCapDAT.LayMaCCBangMaSanPham(maSanPham);

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

        public string LayGhiChuBangMaSanPham(string maSanPham)
        {
            DataTable table;
            string ghiChuNhaCC = "";
            try
            {
                table = this._NhaCungCapDAT.LayMaCCBangMaSanPham(maSanPham);

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

        public string LayMaNhaCCBangTenNhaCungCap(string tenNhaCungCap)
        {
            DataTable table;
            try
            {
                table = this._NhaCungCapDAT.LayMaNhaCCBangTenNhaCungCap(tenNhaCungCap);
                if (table != null && table.Rows.Count > 0)
                    return table.Rows[0].ItemArray[0].ToString();
            }
            catch (System.Exception ex)
            {
                Console.WriteLine("Message= {1}", ex.Message);
            }
            return null;
        }

        public bool XoaChiTietNhaCungCap(string mamathang)
       {
            try
            {
                return this._NhaCungCapDAT.XoaChiTietNhaCungCap(mamathang);
            }
            catch (System.Exception ex)
            {
                Console.WriteLine("Message= {1}", ex.Message);
            }
            return false;
       }

       public bool ThemChiTietNhaCungCap(ChiTietNhaCungCap ncc)
        {
            try
            {
                return this._NhaCungCapDAT.ThemChiTietNhaCungCap(ncc);
            }
            catch (System.Exception ex)
            {
                Console.WriteLine("Message= {1}", ex.Message);
            }
            return false;
        }
    }
}
