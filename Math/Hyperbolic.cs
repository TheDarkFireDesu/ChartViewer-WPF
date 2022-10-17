namespace ChartViewer
{
    public static class Hyperbolic
    {
        static double a = Properties.Settings.Default.ValueA;
        static double b = Properties.Settings.Default.ValueB;
        static double c = Properties.Settings.Default.ValueC;
        static double d = Properties.Settings.Default.ValueD;

        static int Length = Properties.Settings.Default.Length;
        public static Collection<double> HyperSinFunction()
        {
            double y;
            Collection<double> data = new();

            for (double x = -1 * (Length / 2); x < Length / 2; x++)
            {
                // y = a * Sinh(bx + c) + d
                y = a * Math.Sinh(b * x + c) + d;
                data.Add(y);
            }
            return data;
        }

        public static Collection<double> HyperCosFunction()
        {
            double y;
            Collection<double> data = new();

            for (double x = -1 * (Length / 2); x < Length / 2; x++)
            {
                // y = a * Cosh(bx + c) + d
                y = (a * Math.Cosh(b * x + c) + d);
                data.Add(y);
            }
            return data;
        }

        public static Collection<double> HyperTgFunction()
        {
            double y;
            Collection<double> data = new();

            for (double x = -1 * (Length / 2); x < Length / 2; x++)
            {
                // y = a * Th(bx + c) + d
                y = a * Math.Tanh(b * x + c) + d;
                data.Add(y);
            }
            return data;
        }

        public static Collection<double> HyperCtgFunction()
        {
            double y;
            Collection<double> data = new();

            for (double x = -1 * (Length / 2); x < Length / 2; x++)
            {
                // y = a * Ch(bx + c) + d
                y = 1 / (a * Math.Tanh(b * x + c) + d);
                data.Add(y);
            }
            return data;
        }

        public static Collection<double> HyperSecFunction()
        {
            double y;
            Collection<double> data = new();

            for (double x = -1 * (Length / 2); x < Length / 2; x++)
            {
                // y = a * Ch(bx + c) + d
                y = 1 / (a * Math.Cosh(b * x + c) + d);
                data.Add(y);
            }
            return data;
        }
        public static Collection<double> HyperCscFunction()
        {
            double y;
            Collection<double> data = new();

            for (double x = -1 * (Length / 2); x < Length / 2; x++)
            {
                // y = a * Ch(bx + c) + d
                y = 1 / (a * Math.Sinh(b * x + c) + d);
                data.Add(y);
            }
            return data;
        }
    }
}
