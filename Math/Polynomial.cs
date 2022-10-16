﻿namespace ChartViewer
{
    public class Polynomial
    {
        public static List<double> QuadraticFunction(double a, double b, double c, int Length)
        {
            double y;
            List<double> data = new();

            for (double x = -1 * (Length / 2); x < Length / 2; x++)
            {
                // y = ax^2 + bx + c
                y = a * Math.Pow(x, 2) + b * x + c;
                data.Add(y);
            }
            return data;
        }

        public static List<double> CubicFunction(double a, double b, double c, double d, int Length)
        {
            double y;
            List<double> data = new();

            for (double x = -1 * (Length / 2); x < Length / 2; x++)
            {
                // y = ax^3 + bx^2 + cx + d
                y = a * Math.Pow(x, 3) + b * Math.Pow(x,2) + c * x + d;
                data.Add(y);
            }
            return data; 
        }

        public static List<double> BiquadFunction(double a, double b, double c, int Length)
        {
            double y;
            List<double> data = new();

            for (double x = -1 * (Length / 2); x < Length / 2; x++)
            {
                // y = ax^4 + bx^2 + с
                y = a * Math.Pow(x, 4) + b * Math.Pow(x, 2) + c;
                data.Add(y);
            }
            return data;
        }
    }
}
