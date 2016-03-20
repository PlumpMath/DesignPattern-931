using Strategy.Impl;

namespace Strategy
{
    public class CashAcceptFactory
    {
        public BaseCashAccept Create(string oper)
        {
            switch (oper)
            {
                case "正常收费":
                    return new CashNormal();
                case "八折":
                    return new CashRebate(0.8M);
                case "九折":
                    return new CashRebate(0.9M);
                case "300返100":
                    return new CashReturn(300, 100);
                default: return null;
            }
        }

    }
}
