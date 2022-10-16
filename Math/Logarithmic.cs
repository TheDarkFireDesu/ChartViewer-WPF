namespace ChartViewer
{
    public class Logarithmic
    {
        public static List<double> LogFunction(double a, double b, double c, int Length)
        {
            double y;
            List<double> data = new();

            for (double x = 0.0001; x != Length + 0.0001; x++)
            {
                // y = log(a)x
                y = (a * Math.Log(x, b)) + c;
                data.Add(y);
            }
            return data;
        }

        public static List<double> LogDecimalFunction(double a, double c, int Length)
        {
            double y;
            List<double> data = new();

            for (double x = 0.0001; x != Length + 0.0001; x++)
            {
                // y = log10x
                y = (a * Math.Log10(x)) + c;
                data.Add(y);
            }
            return data;
        }

        public static List<double> LogNaturalFunction(double a, double c, int Length)
        {
            double y;
            List<double> data = new();

            for (double x = 0.0001; x != Length + 0.0001; x++)
            {
                // y = lnx
                y = (a * Math.Log(x)) + c;
                data.Add(y);
            }
            return data;
        }
    }
}
