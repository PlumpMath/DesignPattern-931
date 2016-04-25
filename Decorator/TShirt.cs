using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator
{
    public class TShirt : Clothing
    {
        public override void Show()
        {
            Console.WriteLine("T恤");
            base.Show();
        }

    }
}
