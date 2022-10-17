using ChartViewer.Functions;

[assembly: CLSCompliant(true)]

namespace ChartViewer
{
    public partial class MainWindow : Window
    {

        int NOF = -1; // number by order
        int InterpolationValue = 200;
        int minX = -30;
        int maxX = 30;

        static double Step = 1;

        double a;
        double b;
        double c;
        double d;

        double[] y = new double[62];
        double[] x = DataGen.Range(-30, 30, Step);

        bool HasInterpolation;

        public MainWindow()
        {
            InitializeComponent();

            var plt = WpfPlot1.Plot;
            plt.Style(ScottPlot.Style.Black);
            plt.AddCrosshair(0, 0);
            WpfPlot1.Refresh();
        }

        private void a_TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            try
            {
                a = Convert.ToDouble(a_TextBox.Text);
                a_Label.Text = $"a = {a_TextBox.Text}";
                Properties.Settings.Default.ValueA = a;
            }

            catch { a = 0; }
        }

        private void b_TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            try
            {
                b = Convert.ToDouble(b_TextBox.Text);
                b_Label.Text = $"b = {b_TextBox.Text}";
                Properties.Settings.Default.ValueB = b;
            }

            catch { b = 0; }
        }

        private void c_TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            try
            {
                c = Convert.ToDouble(c_TextBox.Text);
                c_Label.Text = $"c = {c_TextBox.Text}";
                Properties.Settings.Default.ValueC = c;
            }

            catch { c = 0; }
        }

        private void d_TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            try
            {
                d = Convert.ToDouble(d_TextBox.Text);
                d_Label.Text = $"d = {d_TextBox.Text}";
                Properties.Settings.Default.ValueD = d;
            }
            catch { d = 0; }
        }

        private void Step_TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            try
            {
                Step = Convert.ToDouble(Step_TextBox.Text);
                Step_Label.Text = $"Шаг = {Step}";
                Properties.Settings.Default.Step = Step;
            }
            catch { Step = 1; }
        }

        private void MaxRange_TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            try
            {
                maxX = Convert.ToInt32(MaxRange_TextBox.Text);
                Range_Label.Text = $"[{minX};{maxX})";
                Properties.Settings.Default.MaxX = maxX;
            }
            catch { maxX = 1; }
        }

        private void MinRange_TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            try
            {
                minX = Convert.ToInt32(MinRange_TextBox.Text);
                Range_Label.Text = $"[{minX};{maxX})";
                Properties.Settings.Default.MinX = minX;
            }
            catch { minX = 1; }
        }

        private void Range_TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }
        // VARIABLES INIT END

        private void Linear_Button_Click(object sender, RoutedEventArgs e)
        {
            NOF = 1;
            BaseFunc_Label.Text = Linear_Label.Content.ToString();
            FinalFunc_Label.Text = FormulaTextLabel.FinalFormulaTextCreate(a, b, c, d, NOF);

        }

        private void Quadratic_Button_Click(object sender, RoutedEventArgs e)
        {
            NOF = 2;
            BaseFunc_Label.Text = Quadratic_Label.Content.ToString();
            FinalFunc_Label.Text = FormulaTextLabel.FinalFormulaTextCreate(a, b, c, d, NOF);
        }

        private void Cubic_Button_Click(object sender, RoutedEventArgs e)
        {
            NOF = 3;
            BaseFunc_Label.Text = Cubic_Label.Content.ToString();
            FinalFunc_Label.Text = FormulaTextLabel.FinalFormulaTextCreate(a, b, c, d, NOF);
        }

        private void Biquad_Button_Click(object sender, RoutedEventArgs e)
        {
            NOF = 4;
            BaseFunc_Label.Text = Biquad_Label.Content.ToString();
            FinalFunc_Label.Text = FormulaTextLabel.FinalFormulaTextCreate(a, b, c, d, NOF);
        }

        private void Exponent_Button_Click(object sender, RoutedEventArgs e)
        {
            NOF = 5;
            BaseFunc_Label.Text = Exponent_Label.Content.ToString();
            FinalFunc_Label.Text = FormulaTextLabel.FinalFormulaTextCreate(a, b, c, d, NOF);
        }

        private void Exponential_Button_Click(object sender, RoutedEventArgs e)
        {
            NOF = 6;
            BaseFunc_Label.Text = Exponential_Label.Content.ToString();
            FinalFunc_Label.Text = FormulaTextLabel.FinalFormulaTextCreate(a, b, c, d, NOF);
        }

        private void Log_Button_Click(object sender, RoutedEventArgs e)
        {
            NOF = 7;
            BaseFunc_Label.Text = Log_Label.Content.ToString();
            FinalFunc_Label.Text = FormulaTextLabel.FinalFormulaTextCreate(a, b, c, d, NOF);
        }

        private void Log10_Button_Click(object sender, RoutedEventArgs e)
        {
            NOF = 8;
            BaseFunc_Label.Text = Log10_Label.Content.ToString();
            FinalFunc_Label.Text = FormulaTextLabel.FinalFormulaTextCreate(a, b, c, d, NOF);
        }

        private void Ln_Button_Click(object sender, RoutedEventArgs e)
        {
            NOF = 9;
            BaseFunc_Label.Text = Ln_Label.Content.ToString();
            FinalFunc_Label.Text = FormulaTextLabel.FinalFormulaTextCreate(a, b, c, d, NOF);
        }

        private void Pow_Button_Click(object sender, RoutedEventArgs e)
        {
            NOF = 10;
            BaseFunc_Label.Text = Pow_Label.Content.ToString();
            FinalFunc_Label.Text = FormulaTextLabel.FinalFormulaTextCreate(a, b, c, d, NOF);
        }

        private void Sin_Button_Click(object sender, RoutedEventArgs e)
        {
            NOF = 11;
            BaseFunc_Label.Text = Sin_Label.Content.ToString();
            FinalFunc_Label.Text = FormulaTextLabel.FinalFormulaTextCreate(a, b, c, d, NOF);
        }

        private void Cos_Button_Click(object sender, RoutedEventArgs e)
        {
            NOF = 12;
            BaseFunc_Label.Text = Cos_Label.Content.ToString();
            FinalFunc_Label.Text = FormulaTextLabel.FinalFormulaTextCreate(a, b, c, d, NOF);
        }

        private void Tan_Button_Click(object sender, RoutedEventArgs e)
        {
            NOF = 13;
            BaseFunc_Label.Text = Tan_Label.Content.ToString();
            FinalFunc_Label.Text = FormulaTextLabel.FinalFormulaTextCreate(a, b, c, d, NOF);
        }

        private void Ctg_Button_Click(object sender, RoutedEventArgs e)
        {
            NOF = 14;
            BaseFunc_Label.Text = Ctg_Label.Content.ToString();
            FinalFunc_Label.Text = FormulaTextLabel.FinalFormulaTextCreate(a, b, c, d, NOF);
        }

        private void Sec_Button_Click(object sender, RoutedEventArgs e)
        {
            NOF = 15;
            BaseFunc_Label.Text = Sec_Label.Content.ToString();
            FinalFunc_Label.Text = FormulaTextLabel.FinalFormulaTextCreate(a, b, c, d, NOF);
        }

        private void Csc_Button_Click(object sender, RoutedEventArgs e)
        {
            NOF = 16;
            BaseFunc_Label.Text = Csc_Label.Content.ToString();
            FinalFunc_Label.Text = FormulaTextLabel.FinalFormulaTextCreate(a, b, c, d, NOF);
        }

        private void ArcSin_Button_Click(object sender, RoutedEventArgs e)
        {
            NOF = 17;
            BaseFunc_Label.Text = ArcSin_Label.Content.ToString();
            FinalFunc_Label.Text = FormulaTextLabel.FinalFormulaTextCreate(a, b, c, d, NOF);
        }

        private void ArcCos_Button_Click(object sender, RoutedEventArgs e)
        {
            NOF = 18;
            BaseFunc_Label.Text = ArcCos_Label.Content.ToString();
            FinalFunc_Label.Text = FormulaTextLabel.FinalFormulaTextCreate(a, b, c, d, NOF);
        }

        private void ArcTan_Button_Click(object sender, RoutedEventArgs e)
        {
            NOF = 19;
            BaseFunc_Label.Text = ArcTan_Label.Content.ToString();
            FinalFunc_Label.Text = FormulaTextLabel.FinalFormulaTextCreate(a, b, c, d, NOF);
        }

        private void ArcCtg_Button_Click(object sender, RoutedEventArgs e)
        {
            NOF = 20;
            BaseFunc_Label.Text = ArcCtg_Label.Content.ToString();
            FinalFunc_Label.Text = FormulaTextLabel.FinalFormulaTextCreate(a, b, c, d, NOF);
        }

        private void ArcSec_Button_Click(object sender, RoutedEventArgs e)
        {
            NOF = 21;
            BaseFunc_Label.Text = ArcSec_Label.Content.ToString();
            FinalFunc_Label.Text = FormulaTextLabel.FinalFormulaTextCreate(a, b, c, d, NOF);
        }

        private void ArcCsc_Button_Click(object sender, RoutedEventArgs e)
        {
            NOF = 22;
            BaseFunc_Label.Text = ArcCsc_Label.Content.ToString();
            FinalFunc_Label.Text = FormulaTextLabel.FinalFormulaTextCreate(a, b, c, d, NOF);
        }

        private void Abs_Button_Click(object sender, RoutedEventArgs e)
        {
            NOF = 24;
            BaseFunc_Label.Text = Abs_Label.Content.ToString();
            FinalFunc_Label.Text = FormulaTextLabel.FinalFormulaTextCreate(a, b, c, d, NOF);
        }

        private void Sh_Button_Click(object sender, RoutedEventArgs e)
        {
            NOF = 25;
            BaseFunc_Label.Text = Sh_Label.Content.ToString();
            FinalFunc_Label.Text = FormulaTextLabel.FinalFormulaTextCreate(a, b, c, d, NOF);
        }

        private void Ch_Button_Click(object sender, RoutedEventArgs e)
        {
            NOF = 26;
            BaseFunc_Label.Text = Ch_Label.Content.ToString();
            FinalFunc_Label.Text = FormulaTextLabel.FinalFormulaTextCreate(a, b, c, d, NOF);
        }

        private void Th_Button_Click(object sender, RoutedEventArgs e)
        {
            NOF = 27;
            BaseFunc_Label.Text = Th_Label.Content.ToString();
            FinalFunc_Label.Text = FormulaTextLabel.FinalFormulaTextCreate(a, b, c, d, NOF);
        }

        private void Cth_Button_Click(object sender, RoutedEventArgs e)
        {
            NOF = 28;
            BaseFunc_Label.Text = Cth_Label.Content.ToString();
            FinalFunc_Label.Text = FormulaTextLabel.FinalFormulaTextCreate(a, b, c, d, NOF);
        }

        private void Sech_Button_Click(object sender, RoutedEventArgs e)
        {
            NOF = 29;
            BaseFunc_Label.Text = Sech_Label.Content.ToString();
            FinalFunc_Label.Text = FormulaTextLabel.FinalFormulaTextCreate(a, b, c, d, NOF);
        }

        private void Csch_Button_Click(object sender, RoutedEventArgs e)
        {
            NOF = 30;
            BaseFunc_Label.Text = Csch_Label.Content.ToString();
            FinalFunc_Label.Text = FormulaTextLabel.FinalFormulaTextCreate(a, b, c, d, NOF);
        }

        private void Ash_Button_Click(object sender, RoutedEventArgs e)
        {
            NOF = 31;
            BaseFunc_Label.Text = Ash_Label.Content.ToString();
            FinalFunc_Label.Text = FormulaTextLabel.FinalFormulaTextCreate(a, b, c, d, NOF);
        }

        private void Ach_Button_Click(object sender, RoutedEventArgs e)
        {
            NOF = 32;
            BaseFunc_Label.Text = Ach_Label.Content.ToString();
            FinalFunc_Label.Text = FormulaTextLabel.FinalFormulaTextCreate(a, b, c, d, NOF);
        }

        private void Ath_Button_Click(object sender, RoutedEventArgs e)
        {
            NOF = 33;
            BaseFunc_Label.Text = Ath_Label.Content.ToString();
            FinalFunc_Label.Text = FormulaTextLabel.FinalFormulaTextCreate(a, b, c, d, NOF);
        }

        private void Acth_Button_Click(object sender, RoutedEventArgs e)
        {
            NOF = 34;
            BaseFunc_Label.Text = Acth_Label.Content.ToString();
            FinalFunc_Label.Text = FormulaTextLabel.FinalFormulaTextCreate(a, b, c, d, NOF);
        }

        private void Asech_Button_Click(object sender, RoutedEventArgs e)
        {
            NOF = 35;
            BaseFunc_Label.Text = Asech_Label.Content.ToString();
            FinalFunc_Label.Text = FormulaTextLabel.FinalFormulaTextCreate(a, b, c, d, NOF);
        }

        private void Acsch_Button_Click(object sender, RoutedEventArgs e)
        {
            NOF = 36;
            BaseFunc_Label.Text = Acsch_Label.Content.ToString();
            FinalFunc_Label.Text = FormulaTextLabel.FinalFormulaTextCreate(a, b, c, d, NOF);
        }

        private void SinVer_Button_Click(object sender, RoutedEventArgs e)
        {
            NOF = 37;
            BaseFunc_Label.Text = SinVer_Label.Content.ToString();
            FinalFunc_Label.Text = FormulaTextLabel.FinalFormulaTextCreate(a, b, c, d, NOF);
        }

        private void CosVer_Button_Click(object sender, RoutedEventArgs e)
        {
            NOF = 38;
            BaseFunc_Label.Text = CosVer_Label.Content.ToString();
            FinalFunc_Label.Text = FormulaTextLabel.FinalFormulaTextCreate(a, b, c, d, NOF);
        }

        private void HaverSin_Button_Click(object sender, RoutedEventArgs e)
        {
            NOF = 39;
            BaseFunc_Label.Text = HaverSin_Label.Content.ToString();
            FinalFunc_Label.Text = FormulaTextLabel.FinalFormulaTextCreate(a, b, c, d, NOF);
        }

        private void HaverCos_Button_Click(object sender, RoutedEventArgs e)
        {
            NOF = 40;
            BaseFunc_Label.Text = HaverCos_Label.Content.ToString();
            FinalFunc_Label.Text = FormulaTextLabel.FinalFormulaTextCreate(a, b, c, d, NOF);
        }

        private void ExSec_Button_Click(object sender, RoutedEventArgs e)
        {
            NOF = 41;
            BaseFunc_Label.Text = ExSec_Label.Content.ToString();
            FinalFunc_Label.Text = FormulaTextLabel.FinalFormulaTextCreate(a, b, c, d, NOF);
        }

        private void ExCsc_Button_Click(object sender, RoutedEventArgs e)
        {
            NOF = 42;
            BaseFunc_Label.Text = ExCsc_Label.Content.ToString();
            FinalFunc_Label.Text = FormulaTextLabel.FinalFormulaTextCreate(a, b, c, d, NOF);
        }
        // NOF INIT END

        // INTERFACE
        private void Interpolation_CheckBox_Checked(object sender, RoutedEventArgs e) => HasInterpolation = !HasInterpolation;

        private void Interpolation_Slider_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e) => InterpolationValue = Convert.ToInt32(Interpolation_Slider.Value);

        private void LaTeX_CheckBox_Checked(object sender, RoutedEventArgs e) => FormulaLabel.IsEnabled = !FormulaLabel.IsEnabled;

        private void Clear_Button_Click(object sender, RoutedEventArgs e)
        {
            var XYPlot = WpfPlot1.Plot;

            XYPlot.Clear();
            XYPlot.AddCrosshair(0, 0);

            WpfPlot1.Refresh();
            Clear_Button.IsEnabled = false;
        }

        private void Calculate_Button_Click(object sender, RoutedEventArgs e)
        {
            Properties.Settings.Default.NOF = NOF;
            Int_TextBox.Text = NOF.ToString();

            if (NOF == -1)
            {
                MessageBox.Show("Вы не выбрали функцию!");

                CheckBoolean.IsReady(Ready_TextBox, false);
                Show_Button.IsEnabled = false;
            }

            else
            {
                (double[] x, double[] y) = ArrayXY.CreateArraysOfXY();
                X_Length_TextBox.Text = "X: " + x.Length.ToString();
                Y_Length_TextBox.Text = "Y: " + y.Length.ToString();


                CheckBoolean.IsReady(Ready_TextBox, true);
                Show_Button.IsEnabled = true;
            }
        }

        private void Show_Button_Click(object sender, RoutedEventArgs e)
        {

            try
            {
                if (HasInterpolation)
                {
                    (double[] smoothXs, double[] smoothYs) = ScottPlot.Statistics.Interpolation.Cubic.InterpolateXY(x, y, InterpolationValue);

                    x = smoothXs;
                    y = smoothYs;
                }

                var plt = WpfPlot1.Plot.AddScatter(x, y);
                plt.OnNaN = ScottPlot.Plottable.ScatterPlot.NanBehavior.Ignore;
                WpfPlot1.Refresh();

            }
            catch { MessageBox.Show("Массивы не одинаковой длины"); }

            NOF = -1;

            Show_Button.IsEnabled = false;
            Clear_Button.IsEnabled = true;
            CheckBoolean.IsReady(Ready_TextBox, false);

        }
    }
}