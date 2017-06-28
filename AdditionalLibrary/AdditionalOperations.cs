using ReactCalc.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdditionalLibrary
{
    public class AdditionalOperations
    {
        /// <summary>
        /// Абстрактный класс "Квадратный корень"
        /// </summary>
        public class SqrtOperaion : Operation
        {
            public override long Code
            {
                get { return 5; }
            }

            public override string Desc
            {
                get { return "Квадратный корень"; }
            }

            public override string Name
            {
                get { return "Sqrt"; }
            }

            public override double Execute(double[] args)
            {
                return Math.Sqrt(args[0]);
            }
        }

        /// <summary>
        /// Абстрактный класс "Возведение в степень"
        /// </summary>
        public class SqrOperation : Operation
        {
            public override long Code
            {
                get { return 6; }
            }

            public override string Desc
            {
                get { return "Возведение в степень"; }
            }

            public override string Name
            {
                get { return "Sqr"; }
            }

            public override double Execute(double[] args)
            {
                return Math.Pow(args[0], args[1]);
            }
        }
    }
}
