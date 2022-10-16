using System;
using System.Collections.Generic;

namespace ChartViewer
{
    public class Trigonometric
    {
        public static List<double> SinFunction(double a, double b, double c, double d, int Length, double Step)
        {
            double y;
            List<double> data = new();

            for (double x = -1 * (Length / 2); x < Length / 2; x += Step)
            {
                // y = a * sin(bx + c) + d
                y = a * Math.Sin(b * x + c) + d;
                data.Add(y);
            }
            return data;
        }

        public static List<double> CosFunction(double a, double b, double c, double d, int Length, double Step)
        {
            double y;
            List<double> data = new();

            for (double x = -1 * (Length / 2); x < Length / 2; x += Step)
            {
                // y = a * cos(bx + c) + d
                y = a * Math.Cos(b * x + c) + d;
                data.Add(y);
            }
            return data;
        }

        public static List<double> TgFunction(double a, double b, double c, double d, int Length, double Step)
        {
            double y;
            List<double> data = new();

            for (double x = -1 * (Length / 2); x < Length / 2; x += Step)
            {
                // y = a * tg(bx + c) + d
                y = a * Math.Tan(b * x + c) + d;
                data.Add(y);
            }
            return data;
        }

        public static List<double> CtgFunction(double a, double b, double c, double d, int Length, double Step)
        {
            double y;

            List<double> data = new();

            for (double x = -1 * (Length / 2); x < Length / 2; x += Step)
            {
                // y = a * ctg(bx + c) + d
                y = 1 / (a * Math.Tan(b * x + c) + d);
                data.Add(y);
            }
            return data;
        }

        public static List<double> SecFunction(double a, double b, double c, double d, int Length, double Step)
        {
            double y;
            List<double> data = new();

            for (double x = -1 * (Length / 2); x < Length / 2; x += Step)
            {
                // y = a * sec(bx + c) + d
                y = 1 / (a * Math.Cos(b * x + c) + d);
                data.Add(y);
            }
            return data;
        }

        public static List<double> CscFunction(double a, double b, double c, double d, int Length, double Step)
        {
            double y;
            List<double> data = new();

            for (double x = -1 * (Length / 2); x < Length / 2; x += Step)
            {
                // y = a * Csc(bx + c) + d
                y = 1 / (a * Math.Sin(b * x + c) + d);
                data.Add(y);
            }
            return data;
        }
    }
}
