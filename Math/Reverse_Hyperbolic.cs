namespace ChartViewer
{
    public class Reverse_Hyperbolic
    {
        public static List<double> AreaSinFunction(double a, double b, double c, double d, int Length)
        {
            double y;
            List<double> data = new();

            for (double x = -1 * (Length / 2); x < Length / 2; x++)
            {
                // y = a * Sinh(bx + c) + d
                y = a * Math.Asinh(b * x + c) + d;
                data.Add(y);
            }
            return data;
        }

        public static List<double> AreaCosFunction(double a, double b, double c, double d, int Length)
        {
            double y;
            List<double> data = new();

            for (double x = -1 * (Length / 2); x < Length / 2; x++)
            {
                // y = a * Cosh(bx + c) + d
                y = a * Math.Acosh(b * x + c) + d;
                data.Add(y);
            }
            return data;
        }

        public static List<double> AreaTgFunction(double a, double b, double c, double d, int Length)
        {
            double y;
            List<double> data = new();

            for (double x = -1 * (Length / 2); x < Length / 2; x++)
            {
                // y = a * Th(bx + c) + d
                y = a * Math.Atanh(b * x + c) + d;
                data.Add(y);
            }
            return data;
        }

        public static List<double> AreaCtgFunction(double a, double b, double c, double d, int Length)
        {


            double y;
            List<double> data = new();

            for (double x = -1 * (Length / 2); x < Length / 2; x++)
            {
                // y = 1/2 * Ln((x + 1) / (x - 1))
                y = 0.5 * Math.Log((x + 1) / (x - 1));
                data.Add(y);
            }
            return data;
        }

        public static List<double> AreaSecFunction(double a, double b, double c, double d, int Length)
        {
            double y;
            List<double> data = new();

            for (double x = -1 * (Length / 2); x < Length / 2; x++)
            {
                // y = 	Log((Sqrt(-x * x + 1) + 1) / x)
                y = Math.Log((Math.Sqrt(-x * x + 1) + 1) / x);
                data.Add(y);
            }
            return data;
        }
        public static List<double> AreaCscFunction(double a, double b, double c, double d, int Length)
        {
            double y;
            List<double> data = new();

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
