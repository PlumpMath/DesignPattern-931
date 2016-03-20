using Strategy.Impl;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy
{
    public class CashContext
    {
        private BaseCashAccept _bs;

        public CashContext(string type)
        {
            switch (type)
            {
                case "正常收费":
                    _bs = new CashNormal();
                    break;
                case "八折":
                    _bs = new CashRebate(0.8M);
                    break;
                case "九折":
                    _bs = new CashRebate(0.9M);
                    break;
                case "300返100":
                    _bs = new CashReturn(300, 100);
                    break;
            }
        }

        public decimal AcceptCash(decimal money)
        {
            return _bs.GetResult(money);
        }
    }
}
