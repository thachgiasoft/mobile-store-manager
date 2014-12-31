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
    public class LoaiMatHangBLT
    {
         private LoaiMatHangDAT loaiMHDAT;

         public LoaiMatHangBLT()
        {
            this.loaiMHDAT = new LoaiMatHangDAT();
        }
         public string LayMaLoaiMatHang(string tenloaiMH)
         {
             try
             {
                 return this.loaiMHDAT.LayMaLoaiMatHang(tenloaiMH);
             }
             catch (System.Exception ex)
             {
                 Console.WriteLine("Message= {1}", ex.Message);
             }

             return null;
         }

         public DataTable LoadComBoBox()
         {
             try
             {
                 return this.loaiMHDAT.LoadComboBox();
             }
             catch (System.Exception ex)
             {
                 Console.WriteLine("Message= {1}", ex.Message);
             }
             return null;
         }

         public DataTable LayDanhSachLoaiMatHang()
        {
            DataTable data = new DataTable();
            try
            {
                data = this.loaiMHDAT.LayDanhSachLoaiMatHang();
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

         public bool ThemLoaiMatHang(LoaiMatHang loaiMH)
        {
            try
            {
                return this.loaiMHDAT.ThemLoaiMatHang(loaiMH);
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
                return this.loaiMHDAT.CapNhatLoaiMatHang(loaiMH);
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
                return this.loaiMHDAT.XoaLoaiMatHang(maLoaiMH);
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
                return this.loaiMHDAT.TimKiemLoaiMatHang(loaiMH);
            }
            catch (System.Exception ex)
            {
                Console.WriteLine("Message= {1}", ex.Message);
            }
            return null;
        }
    }
}
