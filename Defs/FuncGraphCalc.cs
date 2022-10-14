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

        public static List<double> LinearFunction(double a, double b)
        {
            double y;

            List<double> data = new(200);

            for (int x = -10; x <= 10; x++)
            {
                y = a * x + b;
                data.Add(y);
            }

            return data;
        }

        public static List<double> QuadraticFunction(double a, double b, int num_of_x)
        {
            double y;

            List<double> data = new(num_of_x);

            for (int x = -10; x <= 10; x++)
            {
                y = a * x + b;
                data.Add(y);
            }

            return data;
        }
    }
}
