using LiveChartsCore.SkiaSharpView;
using LiveChartsCore;

namespace ChartViewer
{
    public class ViewModel
    {
        public ISeries[] Series { get; set; } = new ISeries[]
        {

            new LineSeries<double>
            {
                Values = new double[] {1, 2, 3, 4, 5, 6, 7},
                Fill = null
            }
        };

        /*public Axis[] XAxes { get; set; }
            = new Axis[]
            {
                new Axis
                {
                    Name = "Ось Х",
                    NamePaint = new SolidColorPaint(SKColors.Black),
                    LabelsPaint = new SolidColorPaint (SKColors.Blue),
                    TextSize = 10,
                    SeparatorsPaint = new SolidColorPaint(SKColors.LightSlateGray) {StrokeThickness = 2}
                }
            };

         public Axis[] YAxes { get; set; }
            = new Axis[]
            {
                new Axis
                {
                    Name = "Ось Y",
                    NamePaint = new SolidColorPaint(SKColors.Red),
                    LabelsPaint = new SolidColorPaint(SKColors.Green),
                    TextSize = 20,
                    SeparatorsPaint = new SolidColorPaint(SKColors.LightSlateGray)
                    {
                        StrokeThickness = 2,
                        PathEffect = new DashEffect(new float[] {3, 3})
                    }
                }
            }; */
    }
}
