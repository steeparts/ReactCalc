using ReactCalc.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactorialLibrary
{
    public class FactorialOperation : Operation
    {
        public override long Code
        {
            get { return 7; }
        }

        public override string Desc
        {
            get { return "Факториал"; }
        }

        public override string Name
        {
            get { return "Fact"; }
        }

        public override double Execute(double[] args)
        {
            var x = args[0];
            var count = 1d;
            var result = 1d;

            while (count <= x)
                result *= count++;

            return result;
        }
    }
}
