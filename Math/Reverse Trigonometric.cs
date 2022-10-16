using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChartViewer
{
    public class Reverse_Trigonometric
    {
        public static List<double> ArcTgFunction(double a, double b, double c, double d)
        {
            double y;

            List<double> data = new();

            for (int x = -30; x <= 30; x++)
            {
                // y = a * tg(bx + c) + d
                y = a * Math.Atan(b * x + c) + d;
                data.Add(y);
            }

            return data;
        }
    }
}
