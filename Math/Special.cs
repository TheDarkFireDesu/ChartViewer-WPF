using System;
using System.Collections.Generic;

namespace ChartViewer
{
    public class Special
    {
        public static List<double> AbsFunction(double a, double b, double c, double d, int Length, double Step)
        {
            double y;
            List<double> data = new();

            for (double x = -1 * (Length / 2); x < Length / 2; x += Step)
            {
                // y = a * arctg(bx + c) + d
                y = a * Math.Abs(b * x + c) + d;
                data.Add(y);
            }
            return data;
        }
    }
}
