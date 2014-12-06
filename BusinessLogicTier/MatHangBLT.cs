using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccessTier;
using System.Data;

namespace BusinessLogicTier
{
    public class MatHangBLT
    {
        MatHangDAT _MatHangDAT;
        public MatHangBLT() {
            _MatHangDAT = new MatHangDAT();
        }

        public DataTable LayDanhSachTenMatHangTheoNhaCungCap(string  MaNhaCungCap, int SoLuongToiThieu)
        {
            return _MatHangDAT.LayDanhSachTenMatHangTheoNhaCungCap(MaNhaCungCap, SoLuongToiThieu);
        }
    }
}
