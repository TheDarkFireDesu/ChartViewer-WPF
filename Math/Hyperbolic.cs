namespace ChartViewer
{
    public class Hyperbolic
    {
        public static List<double> HyperSinFunction(double a, double b, double c, double d, int Length)
        {
            double y;
            List<double> data = new();

            for (double x = -1 * (Length / 2); x < Length / 2; x++)
            {
                // y = a * Sinh(bx + c) + d
                y = a * Math.Sinh(b * x + c) + d;
                data.Add(y);
            }
            return data;
        }

        public static List<double> HyperCosFunction(double a, double b, double c, double d, int Length)
        {
            double y;
            List<double> data = new();

            for (double x = -1 * (Length / 2); x < Length / 2; x++)
            {
                // y = a * Cosh(bx + c) + d
                y = a * Math.Cosh(b * x + c) + d;
                data.Add(y);
            }
            return data;
        }

        public static List<double> HyperTgFunction(double a, double b, double c, double d, int Length)
        {
            double y;
            List<double> data = new();

            for (double x = -1 * (Length / 2); x < Length / 2; x++)
            {
                // y = a * Th(bx + c) + d
                y = a * Math.Tanh(b * x + c) + d;
                data.Add(y);
            }
            return data;
        }

        public static List<double> HyperCtgFunction(double a, double b, double c, double d, int Length)
        {
            double y;
            List<double> data = new();

            for (double x = -1 * (Length / 2); x < Length / 2; x++)
            {
                // y = a * Ch(bx + c) + d
                y = 1 / (a * Math.Tanh(b * x + c) + d);
                data.Add(y);
            }
            return data;
        }

        public static List<double> HyperSecFunction(double a, double b, double c, double d, int Length)
        {
            double y;
            List<double> data = new();

            for (double x = -1 * (Length / 2); x < Length / 2; x++)
            {
                // y = a * Ch(bx + c) + d
                y = 1 / (a * Math.Cosh(b * x + c) + d);
                data.Add(y);
            }
            return data;
        }
        public static List<double> HyperCscFunction(double a, double b, double c, double d, int Length)
        {
            double y;
            List<double> data = new();

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
