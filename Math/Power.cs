using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChartViewer
{
    public class Power
    {
        public static List<double> PowFunction(double a, double b, double c, int Length, double Step)
        {
            double y;
            List<double> data = new();

            for (double x = -1 * (Length / 2); x < Length / 2; x += Step)
            {
                // y = a * x^b + c
                y = a * Math.Pow(x, b) + c;
                data.Add(y);
            }

            return data;
        }
    }
}
