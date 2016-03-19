using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactorySimple
{
    class Program
    {
        static void Main(string[] args)
        {
            do
            {
                Console.WriteLine("请输入第一个数：");
                var numA = int.Parse(Console.ReadLine());
                Console.WriteLine("请输入运算符：");
                var oper = Console.ReadLine();
                Console.WriteLine("请输入第二个数：");
                var numB = int.Parse(Console.ReadLine());
                BaseCalculator calculator = new CalculatorFactory().Create(oper);
                calculator.A = numA;
                calculator.B = numB;
                Console.WriteLine(calculator.GetResult());
            } while (Console.ReadLine()!="s");
        }
    }
}
