using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccessTier;
using System.Data;
using DataTransferObject;
using System.Xml.Linq;

namespace BusinessLogicTier
{
    public class KhuyenMaiBLT
    {
         private KhuyenMaiDAT khuyenMaiDAT;

         public KhuyenMaiBLT()
        {
            this.khuyenMaiDAT = new KhuyenMaiDAT();
        }

        public DataTable LayDanhSachCTKhuyenMai()
        {
            DataTable data = new DataTable();
            try
            {
                data = this.khuyenMaiDAT.LayDanhSachCTKhuyenMai();          
                return data;
            }
            catch (System.Exception ex)
            {
                Console.WriteLine("Message= {1}", ex.Message);
            }
            return null;
        }

        public DataTable LayDanhSachChiTietKhuyenMai()
        {
            DataTable data = new DataTable();
            try
            {
                data = this.khuyenMaiDAT.LayDanhSachChiTietKhuyenMai();
                return data;
            }
            catch (System.Exception ex)
            {
                Console.WriteLine("Message= {1}", ex.Message);
            }
            return null;
        }


        public bool ThemCTKhuyenMai(KhuyenMai km, XElement xml)
        {
            try
            {
                return this.khuyenMaiDAT.ThemCTKhuyenMai(km, xml);
            }
            catch (System.Exception ex)
            {
                Console.WriteLine("Message= {1}", ex.Message);
            }
            return false;
        }

        public bool CapNhatCTKhuyenMai(KhuyenMai km, XElement xml)
        {

            try
            {
                return this.khuyenMaiDAT.CapNhatCTKhuyenMai(km, xml);
            }
            catch (System.Exception ex)
            {
                Console.WriteLine("Message= {1}", ex.Message);
            }
            return false;
        }

        public bool CapNhatCTSoLuongKhuyenMai(CTKHuyenMai km)
        {
            try
            {
                return this.khuyenMaiDAT.CapNhatCTSoLuongKhuyenMai(km);
            }
            catch (System.Exception ex)
            {
                Console.WriteLine("Message= {1}", ex.Message);
            }
            return false;
        }

        public bool XoaCTKhuyenMai(String maKhuyenMai)
        {

            try
            {
                return this.khuyenMaiDAT.XoaCTKhuyenMai(maKhuyenMai);
            }
            catch (System.Exception ex)
            {
                Console.WriteLine("Message= {1}", ex.Message);
            }
            return false;
        }

        public DataTable TimKiemCTKhuyenMai(KhuyenMai km)
        {
            try
            {
                return this.khuyenMaiDAT.TimKiemCTKhuyenMai(km);
            }
            catch (System.Exception ex)
            {
                Console.WriteLine("Message= {1}", ex.Message);
            }
            return null;
        }
        public DataTable TimKiemChiTietCTKhuyenMai(CTKHuyenMai km)
        {
            try
            {
                return this.khuyenMaiDAT.TimKiemChiTietKhuyenMai(km);
            }
            catch (System.Exception ex)
            {
                Console.WriteLine("Message= {1}", ex.Message);
            }
            return null;
        }

    }
}
