namespace ChartViewer
{
    public partial class ChartWindow : Window
    {
        public ChartWindow()
        {
            InitializeComponent();

            var plt = ChartWindowPlot.Plot;
            plt.Style(ScottPlot.Style.Black);
            plt.AddCrosshair(0, 0);
            ChartWindowPlot.Refresh();
        }
    }
}
