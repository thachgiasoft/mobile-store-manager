using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccessTier;
using DataTransferObject;

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
    }
}
