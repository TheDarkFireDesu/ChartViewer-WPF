namespace ChartViewer
{
    public class Reverse_Trigonometric
    {
        public static List<double> ArcSinFunction(double a, double b, double c, double d, int Length)
        {
            double y;
            List<double> data = new();

            for (double x = -1 * (Length / 2); x < Length / 2; x++)
            {
                // y = a * arcsin(bx + c) + d
                y = a * Math.Asin(b * x + c) + d;
                data.Add(y);
            }
            return data;
        }

        public static List<double> ArcCosFunction(double a, double b, double c, double d, int Length)
        {
            double y;
            List<double> data = new();

            for (double x = -1 * (Length / 2); x < Length / 2; x++)
            {
                // y = a * arccos(bx + c) + d
                y = a * Math.Acos(b * x + c) + d;
                data.Add(y);
            }
            return data;
        }

        public static List<double> ArcTgFunction(double a, double b, double c, double d, int Length)
        {
            double y;
            List<double> data = new();

            for (double x = -1 * (Length / 2); x < Length / 2; x++)
            {
                // y = a * arctg(bx + c) + d
                y = a * Math.Atan(b * x + c) + d;
                data.Add(y);
            }
            return data;
        }

        public static List<double> ArcCtgFunction(double a, double b, double c, double d, int Length)
        {
            double y;
            List<double> data = new();

            for (double x = -1 * (Length / 2); x < Length / 2; x++)
            {
                // y = a * arcctg(bx + c) + d
                y = a * (Math.Atan( (b * -x + c) / Math.Sqrt((b * -x + c) * (b * x + c) + 1)) + 2 * Math.Atan(1)) + d;
                data.Add(y);
            }
            return data;
        }

        // WIP
        public static List<double> ArcSecFunction(double a, double b, double c, double d, int Length)
        {
            double y;
            List<double> data = new();

            for (double x = -1 * (Length / 2); x < Length / 2; x++)
            {
                // y = a * arcctg(bx + c) + d
                y = a * (Math.Atan((b * -x + c) / Math.Sqrt((b * -x + c) * (b * x + c) + 1)) + 2 * Math.Atan(1)) + d;
                data.Add(y);
            }
            return data;
        }

        // WIP
        public static List<double> ArcCscFunction(double a, double b, double c, double d, int Length)
        {
            double y;
            List<double> data = new();

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
