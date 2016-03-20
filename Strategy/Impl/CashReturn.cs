using System;

namespace Strategy.Impl
{
    public class CashReturn : BaseCashAccept
    {
        decimal _moneyCondition;
        decimal _moneyReturn;

        public CashReturn(decimal moneyCondition, decimal moneyReturn)
        {
            _moneyCondition = moneyCondition;
            _moneyReturn = moneyReturn;
        }

        public override decimal GetResult(decimal money)
        {
            if (money >= _moneyCondition)
            {
                money -= _moneyReturn;
            }
            return money;
        }
    }
}
