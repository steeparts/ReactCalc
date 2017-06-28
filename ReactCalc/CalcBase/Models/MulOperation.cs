using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReactCalc.Models
{
    public class MulOperation : Operation
    {
        public override long Code
        {
            get { return 3; }
        }

        public override string Desc
        {
            get { return "Произведение"; }
        }

        public override string Name
        {
            get { return "Mul"; }
        }

        public override double Execute(double[] args)
        {
            double result = 1.0;
            foreach (double x in args)
                result *= x;

            return result;
        }
    }
}
