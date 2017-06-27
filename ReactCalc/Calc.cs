using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReactCalc
{
    /// <summary>
    /// Калькулятор
    /// </summary>
    class Calc
    {
        /// <summary>
        /// Сумма
        /// </summary>
        /// <param name="x">Слагаемое</param>
        /// <param name="y">Слагаемое</param>
        /// <returns>Вещественное число</returns>
        public double Sum(double x, double y)
        {
            return x + y;
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
