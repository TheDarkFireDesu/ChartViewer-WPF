using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChartViewer
{
    public class Basic
    {
        public static List<double> LinearFunction(double a, double b, int Length)
        {
            
            double y;
            List<double> data = new();

            for (double x = -1 * (Length / 2); x < Length / 2; x++)
            {
                y = a * x + b;
                data.Add(y);
            }
            return data;
        }
    }
}
