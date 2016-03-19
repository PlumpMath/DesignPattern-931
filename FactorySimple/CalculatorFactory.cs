using FactorySimple.Impl;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactorySimple
{
    public class CalculatorFactory
    {
        public BaseCalculator Create(string oper)
        {
            switch (oper)
            {
                case "+":return new AddCalculator();
                case "-":return new SubCalculator();
                default: return null;
            }
        }
    }
}
