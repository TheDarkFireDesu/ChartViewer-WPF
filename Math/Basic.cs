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
        public static List<double> LinearFunction(double a, double b)
        {
            double y;

            List<double> data = new();

            for (int x = -30; x < 30; x++)
            {
                y = a * x + b;
                data.Add(y);
            }

            return data;
        }
    }
}
