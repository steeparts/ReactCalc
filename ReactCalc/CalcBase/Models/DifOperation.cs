using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReactCalc.Models
{
    public class DifOperation : Operation
    {
        public override long Code
        {
            get { return 2; }
        }

        public override string Desc
        {
            get { return "Разность"; }
        }

        public override string Name
        {
            get { return "Dif"; }
        }

        public override double Execute(double[] args)
        {
            double result = args[0];
            for (int i = 1; i < args.Length; i++)
                result -= args[i];

            return result;
        }
    }
}
