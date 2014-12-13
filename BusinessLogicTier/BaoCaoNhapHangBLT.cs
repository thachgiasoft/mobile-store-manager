using DataAccessTier;
using DataTransferObject;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogicTier
{
    public class BaoCaoNhapHangBLT
    {
        private BaoCaoNhapHangDAT _BaoCaoNhapHangDAT;

        public BaoCaoNhapHangBLT()
        {
            _BaoCaoNhapHangDAT = new BaoCaoNhapHangDAT();
        }

        public DataTable LayChiTietBaoCao(BaoCaoNhapHang bc)
        {
            return _BaoCaoNhapHangDAT.LayChiTietBaoCao(bc);
        }
    }
}
