using LiveChartsCore.SkiaSharpView;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChartViewer
{
    public class FuncGraphCalc
    {
        public static LineSeries<double> GetLineSeries(double[] data_array)
        {
            LineSeries<double> lineSeries = new()
            {
                Fill = null,
                Values = data_array
            };

            return lineSeries;
        }

        public static List<double> LinearFunction(double a, double b, int num_of_x)
        {
            double y;

            List<double> data = new(num_of_x);

            for (int x = -num_of_x / 2; x <= num_of_x / 2; x++)
            {
                y = a * x + b;
                data.Add(y);
            }

            return data;
        }

        public static List<double> QuadraticFunction(double a, double b, double c, int num_of_x)
        {
            double y;

            List<double> data = new(num_of_x);

            for (int x = -num_of_x / 2; x <= num_of_x / 2; x++)
            {
                // y = ax^2 + bx + c
                y = a * Math.Pow(x, 2) + b * x + c;
                data.Add(y);
            }

            return data;
        }

        public static List<double> ExponentFunction(int num_of_x)
        {
            double y;

            List<double> data = new(num_of_x);

            for (int x = -num_of_x / 2; x <= num_of_x / 2; x++)
            {
                // y = e^x
                y = Math.Exp(x);
                data.Add(y);
            }

            return data;
        }

        public static List<double> ExponentcialFunction(double a, int num_of_x)
        {
            double y;

            List<double> data = new(num_of_x);

            for (int x = -num_of_x / 2; x <= num_of_x / 2; x++)
            {
                // y = a^x
                y = Math.Pow(a, x);
                data.Add(y);
            }

            return data;
        }

        public static List<double>PowFunction(double a, int num_of_x)
        {
            double y;

            List<double> data = new(num_of_x);

            for (int x = -num_of_x / 2; x <= num_of_x / 2; x++)
            {
                // y = x^a
                y = Math.Pow(x, a);
                data.Add(y);
            }

            return data;
        }

        public static List<double> LogFunction(double a, double b, double c, int num_of_x)
        {
            double y;

            List<double> data = new(num_of_x);

            for (int x = -num_of_x / 2; x <= num_of_x / 2; x++)
            {
                // y = log(a)x
                y = a * Math.Log(b, x) + c;
                data.Add(y);
            }

            return data;
        }

        public static List<double> LogDecimalFunction(double a, double c, int num_of_x)
        {
            double y;

            List<double> data = new(num_of_x);

            for (int x = -num_of_x / 2; x <= num_of_x / 2; x++)
            {
                // y = log10x
                y = a * Math.Log10(x) + c;
                data.Add(y);
            }

            return data;
        }

        public static List<double> LogNaturalFunction(double a, double c, int num_of_x)
        {
            double y;

            List<double> data = new(num_of_x);

            for (int x = -num_of_x / 2; x <= num_of_x / 2; x++)
            {
                // y = lnx
                y = a * Math.Log(x) + c;
                data.Add(y);
            }

            return data;
        }

        public static List<double> SinFunction(double a, double c, int num_of_x)
        {
            double y;

            List<double> data = new(num_of_x);

            for (int x = -num_of_x / 2; x <= num_of_x / 2; x++)
            {
                // y = a * sin(x) + c
                y = a * Math.Sin(x) + c;
                data.Add(y);
            }

            return data;
        }

        public static List<double> CosFunction(double a, double c, int num_of_x)
        {
            double y;

            List<double> data = new(num_of_x);

            for (int x = -num_of_x / 2; x <= num_of_x / 2; x++)
            {
                // y = a * cos(x) + c
                y = a * Math.Cos(x) + c;
                data.Add(y);
            }

            return data;
        }
    }
}
