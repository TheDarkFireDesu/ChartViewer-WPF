namespace ChartViewer
{
    public static class ReverseHyperbolic
    {
        static double a = Properties.Settings.Default.ValueA;
        static double b = Properties.Settings.Default.ValueB;
        static double c = Properties.Settings.Default.ValueC;
        static double d = Properties.Settings.Default.ValueD;

        static int Length = Properties.Settings.Default.Length;

        public static Collection<double> AreaSinFunction()
        {
            double y;
            Collection<double> data = new();

            for (double x = -1 * (Length / 2); x < Length / 2; x++)
            {
                // y = a * Sinh(bx + c) + d
                y = a * Math.Asinh(b * x + c) + d;
                data.Add(y);
            }
            return data;
        }

        public static Collection<double> AreaCosFunction()
        {
            double y;
            Collection<double> data = new();

            for (double x = -1 * (Length / 2); x < Length / 2; x++)
            {
                // y = a * Cosh(bx + c) + d
                y = a * Math.Acosh(b * x + c) + d;
                data.Add(y);
            }
            return data;
        }

        public static Collection<double> AreaTgFunction()
        {
            double y;
            Collection<double> data = new();

            for (double x = -1 * (Length / 2); x < Length / 2; x++)
            {
                // y = a * Th(bx + c) + d
                y = a * Math.Atanh(b * x + c) + d;
                data.Add(y);
            }
            return data;
        }

        public static Collection<double> AreaCtgFunction()
        {


            double y;
            Collection<double> data = new();

            for (double x = -1 * (Length / 2); x < Length / 2; x++)
            {
                // y = 1/2 * Ln((x + 1) / (x - 1))
                y = 0.5 * Math.Log((x + 1) / (x - 1));
                data.Add(y);
            }
            return data;
        }

        public static Collection<double> AreaSecFunction()
        {
            double y;
            Collection<double> data = new();

            for (double x = -1 * (Length / 2); x < Length / 2; x++)
            {
                // y = 	Log((Sqrt(-x * x + 1) + 1) / x)
                y = Math.Log((Math.Sqrt(-x * x + 1) + 1) / x);
                data.Add(y);
            }
            return data;
        }
        public static Collection<double> AreaCscFunction()
        {
            double y;
            Collection<double> data = new();

            for (double x = -1 * (Length / 2); x < Length / 2; x++)
            {
                // y = 	Log((Sign(x) * Sqrt(x * x + 1) + 1) / x)
                y = Math.Log((Math.Sign(x) * Math.Sqrt(x * x + 1) + 1) + x);
                data.Add(y);
            }
            return data;
        }
    }
}
