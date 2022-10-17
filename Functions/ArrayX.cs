namespace ChartViewer.Functions
{
    internal class ArrayX
    {
        static int MaxX = Properties.Settings.Default.MaxX;
        static int MinX = Properties.Settings.Default.MinX;
        static int NOF = Properties.Settings.Default.NOF;
        static double Step = Properties.Settings.Default.Step;

        public static double[] CalculateX()
        {
            List<double> data_x = new();
            double spacing = 1;
            double offset = 0.0001;

            if (MinX > 0)
            {
                MinX *= -1;
            }

            for (int i = MinX; i < MaxX; i++)
            {
                data_x.Add(Math.Abs(i));
            }

            int array_length = data_x.ToArray().Length;

            double[] x;

            x = NOF switch
            {
                7 => DataGen.Consecutive(array_length, spacing, offset),
                8 => DataGen.Consecutive(array_length, spacing, offset),
                9 => DataGen.Consecutive(array_length, spacing, offset),
                _ => DataGen.Range(MinX, MaxX, Step, true),
            };
            return x;
        }
    }
}
