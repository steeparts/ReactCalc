using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReactCalc.Models
{
    public class DivOperation : Operation
    {
        public override long Code
        {
            get { return 4; }
        }

        public override string Desc
        {
            get { return "Частное"; }
        }

        public override string Name
        {
            get { return "Div"; }
        }

        public override double Execute(double[] args)
        {
            double result = args[0];
            try
            {
                for (int i = 1; i < args.Length; i++)
                    result /= args[i];
            }
            catch(DivideByZeroException ex)
            {
                Console.WriteLine(ex.Message);
            }

            return result;
        }
    }
}
