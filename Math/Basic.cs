namespace ChartViewer
{
	public static class Basic
	{
        static double a = Properties.Settings.Default.ValueA;
        static double b = Properties.Settings.Default.ValueB;

        static int Length = Properties.Settings.Default.Length;

        public static Collection<double> LinearFunction()
		{

			double y;
			Collection<double> data = new();

			for (double x = -1 * ((double)Length / 2); x < Length / 2; x++)
			{
				y = a * x + b;
				data.Add(y);
			}
			return data;
		}
	}
}
