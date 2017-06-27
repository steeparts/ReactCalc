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
            double x = 0;
            double y = 0;
            var calc = new Calc();

            if (args.Length > 0)
            {
                x = ToDouble(args[0], 1000);
                y = ToDouble(args[1], 999);
            }
            else
            {
                #region Ввод данных

                Console.Write("Введите x -> ");
                var strx = Console.ReadLine();
                x = ToDouble(strx, 100);

                Console.Write("Введите y -> ");
                var stry = Console.ReadLine();
                y = ToDouble(stry, 99);

                #endregion
            }

            int c = -1;
            do
            {
                Console.WriteLine("1. Сумма (x + y)");
                Console.WriteLine("2. Разность (x - y)");
                Console.WriteLine("3. Произведение (x * y)");
                Console.WriteLine("4. Частное (x / y)");
                Console.WriteLine("4. Квадратный корень Sqrt(x)");
                Console.WriteLine("4. Кубический корень Croot(x)");
                Console.WriteLine("0. Выход");
                Console.Write("-> ");
                var strc = Console.ReadLine();

                if (!int.TryParse(strc, out c))
                    c = 0;

                switch (c)
                {
                    case 0: break;
                    case 1: Console.WriteLine($"{x} + {y} = {calc.Sum(x, y)}"); break;
                    case 2: Console.WriteLine($"{x} - {y} = {calc.Dif(x, y)}"); break;
                    case 3: Console.WriteLine($"{x} * {y} = {calc.Mul(x, y)}"); break;
                    case 4:
                        {
                            if (y != 0)
                                Console.WriteLine($"{x} / {y} = {calc.Div(x, y)}");
                            else
                                Console.WriteLine($"{x} / {y} = Ошибка деления на ноль");
                        }; break;
                    case 5: Console.WriteLine($"Sqrt({x}) = {calc.Sqrt(x)}"); break;
                    case 6: Console.WriteLine($"Croot({x}) = {calc.CRoot(x)}"); break;
                }
            } while (c != 0);           
        }

        private static double ToDouble(string arg, double def = 100.0)
        {
            double x;
            if (!double.TryParse(arg, out x))
            {
                x = def;
            }

            return x;
        }
    }
}
