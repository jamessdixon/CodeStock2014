using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tff.VarianceCalculator.CS
{
    public class Calculations
    {
        //http://www.codeproject.com/Articles/42492/Using-LINQ-to-Calculate-Basic-Statistics
        public static Double Variance(IEnumerable<Double> source)
        {
            int n = 0;
            double mean = 0;
            double M2 = 0;

            foreach (double x in source)
            {
                n = n + 1;
                double delta = x - mean;
                mean = mean + delta / n;
                M2 += delta * (x-mean);
            }
            return M2 / (n-1);
        }
    }
}