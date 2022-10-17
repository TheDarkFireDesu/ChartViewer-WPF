namespace ChartViewer
{
    public static class AdvancedTrigonometric
    {
        static double a = Properties.Settings.Default.ValueA;
        static double b = Properties.Settings.Default.ValueB;
        static double c = Properties.Settings.Default.ValueC;
        static double d = Properties.Settings.Default.ValueD;

        static int Length = Properties.Settings.Default.Length;

        public static Collection<double> VerSinFunction()
        {
            double y;
            Collection<double> data = new();

            for (double x = -1 * (Length / 2); x < Length / 2; x++)
            {
                // y = 1 - (a * sin(bx + c) + d)
                y = 1 - (a * Math.Cos(b * x + c) + d);
                data.Add(y);
            }
            return data;
        }

        public static Collection<double> VerCosFunction()
        {
            double y;
            Collection<double> data = new();

            for (double x = -1 * (Length / 2); x < Length / 2; x++)
            {
                // y = 1 - (a * sin(bx + c) + d)
                y = 1 - (a * Math.Sin(b * x + c) + d);
                data.Add(y);
            }
            return data;
        }

        public static Collection<double> HaverSinFunction()
        {
            double y;
            Collection<double> data = new();

            for (double x = -1 * (Length / 2); x < Length / 2; x++)
            {
                // haversin = versin / 2
                // y = a * sin(bx + c) + d
                y = (1 - (a * Math.Sin(b * x + c) + d)) / 2;
                data.Add(y);
            }
            return data;
        }
        public static Collection<double> HaverCosFunction()
        {
            double y;
            Collection<double> data = new();

            for (double x = -1 * (Length / 2); x < Length / 2; x++)
            {
                // havercos = vercos / 2
                // y = a * sin(bx + c) + d
                y = (1 - (a * Math.Cos(b * x + c) + d)) / 2;
                data.Add(y);
            }
            return data;
        }

        public static Collection<double> ExSecFunction()
        {
            double y;
            Collection<double> data = new();

            for (double x = -1 * (Length / 2); x < Length / 2; x++)
            {
                // exsec = sec - 1
                // y = a * sin(bx + c) + d
                y = (1 / (a * Math.Cos(b * x + c) + d)) - 1;
                data.Add(y);
            }
            return data;
        }

        public static Collection<double> ExCscFunction()
        {
            double y;
            Collection<double> data = new();

            for (double x = -1 * (Length / 2); x < Length / 2; x++)
            {
                // excsc = csc - 1
                // y = a * sin(bx + c) + d
                y = (1 / (a * Math.Sin(b * x + c) + d)) - 1;
                data.Add(y);
            }
            return data;
        }
    }
}
