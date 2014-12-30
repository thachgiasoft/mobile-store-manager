using DataAccessTier;
using DataTransferObject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogicTier
{
    public class ThamSoBLT
    {
        ThamSoDAT _ThamSoDAT;
        public ThamSoBLT()
        {
            _ThamSoDAT = new ThamSoDAT();
        }
        public bool SuaThamSo(ThamSo thamso)
        {
            return _ThamSoDAT.SuaThamSo(thamso);
        }

        public string LayGiaTriThamSo(ThamSo thamso)
        {
            return _ThamSoDAT.LayGiaTriThamSo(thamso);
        }
    }
}
