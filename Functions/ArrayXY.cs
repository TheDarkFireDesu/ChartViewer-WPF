namespace ChartViewer.Functions
{
    internal class ArrayXY
    {
        public static Tuple<double[], double[]> CreateArraysOfXY()
        {
            double[] x = ArrayX.CalculateX();

            Collection<double> x_col = Calculation.CalculateFunction();
            double[] y = new double[x_col.Count];
            x_col.CopyTo(y, 0);

            return Tuple.Create(x, y);
        }
    }
}
