using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ReactCalc.Models;
using FactorialLibrary;
using System.Reflection;
using System.IO;

namespace ReactCalc
{
    /// <summary>
    /// Калькулятор
    /// </summary>
    public class Calc
    {
        public Calc()
        {
            Operations = new List<IOperation>();
            Operations.Add(new SumOperation());

            var dllName = Directory.GetCurrentDirectory() + "\\FactorialLibrary.dll";
            if (!File.Exists(dllName))
                return;

            // загружаем сборку
            var assembly = Assembly.LoadFrom(dllName);
            // получаем все типы/классы из нее
            var types = assembly.GetTypes();
            // перебираем типы
            foreach (var t in types)
            {
                // находим тех, кто реализует интерфейс IOperation
                var interfs = t.GetInterfaces();
                if (interfs.Contains(typeof(IOperation)))
                {
                    // создаем экземпляр найденного класса
                    var instance = Activator.CreateInstance(t) as IOperation;
                    if (instance != null)
                    {
                        // добавляем его в наш список операций
                        Operations.Add(instance);
                    }
                }
            }
        }

        public IList<IOperation> Operations { get; private set; }

        private double Execute(Func<IOperation, bool> selector, double[] args)
        {
            // находим операцию по имени
            IOperation oper = Operations.FirstOrDefault(selector);

            if (oper != null)
            {
                // вычисляем результат
                var result = oper.Execute(args);

                // отдаем пользователю
                return result;
            }

            throw new Exception("Не найдена запрашиваемая операция!");
        }

        public double Execute(string name, double[] args)
        {
            return Execute(i => i.Name == name, args);
        }

        public double Execute(long code, double[] args)
        {
            return Execute(i => i.Code == code, args);
        }

        public double Execute(Func<double[], double> f, double[] args)
        {
            return f(args);
        }






        /// <summary>
        /// Сумма
        /// </summary>
        /// <param name="x">Слагаемое</param>
        /// <param name="y">Слагаемое</param>
        /// <returns>Вещественное число</returns>
        [Obsolete("Используйте Execute('Sum', new[] { x, y }). Данная функция будет удалена в версии 4.0")]
        public double Sum(double x, double y)
        {
            return Execute("Sum", new[] { x, y });
        }

        /// <summary>
        /// Разность
        /// </summary>
        /// <param name="x">Уменьшаемое</param>
        /// <param name="y">Вычитаемое</param>
        /// <returns>Вещественное число</returns>
        public double Dif(double x, double y)
        {
            return x - y;
        }

        /// <summary>
        /// Произведение</summary>
        /// <param name="x">Множимое</param>
        /// <param name="y">Множитель</param>
        /// <returns>Вещественное число</returns>
        public double Mul(double x, double y)
        {
            return x * y;
        }

        /// <summary>
        /// Частное
        /// </summary>
        /// <param name="x">Делимое</param>
        /// <param name="y">Делитель</param>
        /// <returns>Вещественное число</returns>
        public double Div(double x, double y)
        {
            return x / y;
        }

        /// <summary>
        /// Квадратный корень
        /// </summary>
        /// <param name="x">Неотрицательное число</param>
        /// <returns>Вещественное число</returns>
        public double Sqrt(double x)
        {
            return Math.Sqrt(x);
        }

        /// <summary>
        /// Кубический корень
        /// </summary>
        /// <param name="x">Число</param>
        /// <returns>Вещественное число</returns>
        public double CRoot(double x)
        {
            return Math.Pow(x, 1.0 / 3);
        }
    }
}
