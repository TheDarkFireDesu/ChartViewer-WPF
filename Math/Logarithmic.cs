namespace ChartViewer
{
    public static class Logarithmic
    {
        static double a = Properties.Settings.Default.ValueA;
        static double b = Properties.Settings.Default.ValueB;
        static double c = Properties.Settings.Default.ValueC;

        static int Length = Properties.Settings.Default.Length;

        public static Collection<double> LogFunction()
        {
            double y;
            Collection<double> data = new();

            for (double x = 0.0001; x != Length + 0.0001; x++)
            {
                // y = log(a)x
                y = (a * Math.Log(x, b)) + c;
                data.Add(y);
            }
            return data;
        }

        public static Collection<double> LogDecimalFunction()
        {
            double y;
            Collection<double> data = new();

            for (double x = 0.0001; x != Length + 0.0001; x++)
            {
                // y = log10x
                y = (a * Math.Log10(x)) + c;
                data.Add(y);
            }
            return data;
        }

        public static Collection<double> LogNaturalFunction()
        {
            double y;
            Collection<double> data = new();

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
