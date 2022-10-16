using System;
using System.Collections.Generic;

namespace ChartViewer
{
    public class Logarithmic
    {
        public static List<double> LogFunction(double a, double b, double c, int Length, double Step)
        {
            double y;
            List<double> data = new();

            for (double x = -1 * (Length / 2); x < Length / 2; x += Step)
            {
                // y = log(a)x
                y = (a * Math.Log(b, x)) + c;
                data.Add(y);
            }
            return data;
        }

        public static List<double> LogDecimalFunction(double a, double c, int Length, double Step)
        {
            double y;
            List<double> data = new();

            for (double x = -1 * (Length / 2); x < Length / 2; x += Step)
            {
                // y = log10x
                y = (a * Math.Log10(x)) + c;
                data.Add(y);
            }
            return data;
        }

        public static List<double> LogNaturalFunction(double a, double c, int Length, double Step)
        {
            double y;
            List<double> data = new();

            for (double x = -1 * (Length / 2); x < Length / 2; x += Step)
            {
                // y = lnx
                y = (a * Math.Log(x)) + c;
                data.Add(y);
            }
            return data;
        }
    }
}
