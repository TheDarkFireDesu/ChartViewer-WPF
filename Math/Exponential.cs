using System;
using System.Collections.Generic;

namespace ChartViewer
{
    public class Exponential
    {

        public static List<double> ExponentFunction()
        {
            double y;

            List<double> data = new();

            for (int x = -30; x <= 30; x++)
            {
                // y = e^x
                y = Math.Exp(x);
                data.Add(y);
            }

            return data;
        }

        public static List<double> ExponentcialFunction(double a)
        {
            double y;

            List<double> data = new();

            for (int x = -30; x <= 30; x++)
            {
                // y = a^x
                y = Math.Pow(a, x);
                data.Add(y);
            }

            return data;
        }
    }
}
