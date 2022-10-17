namespace ChartViewer
{
    public static class Trigonometric
    {
        static double a = Properties.Settings.Default.ValueA;
        static double b = Properties.Settings.Default.ValueB;
        static double c = Properties.Settings.Default.ValueC;
        static double d = Properties.Settings.Default.ValueD;

        static int Length = Properties.Settings.Default.Length;

        public static Collection<double> SinFunction()
        {
            double y;
            Collection<double> data = new();

            for (double x = -1 * (Length / 2); x < Length / 2; x++)
            {
                // y = a * sin(bx + c) + d
                y = a * Math.Sin(b * x + c) + d;
                data.Add(y);
            }
            return data;
        }

        public static Collection<double> CosFunction()
        {
            double y;
            Collection<double> data = new();

            for (double x = -1 * (Length / 2); x < Length / 2; x++)
            {
                // y = a * cos(bx + c) + d
                y = a * Math.Cos(b * x + c) + d;
                data.Add(y);
            }
            return data;
        }

        public static Collection<double> TgFunction()
        {
            double y;
            Collection<double> data = new();

            for (double x = -1 * (Length / 2); x < Length / 2; x++)
            {
                // y = a * tg(bx + c) + d
                y = a * Math.Tan(b * x + c) + d;
                data.Add(y);
            }
            return data;
        }

        public static Collection<double> CtgFunction()
        {
            double y;

            Collection<double> data = new();

            for (double x = -1 * (Length / 2); x < Length / 2; x++)
            {
                // y = a * ctg(bx + c) + d
                y = 1 / (a * Math.Tan(b * x + c) + d);
                data.Add(y);
            }
            return data;
        }

        public static Collection<double> SecFunction()
        {
            double y;
            Collection<double> data = new();

            for (double x = -1 * (Length / 2); x < Length / 2; x++)
            {
                // y = a * sec(bx + c) + d
                y = 1 / (a * Math.Cos(b * x + c) + d);
                data.Add(y);
            }
            return data;
        }

        public static Collection<double> CscFunction()
        {
            double y;
            Collection<double> data = new();

            for (double x = -1 * (Length / 2); x < Length / 2; x++)
            {
                // y = a * Csc(bx + c) + d
                y = 1 / (a * Math.Sin(b * x + c) + d);
                data.Add(y);
            }
            return data;
        }
    }
}
