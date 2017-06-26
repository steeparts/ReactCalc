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
            int x = 0;
            int y = 0;
            var calc = new Calc();

            if (args.Length > 0)
            {
                x = ToInt(args[0], 1000);
                y = ToInt(args[1], 999);
            }
            else
            {
                #region Ввод данных

                Console.Write("Введите x -> ");
                var strx = Console.ReadLine();
                x = ToInt(strx, 100);

                Console.Write("Введите y -> ");
                var stry = Console.ReadLine();
                y = ToInt(stry, 99);

                #endregion
            }

            var result = calc.Sum(x, y);

            Console.WriteLine($"Сумма = {result}");

            Console.ReadKey();                        
        }

        private static int ToInt(string arg, int def = 100)
        {
            int x;
            if (!int.TryParse(arg, out x))
            {
                x = def;
            }

            return x;
        }
    }
}
