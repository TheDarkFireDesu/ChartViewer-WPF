namespace ChartViewer
{
    public class Advanced_Trigonometric
    {
        public static List<double> VerSinFunction(double a, double b, double c, double d, int Length)
        {
            double y;
            List<double> data = new();

            for (double x = -1 * (Length / 2); x < Length / 2; x++)
            {
                // y = 1 - (a * sin(bx + c) + d)
                y = 1 - (a * Math.Cos(b * x + c) + d);
                data.Add(y);
            }
            return data;
        }

        public static List<double> VerCosFunction(double a, double b, double c, double d, int Length)
        {
            double y;
            List<double> data = new();

            for (double x = -1 * (Length / 2); x < Length / 2; x++)
            {
                // y = 1 - (a * sin(bx + c) + d)
                y = 1 - (a * Math.Sin(b * x + c) + d);
                data.Add(y);
            }
            return data;
        }

        public static List<double> HaverSinFunction(double a, double b, double c, double d, int Length)
        {
            double y;
            List<double> data = new();

            for (double x = -1 * (Length / 2); x < Length / 2; x++)
            {
                // haversin = versin / 2
                // y = a * sin(bx + c) + d
                y = (1 - (a * Math.Sin(b * x + c) + d)) / 2;
                data.Add(y);
            }
            return data;
        }
        public static List<double> HaverCosFunction(double a, double b, double c, double d, int Length)
        {
            double y;
            List<double> data = new();

            for (double x = -1 * (Length / 2); x < Length / 2; x++)
            {   
                // havercos = vercos / 2
                // y = a * sin(bx + c) + d
                y = (1 - (a * Math.Cos(b * x + c) + d)) / 2;
                data.Add(y);
            }
            return data;
        }

        public static List<double> ExSecFunction(double a, double b, double c, double d, int Length)
        {
            double y;
            List<double> data = new();

            for (double x = -1 * (Length / 2); x < Length / 2; x++)
            {
                // exsec = sec - 1
                // y = a * sin(bx + c) + d
                y = (1 / (a * Math.Cos(b * x + c) + d)) - 1;
                data.Add(y);
            }
            return data;
        }

        public static List<double> ExCscFunction(double a, double b, double c, double d, int Length)
        {
            double y;
            List<double> data = new();

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
