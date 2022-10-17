namespace ChartViewer
{
    public class ReverseTrigonometric
    {
        static double a = Properties.Settings.Default.ValueA;
        static double b = Properties.Settings.Default.ValueB;
        static double c = Properties.Settings.Default.ValueC;
        static double d = Properties.Settings.Default.ValueD;

        static int Length = Properties.Settings.Default.Length;

        public static Collection<double> ArcSinFunction()
        {
            double y;
            Collection<double> data = new();

            for (double x = -1 * (Length / 2); x < Length / 2; x++)
            {
                // y = a * arcsin(bx + c) + d
                y = a * Math.Asin(b * x + c) + d;
                data.Add(y);
            }
            return data;
        }

        public static Collection<double> ArcCosFunction()
        {
            double y;
            Collection<double> data = new();

            for (double x = -1 * (Length / 2); x < Length / 2; x++)
            {
                // y = a * arccos(bx + c) + d
                y = a * Math.Acos(b * x + c) + d;
                data.Add(y);
            }
            return data;
        }

        public static Collection<double> ArcTgFunction()
        {
            double y;
            Collection<double> data = new();

            for (double x = -1 * (Length / 2); x < Length / 2; x++)
            {
                // y = a * arctg(bx + c) + d
                y = a * Math.Atan(b * x + c) + d;
                data.Add(y);
            }
            return data;
        }

        public static Collection<double> ArcCtgFunction()
        {
            double y;
            Collection<double> data = new();

            for (double x = -1 * (Length / 2); x < Length / 2; x++)
            {
                // y = a * arcctg(bx + c) + d
                y = a * (Math.Atan((b * -x + c) / Math.Sqrt((b * -x + c) * (b * x + c) + 1)) + 2 * Math.Atan(1)) + d;
                data.Add(y);
            }
            return data;
        }

        // WIP
        public static Collection<double> ArcSecFunction()
        {
            double y;
            Collection<double> data = new();

            for (double x = -1 * (Length / 2); x < Length / 2; x++)
            {
                // y = a * arcctg(bx + c) + d
                y = a * (Math.Atan((b * -x + c) / Math.Sqrt((b * -x + c) * (b * x + c) + 1)) + 2 * Math.Atan(1)) + d;
                data.Add(y);
            }
            return data;
        }

        // WIP
        public static Collection<double> ArcCscFunction()
        {
            double y;
            Collection<double> data = new();

            for (double x = -1 * (Length / 2); x < Length / 2; x++)
            {
                // y = a * arcctg(bx + c) + d
                y = a * (Math.Atan((b * -x + c) / Math.Sqrt((b * -x + c) * (b * x + c) + 1)) + 2 * Math.Atan(1)) + d;
                data.Add(y);
            }
            return data;
        }
    }
}
