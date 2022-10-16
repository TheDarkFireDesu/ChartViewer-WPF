using System;
using System.Collections.Generic;

namespace ChartViewer
{
    public class Polynomial
    {
        public static List<double> QuadraticFunction(double a, double b, double c)
        {
            double y;

            List<double> data = new();

            for (int x = -30; x < 30; x++)
            {
                // y = ax^2 + bx + c
                y = a * Math.Pow(x, 2) + b * x + c;
                data.Add(y);
            }
            return data;
        }

        public static List<double> CubicFunction(double a, double b, double c, double d)
        {
            double y;

            List<double> data = new();

            for (int x = -30; x < 30; x++)
            {
                // y = ax^3 + bx^2 + cx + d
                y = a * Math.Pow(x, 3) + b * Math.Pow(x,2) + c * x + d;
                data.Add(y);
            }
            return data; 
        }

        public static List<double> BiquadFunction(double a, double b, double c)
        {
            double y;

            List<double> data = new();

            for (int x = -30; x < 30; x++)
            {
                // y = ax^4 + bx^2 + с
                y = a * Math.Pow(x, 4) + b * Math.Pow(x, 2) + c;
                data.Add(y);
            }
            return data;
        }
    }
}
