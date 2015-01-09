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
    public class DonGiaBLT
    {
         private DonGiaDAT donGiaDAT;

         public DonGiaBLT()
        {
            this.donGiaDAT = new DonGiaDAT();
        }

         public DataTable LayDanhSachDonGia()
        {
            DataTable data = new DataTable();
            try
            {
                data = this.donGiaDAT.LayDanhSachDonGia();
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

         public bool ThemDonGia(DonGia donGia)
        {
            try
            {
                return this.donGiaDAT.ThemDonGia(donGia);
            }
            catch (System.Exception ex)
            {
                Console.WriteLine("Message= {1}", ex.Message);
            }
            return false;
        }

         public bool CapNhatDonGia(DonGia donGia)
        {

            try
            {
                return this.donGiaDAT.CapNhatDonGia(donGia);
            }
            catch (System.Exception ex)
            {
                Console.WriteLine("Message= {1}", ex.Message);
            }
            return false;
        }

         public bool XoaDonGia(String maDonGia)
        {

            try
            {
                return this.donGiaDAT.XoaDonGia(maDonGia);
            }
            catch (System.Exception ex)
            {
                Console.WriteLine("Message= {1}", ex.Message);
            }
            return false;
        }

         public DataTable TimKiemDonGia(DonGia donGia)
        {
            try
            {
                return this.donGiaDAT.TimKiemDonGia(donGia);
            }
            catch (System.Exception ex)
            {
                Console.WriteLine("Message= {1}", ex.Message);
            }
            return null;
        }

         public DonGia LayDonGiaBangMaSanPham(string maSP)
         {
             DonGia donGia = new DonGia();
             DataTable table;

             try
             {
                 table = this.donGiaDAT.LayDonGiaBangMaSanPham(maSP);

                 foreach (DataRow row in table.Rows)
                 {
                     donGia.MaDonGia = row["MaDonGia"].ToString();
                     donGia.GiaNhap = Convert.ToDecimal(row["GiaNhap"].ToString());
                     donGia.GiaXuat = Convert.ToDecimal(row["GiaXuat"].ToString());
                    
                 }

                 return donGia;
             }
             catch (System.Exception ex)
             {
                 Console.WriteLine("Message= {1}", ex.Message);
             }
             return null;
         }

         public DataTable LayMaDonGiaBangMaSanPham(DonGia dongia)
         {
             try
             {
                 return this.donGiaDAT.LayMaDonGiaBangMaSanPham(dongia);
             }
             catch (System.Exception ex)
             {
                 Console.WriteLine("Message= {1}", ex.Message);
             }
             return null;
         }

         public string ThemDonGiaVaLayMaDonGia(DonGia dongia)
         {
             try
             {
                 return this.donGiaDAT.ThemDonGiaVaLayMaDonGia(dongia);
             }
             catch (System.Exception ex)
             {
                 Console.WriteLine("Message= {1}", ex.Message);
             }
             return null;
         }
    }
}
