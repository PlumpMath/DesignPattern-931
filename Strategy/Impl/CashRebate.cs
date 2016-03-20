using System;
namespace Strategy.Impl
{
    public class CashRebate : BaseCashAccept
    {
        private decimal _rebate;

        public CashRebate(decimal rebate)
        {
            this._rebate = rebate;
        }

        public override decimal GetResult(decimal money)
        {
            return money * _rebate;
        }
    }
}
