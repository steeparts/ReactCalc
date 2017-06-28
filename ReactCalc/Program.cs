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

            while(true)
            {
                Console.WriteLine("1. Сумма Sum");
                Console.WriteLine("2. Разность Dif");
                Console.WriteLine("3. Произведение Mul");
                Console.WriteLine("4. Частное Div");
                Console.WriteLine("5. Квадратный корень Sqrt");
                Console.WriteLine("6. Возведение в степень Sqr");
                Console.WriteLine("7. Факториал Fact");
                Console.WriteLine("0. Выход Exit");
                Console.Write("-> ");
                oper = Console.ReadLine();

                if (oper == "Exit")
                    return;

                try
                {
                    var result = calc.Execute(oper, new[] { x, y });

                    var oper_desc = "";
                    foreach (var o in calc.Operations)
                        if (o.Name == oper)
                            oper_desc = o.Desc;

                    switch (oper)
                    {
                        case "Sum":
                        case "Dif":
                        case "Mul":
                        case "Div":
                        case "Sqr": Console.WriteLine($"{oper_desc}({x}, {y}) = {result}"); break;
                        case "Sqrt":
                        case "Fact": Console.WriteLine($"{oper_desc}({x}) = {result}"); break;
                        case "Exit": break;
                        default: Console.WriteLine("Ошибка"); break;
                    }
                }
                catch (NotSupportedException ex)
                {
                    Console.WriteLine(ex.Message);
                }

                Console.WriteLine();

            }
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
