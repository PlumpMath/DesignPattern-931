using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactorySimple.Impl
{
    public class AddCalculator : BaseCalculator
    {
        public override int GetResult()
        {
            return A + B;
        }
    }
}
