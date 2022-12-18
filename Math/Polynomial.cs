namespace ChartViewer
{
    public static class Polynomial
    {
        static double a = Properties.Settings.Default.ValueA;
        static double b = Properties.Settings.Default.ValueB;
        static double c = Properties.Settings.Default.ValueC;
        static double d = Properties.Settings.Default.ValueD;

        static int Length = Properties.Settings.Default.Length;

        public static Collection<double> QuadraticFunction()
        {
            double y;
            Collection<double> data = new();

            for (double x = -1 * ((double)Length / 2); x < Length / 2; x++)
            {
                // y = ax^2 + bx + c
                y = a * Math.Pow(x, 2) + b * x + c;
                data.Add(y);
            }
            return data;
        }

        public static Collection<double> CubicFunction()
        {
            double y;
            Collection<double> data = new();

            for (double x = -1 * ((double)Length / 2); x < Length / 2; x++)
            {
                // y = ax^3 + bx^2 + cx + d
                y = a * Math.Pow(x, 3) + b * Math.Pow(x, 2) + c * x + d;
                data.Add(y);
            }
            return data;
        }

        public static Collection<double> BiquadFunction()
        {
            double y;
            Collection<double> data = new();

            for (double x = -1 * ((double)Length / 2); x < Length / 2; x++)
            {
                // y = ax^4 + bx^2 + с
                y = a * Math.Pow(x, 4) + b * Math.Pow(x, 2) + c;
                data.Add(y);
            }
            return data;
        }
    }
}
