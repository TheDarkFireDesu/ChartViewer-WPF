using System;
using System.Collections.Generic;

namespace ChartViewer
{
    public class Exponential
    {

        public static List<double> ExponentFunction(double a, double b, int Length, double Step)
        {
            double y;

            List<double> data = new();

            for (double x = -1 * (Length / 2); x < Length / 2; x += Step)
            {
                // y = a * e^x + b;
                y = a * Math.Exp(x) + b;
                data.Add(y);
            }

            return data;
        }

        public static List<double> ExponentcialFunction(double a, double b, double c, int Length, double Step)
        {
            double y;

            List<double> data = new();

            for (double x = -1 * (Length / 2); x < Length / 2; x += Step)
            {
                // y = a * b^x + c
                y = a * Math.Pow(b, x) + c;
                data.Add(y);
            }

            return data;
        }
    }
}
