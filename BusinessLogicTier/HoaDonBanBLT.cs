using DataTransferObject;
using DataAccessTier;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace BusinessLogicTier
{
   public class HoaDonBanBLT
    {
        private HoaDonBanDAT hoaDonDAT;

        public HoaDonBanBLT()
        {
            this.hoaDonDAT = new HoaDonBanDAT();
        }

        public DataTable LayDanhSachhoaDon()
        {         
            try
            {
                return this.hoaDonDAT.LayDanhSachHoaDon();
            }
            catch (System.Exception ex)
            {
                Console.WriteLine("Message= {1}", ex.Message);
            }
            return null;
        }

        public DataTable LayDanhSachKhachHang()
        {
            try
            {
                return this.hoaDonDAT.LayDanhSachKhachHang();
            }
            catch (System.Exception ex)
            {
                Console.WriteLine("Message= {1}", ex.Message);
            }
            return null;
        }

        public DataTable LayDanhSachTrangThai()
        {
            try
            {
                return this.hoaDonDAT.LayDanhSachTrangThai();
            }
            catch (System.Exception ex)
            {
                Console.WriteLine("Message= {1}", ex.Message);
            }
            return null;
        }

        public bool ThemhoaDon(HoaDonBan hoaDon, XElement xml)
        {
            try
            {
                return this.hoaDonDAT.ThemHoaDon(hoaDon, xml);
            }
            catch (System.Exception ex)
            {
                Console.WriteLine("Message= {1}", ex.Message);
            }
            return false;
        }

        public bool CapNhathoaDon(HoaDonBan hoaDon, XElement xml)
        {
            try
            {
                return this.hoaDonDAT.CapNhatHoaDon(hoaDon, xml);
            }
            catch (System.Exception ex)
            {
                Console.WriteLine("Message= {1}", ex.Message);
            }
            return false;
        }

        public bool XoahoaDon(String mahoaDon)
        {
            try
            {
                return this.hoaDonDAT.XoaHoaDon(mahoaDon);
            }
            catch (System.Exception ex)
            {
                Console.WriteLine("Message= {1}", ex.Message);
            }
            return false;
        }

        public DataTable TimKiemhoaDon(HoaDonBan hoaDon)
        {
            try
            {
                return this.hoaDonDAT.TimKiemHoaDon(hoaDon);
            }
            catch (System.Exception ex)
            {
                Console.WriteLine("Message= {1}", ex.Message);
            }
            return null;
        }

        public DataTable TimKiemCThoaDon(HoaDonBan hoaDon)
        {
            try
            {
                return this.hoaDonDAT.TimKiemCTHoaDon(hoaDon);
            }
            catch (System.Exception ex)
            {
                Console.WriteLine("Message= {1}", ex.Message);
            }
            return null;
        }
    }
}
