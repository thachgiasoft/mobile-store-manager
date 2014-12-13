using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccessTier;
using DataTransferObject;
using System.Data;

namespace BusinessLogicTier
{
    public class HoaDonDatHangBLT
    {
        private HoaDonDatHangDAT _HoaDonDatHangDAT;

        public HoaDonDatHangBLT()
        {
            _HoaDonDatHangDAT = new HoaDonDatHangDAT();
        }
        public  object ThemHoaDonDatHang(HoaDonDatHang hd)
        {
            return _HoaDonDatHangDAT.ThemHoaDonDatHang(hd);
        }

        public DataTable LayDanhSachHoaDonDatHang()
        {
            return _HoaDonDatHangDAT.LayDanhSachHoaDonDatHang();
        }

        public bool CapNhatHoaDonDatHang(HoaDonDatHang hd)
        {
            return _HoaDonDatHangDAT.CapNhatHoaDonDatHang(hd);
        }
    }
}
