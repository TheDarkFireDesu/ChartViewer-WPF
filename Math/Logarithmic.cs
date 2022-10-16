using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChartViewer
{
    public class Logarithmic
    {
        public static List<double> LogFunction(double a, double b, double c)
        {
            double y;

            List<double> data = new();

            for (int x = -30; x <= 30; x++)
            {
                // y = log(a)x
                y = (a * Math.Log(b, x)) + c;
                data.Add(y);
            }

            return data;
        }

        public static List<double> LogDecimalFunction(double a, double c)
        {
            double y;

            List<double> data = new();

            for (int x = -30; x <= 30; x++)
            {
                // y = log10x
                y = (a * Math.Log10(x)) + c;
                data.Add(y);
            }

            return data;
        }

        public static List<double> LogNaturalFunction(double a, double c)
        {
            double y;

            List<double> data = new();

            for (int x = -30; x <= 30; x++)
            {
                // y = lnx
                y = (a * Math.Log(x)) + c;
                data.Add(y);
            }

            return data;
        }
    }
}
