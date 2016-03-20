using System;

namespace Strategy.Impl
{
    public class CashNormal : BaseCashAccept
    {
        public override decimal GetResult(decimal money)
        {
            return money;
        }
    }
}
