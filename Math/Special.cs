namespace ChartViewer
{
    public static class Special
    {
        static double a = Properties.Settings.Default.ValueA;
        static double b = Properties.Settings.Default.ValueB;
        static double c = Properties.Settings.Default.ValueC;
        static double d = Properties.Settings.Default.ValueD;

        static int Length = Properties.Settings.Default.Length;

        public static Collection<double> AbsFunction()
        {
            double y;
            Collection<double> data = new();

            for (double x = -1 * (Length / 2); x < Length / 2; x++)
            {
                // y = a * |bx + c| + d
                y = a * Math.Abs(b * x + c) + d;
                data.Add(y);
            }
            return data;
        }
    }
}
