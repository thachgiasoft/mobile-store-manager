using DataTransferObject;
using DataAccessTier;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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

        public bool ThemhoaDon(ChiTietHoaDonBan hoaDon)
        {
            try
            {
                return this.hoaDonDAT.ThemHoaDon(hoaDon);
            }
            catch (System.Exception ex)
            {
                Console.WriteLine("Message= {1}", ex.Message);
            }
            return false;
        }

        public bool CapNhathoaDon(ChiTietHoaDonBan hoaDon)
        {
            try
            {
                return this.hoaDonDAT.CapNhatHoaDon(hoaDon);
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

        public DataTable TimKiemhoaDon(ChiTietHoaDonBan hoaDon)
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
    }
}
