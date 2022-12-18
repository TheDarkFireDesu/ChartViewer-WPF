namespace ChartViewer
{
    public static class Power
    {
        static double a = Properties.Settings.Default.ValueA;
        static double b = Properties.Settings.Default.ValueB;
        static double c = Properties.Settings.Default.ValueC;

        static int Length = Properties.Settings.Default.Length;

        public static Collection<double> PowFunction()
        {
            double xpow;
            double y;
            Collection<double> data = new();

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
