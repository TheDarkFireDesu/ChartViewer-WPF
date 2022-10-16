using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChartViewer
{
    public class Trigonometric
    {
        public static List<double> SinFunction(double a, double b, double c, double d)
        {
            double y;

            List<double> data = new();

            for (int x = -30; x <= 30; x++)
            {
                // y = a * sin(bx + c) + d
                y = a * Math.Sin(b * x + c) + d;
                data.Add(y);
            }

            return data;
        }

        public static List<double> CosFunction(double a, double b, double c, double d)
        {
            double y;

            List<double> data = new();

            for (int x = -30; x <= 30; x++)
            {
                // y = a * cos(bx + c) + d
                y = a * Math.Cos(b * x + c) + d;
                data.Add(y);
            }

            return data;
        }

        public static List<double> TgFunction(double a, double b, double c, double d)
        {
            double y;

            List<double> data = new();

            for (int x = -30; x <= 30; x++)
            {
                // y = a * tg(bx + c) + d
                y = a * Math.Tan(b * x + c) + d;
                data.Add(y);
            }

            return data;
        }

        public static List<double> CtgFunction(double a, double b, double c, double d)
        {
            double y;

            List<double> data = new();

            for (int x = -30; x <= 30; x++)
            {
                // y = a * ctg(bx + c) + d
                y = 1 / (a * Math.Tan(b * x + c) + d);
                data.Add(y);
            }

            return data;
        }
    }
}
