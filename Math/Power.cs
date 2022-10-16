namespace ChartViewer
{
    public class Power
    {
        public static List<double> PowFunction(double a, double b, double c, int Length)
        {
            double xpow;
            double y;
            List<double> data = new();

            for (double x = -1 * (Length / 2); x < Length / 2; x++)
            {
                xpow = Math.Pow(x, b);

                // y = a * x^b + c
                y = a * xpow + c;
                data.Add(y);
            }

            return data;
        }
    }
}
