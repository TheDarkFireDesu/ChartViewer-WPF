using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChartViewer
{
    public class Power
    {
        public static List<double> PowFunction(double a, double b, double c)
        {
            double y;

            List<double> data = new();

            for (int x = -30; x <= 30; x++)
            {
                // y = x^a
                y = a * Math.Pow(x, b) + c;
                data.Add(y);
            }

            return data;
        }
    }
}
