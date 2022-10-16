namespace ChartViewer
{
    public class Exponential
    {
        public static List<double> ExponentFunction(double a, double b, int Length)
        {
            double y;

            List<double> data = new();

            for (double x = -1 * (Length / 2); x < Length / 2; x++)
            {
                // y = a * e^x + b;
                y = a * Math.Exp(x) + b;
                data.Add(y);
            }

            return data;
        }

        public static List<double> ExponentcialFunction(double a, double b, double c, int Length)
        {
            double xpow;
            double y;

            List<double> data = new();

            for (double x = -1 * (Length / 2); x < Length / 2; x++)
            {
                xpow = Math.Pow(b, x);
                // y = a * b^x + c
                y = a * xpow + c;
                data.Add(y);
            }

            return data;
        }
    }
}
