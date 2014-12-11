using DataAccessTier;
using DataTransferObject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogicTier
{
    public class ChiTietHoaDonNhapHangBLT
    {
        ChiTietHoaDonNhapHangDAT _ChiTietHoaDonNhapHangDAT;
        public ChiTietHoaDonNhapHangBLT()
        {
            _ChiTietHoaDonNhapHangDAT = new ChiTietHoaDonNhapHangDAT();
        }

        public bool ThemChiTietHoaDonNhapHang(ChiTietHoaDonNhapHang cthd)
        {
            return _ChiTietHoaDonNhapHangDAT.ThemChiTietHoaDonNhapHang(cthd);
        }
    }
}
