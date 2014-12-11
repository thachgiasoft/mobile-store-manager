using DataAccessTier;
using DataTransferObject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogicTier
{
    public class HoaDonNhapHangBLT
    {
        HoaDonNhapHangDAT _HoaDonNhapHangDAT;

        public HoaDonNhapHangBLT()
        {
            _HoaDonNhapHangDAT = new HoaDonNhapHangDAT();
        }
        public object ThemHoaDonNhapHang(HoaDonNhapHang hd)
        {
            return _HoaDonNhapHangDAT.ThemHoaDonNhapHang(hd);
        }
    }
}
