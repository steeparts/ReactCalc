using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReactCalc
{
    class Program
    {
        static void Main(string[] args)
        {

            var c = new Calc(1);
            //c.X = 1;
            Calc.Y = 1;
            Console.WriteLine(c.s);

            var d = new Calc(2);
            //Calc.Y = 2;
            //d.X = 2;
            Console.WriteLine(d.s);

            Console.ReadKey();

        }
    }
}
