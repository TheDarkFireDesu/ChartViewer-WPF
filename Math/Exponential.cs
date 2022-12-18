namespace ChartViewer
{
    public static class Exponential
    {
        static double a = Properties.Settings.Default.ValueA;
        static double b = Properties.Settings.Default.ValueB;
        static double c = Properties.Settings.Default.ValueC;

        static int Length = Properties.Settings.Default.Length;

        public static Collection<double> ExponentFunction()
        {
            double y;

            Collection<double> data = new();

            for (double x = -1 * (Length / 2); x < Length / 2; x++)
            {
                // y = a * e^x + b;
                y = a * Math.Exp(x) + b;
                data.Add(y);
            }

            return data;
        }

        public static Collection<double> ExponentcialFunction()
        {
            double xpow;
            double y;

            Collection<double> data = new();

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
