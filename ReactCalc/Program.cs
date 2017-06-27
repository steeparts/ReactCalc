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
            var oper = "Sum";

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

            Console.WriteLine("Сумма Sum");
            Console.WriteLine("Разность Dif");
            Console.WriteLine("Произведение Mul");
            Console.WriteLine("Частное Div");
            Console.WriteLine("Квадратный корень Sqrt");
            Console.WriteLine("Кубический корень Croot");
            Console.Write("-> ");
            oper = Console.ReadLine();

            try
            {
                var result = calc.Execute(oper, new[] { x, y });
                Console.WriteLine($"{oper}({x}, {y}) = {result}");
            }
            catch(NotSupportedException ex)
            {
                Console.WriteLine(ex.Message);
            }

            //switch (c)
            //{
            //    case 0: break;
            //    case 1: Console.WriteLine($"{x} + {y} = {calc.Sum(x, y)}"); break;
            //    case 2: Console.WriteLine($"{x} - {y} = {calc.Dif(x, y)}"); break;
            //    case 3: Console.WriteLine($"{x} * {y} = {calc.Mul(x, y)}"); break;
            //    case 4:
            //        {
            //            if (y != 0)
            //                Console.WriteLine($"{x} / {y} = {calc.Div(x, y)}");
            //            else
            //                Console.WriteLine($"{x} / {y} = Ошибка деления на ноль");
            //        }; break;
            //    case 5: Console.WriteLine($"Sqrt({x}) = {calc.Sqrt(x)}"); break;
            //    case 6: Console.WriteLine($"Croot({x}) = {calc.CRoot(x)}"); break;
            //}

            Console.ReadKey();
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
