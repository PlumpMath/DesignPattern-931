using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator
{
    class Program
    {
        static void Main(string[] args)
        {
            Person p = new Person("吴泡泡");
            TShirt t = new TShirt();
            Shoes s = new Shoes();
            s.Decorate(p);
            t.Decorate(s);
            t.Show();
            Console.Read();

        }
    }
}
