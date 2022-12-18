[assembly: CLSCompliant(true)]

namespace ChartViewer
{
    public partial class MainWindow : Window
    {

        int NOF = -1; // number by order
        int InterpolationValue = 200;
        int minX = -30;
        int maxX = 30;

        readonly ChartWindow chartWindow = new();

        static double Step = 1;

        double a;
        double b;
        double c;
        double d;

        double[] y = new double[61];
        double[] x = DataGen.Range(-30, 30, Step);

        bool HasInterpolation;

        public MainWindow()
        {
            InitializeComponent();
        }

        private void a_TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            try
            {
                a = Convert.ToDouble(a_TextBox.Text);
                Properties.Settings.Default.ValueA = a;
                a_Label.Text = Properties.Settings.Default.ValueA.ToString();
            }

            catch { a = 0; }
        }

        private void b_TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            try
            {
                b = Convert.ToDouble(b_TextBox.Text);
                Properties.Settings.Default.ValueB = b;
                b_Label.Text = Properties.Settings.Default.ValueB.ToString();
            }

            catch { b = 0; }
        }

        private void c_TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            try
            {
                c = Convert.ToDouble(c_TextBox.Text);
                Properties.Settings.Default.ValueC = c;
                c_Label.Text = Properties.Settings.Default.ValueC.ToString();
            }

            catch { c = 0; }
        }

        private void d_TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            try
            {
                d = Convert.ToDouble(d_TextBox.Text);
                Properties.Settings.Default.ValueD = d;
                d_Label.Text = Properties.Settings.Default.ValueD.ToString();
            }
            catch { d = 0; }
        }

        private void Step_TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            try
            {
                Step = Convert.ToDouble(Step_TextBox.Text);
                Properties.Settings.Default.Step = Step;
            }
            catch { Step = 1; }
        }

        private void MaxRange_TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            try
            {
                maxX = Convert.ToInt32(MaxRange_TextBox.Text);
                Properties.Settings.Default.MaxX = maxX;
            }
            catch { maxX = 1; }
        }

        private void MinRange_TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            try
            {
                minX = Convert.ToInt32(MinRange_TextBox.Text);
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
            FinalFunc_Label.Text = FormulaTextLabel.FinalFormulaTextCreate(NOF);

        }

        private void Quadratic_Button_Click(object sender, RoutedEventArgs e)
        {
            NOF = 2;
            FinalFunc_Label.Text = FormulaTextLabel.FinalFormulaTextCreate(NOF);
        }

        private void Cubic_Button_Click(object sender, RoutedEventArgs e)
        {
            NOF = 3;
            FinalFunc_Label.Text = FormulaTextLabel.FinalFormulaTextCreate(NOF);
        }

        private void Biquad_Button_Click(object sender, RoutedEventArgs e)
        {
            NOF = 4;
            FinalFunc_Label.Text = FormulaTextLabel.FinalFormulaTextCreate(NOF);
        }

        private void Exponent_Button_Click(object sender, RoutedEventArgs e)
        {
            NOF = 5;
            FinalFunc_Label.Text = FormulaTextLabel.FinalFormulaTextCreate(NOF);
        }

        private void Exponential_Button_Click(object sender, RoutedEventArgs e)
        {
            NOF = 6;
            FinalFunc_Label.Text = FormulaTextLabel.FinalFormulaTextCreate(NOF);
        }

        private void Log_Button_Click(object sender, RoutedEventArgs e)
        {
            NOF = 7;
            FinalFunc_Label.Text = FormulaTextLabel.FinalFormulaTextCreate(NOF);
        }

        private void Log10_Button_Click(object sender, RoutedEventArgs e)
        {
            NOF = 8;
            FinalFunc_Label.Text = FormulaTextLabel.FinalFormulaTextCreate(NOF);
        }

        private void Ln_Button_Click(object sender, RoutedEventArgs e)
        {
            NOF = 9;
            FinalFunc_Label.Text = FormulaTextLabel.FinalFormulaTextCreate(NOF);
        }

        private void Pow_Button_Click(object sender, RoutedEventArgs e)
        {
            NOF = 10;
            FinalFunc_Label.Text = FormulaTextLabel.FinalFormulaTextCreate(NOF);
        }

        private void Sin_Button_Click(object sender, RoutedEventArgs e)
        {
            NOF = 11;
            FinalFunc_Label.Text = FormulaTextLabel.FinalFormulaTextCreate(NOF);
        }

        private void Cos_Button_Click(object sender, RoutedEventArgs e)
        {
            NOF = 12;
            FinalFunc_Label.Text = FormulaTextLabel.FinalFormulaTextCreate(NOF);
        }

        private void Tan_Button_Click(object sender, RoutedEventArgs e)
        {
            NOF = 13;
            FinalFunc_Label.Text = FormulaTextLabel.FinalFormulaTextCreate(NOF);
        }

        private void Ctg_Button_Click(object sender, RoutedEventArgs e)
        {
            NOF = 14;
            FinalFunc_Label.Text = FormulaTextLabel.FinalFormulaTextCreate(NOF);
        }

        private void Sec_Button_Click(object sender, RoutedEventArgs e)
        {
            NOF = 15;
            FinalFunc_Label.Text = FormulaTextLabel.FinalFormulaTextCreate(NOF);
        }

        private void Csc_Button_Click(object sender, RoutedEventArgs e)
        {
            NOF = 16;
            FinalFunc_Label.Text = FormulaTextLabel.FinalFormulaTextCreate(NOF);
        }

        private void ArcSin_Button_Click(object sender, RoutedEventArgs e)
        {
            NOF = 17;
            FinalFunc_Label.Text = FormulaTextLabel.FinalFormulaTextCreate(NOF);
        }

        private void ArcCos_Button_Click(object sender, RoutedEventArgs e)
        {
            NOF = 18;
            FinalFunc_Label.Text = FormulaTextLabel.FinalFormulaTextCreate(NOF);
        }

        private void ArcTan_Button_Click(object sender, RoutedEventArgs e)
        {
            NOF = 19;
            FinalFunc_Label.Text = FormulaTextLabel.FinalFormulaTextCreate(NOF);
        }

        private void ArcCtg_Button_Click(object sender, RoutedEventArgs e)
        {
            NOF = 20;
            FinalFunc_Label.Text = FormulaTextLabel.FinalFormulaTextCreate(NOF);
        }

        private void ArcSec_Button_Click(object sender, RoutedEventArgs e)
        {
            NOF = 21;
            FinalFunc_Label.Text = FormulaTextLabel.FinalFormulaTextCreate(NOF);
        }

        private void ArcCsc_Button_Click(object sender, RoutedEventArgs e)
        {
            NOF = 22;
            FinalFunc_Label.Text = FormulaTextLabel.FinalFormulaTextCreate(NOF);
        }

        private void Abs_Button_Click(object sender, RoutedEventArgs e)
        {
            NOF = 24;
            FinalFunc_Label.Text = FormulaTextLabel.FinalFormulaTextCreate(NOF);
        }

        private void Sh_Button_Click(object sender, RoutedEventArgs e)
        {
            NOF = 25;
            FinalFunc_Label.Text = FormulaTextLabel.FinalFormulaTextCreate(NOF);
        }

        private void Ch_Button_Click(object sender, RoutedEventArgs e)
        {
            NOF = 26;
            FinalFunc_Label.Text = FormulaTextLabel.FinalFormulaTextCreate(NOF);
        }

        private void Th_Button_Click(object sender, RoutedEventArgs e)
        {
            NOF = 27;
            FinalFunc_Label.Text = FormulaTextLabel.FinalFormulaTextCreate(NOF);
        }

        private void Cth_Button_Click(object sender, RoutedEventArgs e)
        {
            NOF = 28;
            FinalFunc_Label.Text = FormulaTextLabel.FinalFormulaTextCreate(NOF);
        }

        private void Sech_Button_Click(object sender, RoutedEventArgs e)
        {
            NOF = 29;
            FinalFunc_Label.Text = FormulaTextLabel.FinalFormulaTextCreate(NOF);
        }

        private void Csch_Button_Click(object sender, RoutedEventArgs e)
        {
            NOF = 30;
            FinalFunc_Label.Text = FormulaTextLabel.FinalFormulaTextCreate(NOF);
        }

        private void Ash_Button_Click(object sender, RoutedEventArgs e)
        {
            NOF = 31;
            FinalFunc_Label.Text = FormulaTextLabel.FinalFormulaTextCreate(NOF);
        }

        private void Ach_Button_Click(object sender, RoutedEventArgs e)
        {
            NOF = 32;
            FinalFunc_Label.Text = FormulaTextLabel.FinalFormulaTextCreate(NOF);
        }

        private void Ath_Button_Click(object sender, RoutedEventArgs e)
        {
            NOF = 33;
            FinalFunc_Label.Text = FormulaTextLabel.FinalFormulaTextCreate(NOF);
        }

        private void Acth_Button_Click(object sender, RoutedEventArgs e)
        {
            NOF = 34;
            FinalFunc_Label.Text = FormulaTextLabel.FinalFormulaTextCreate(NOF);
        }

        private void Asech_Button_Click(object sender, RoutedEventArgs e)
        {
            NOF = 35;
            FinalFunc_Label.Text = FormulaTextLabel.FinalFormulaTextCreate(NOF);
        }

        private void Acsch_Button_Click(object sender, RoutedEventArgs e)
        {
            NOF = 36;
            FinalFunc_Label.Text = FormulaTextLabel.FinalFormulaTextCreate(NOF);
        }

        private void SinVer_Button_Click(object sender, RoutedEventArgs e)
        {
            NOF = 37;
            FinalFunc_Label.Text = FormulaTextLabel.FinalFormulaTextCreate(NOF);
        }

        private void CosVer_Button_Click(object sender, RoutedEventArgs e)
        {
            NOF = 38;
            FinalFunc_Label.Text = FormulaTextLabel.FinalFormulaTextCreate(NOF);
        }

        private void HaverSin_Button_Click(object sender, RoutedEventArgs e)
        {
            NOF = 39;
            FinalFunc_Label.Text = FormulaTextLabel.FinalFormulaTextCreate(NOF);
        }

        private void HaverCos_Button_Click(object sender, RoutedEventArgs e)
        {
            NOF = 40;
            FinalFunc_Label.Text = FormulaTextLabel.FinalFormulaTextCreate(NOF);
        }

        private void ExSec_Button_Click(object sender, RoutedEventArgs e)
        {
            NOF = 41;
            FinalFunc_Label.Text = FormulaTextLabel.FinalFormulaTextCreate(NOF);
        }

        private void ExCsc_Button_Click(object sender, RoutedEventArgs e)
        {
            NOF = 42;
            FinalFunc_Label.Text = FormulaTextLabel.FinalFormulaTextCreate(NOF);
        }
        // NOF INIT END

        // INTERFACE
        private void Interpolation_CheckBox_Checked(object sender, RoutedEventArgs e) => HasInterpolation = !HasInterpolation;

        private void Interpolation_Slider_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e) => InterpolationValue = Convert.ToInt32(Interpolation_Slider.Value);

        private void LaTeX_CheckBox_Checked(object sender, RoutedEventArgs e) => FormulaLabel.IsEnabled = !FormulaLabel.IsEnabled;

        private void Clear_Button_Click(object sender, RoutedEventArgs e)
        {
            var XYPlot = chartWindow.ChartWindowPlot.Plot;

            XYPlot.Clear();
            XYPlot.AddCrosshair(0, 0);

            chartWindow.ChartWindowPlot.Refresh();
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
                (x, y) = ArrayXY.CreateArraysOfXY();
                // X_Length_TextBox.Text = "X: " + x.Length.ToString();
                //Y_Length_TextBox.Text = "Y: " + y.Length.ToString();


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

                var plt = chartWindow.ChartWindowPlot.Plot.AddScatter(x, y);
                plt.OnNaN = ScottPlot.Plottable.ScatterPlot.NanBehavior.Ignore;
                chartWindow.ChartWindowPlot.Refresh();

            }
            catch { MessageBox.Show("Массивы не одинаковой длины"); }
            
            if (!chartWindow.IsActive)
            {
                chartWindow.Show();
            }

            NOF = -1;

            CheckBoolean.IsActive(Show_Button, false);
            CheckBoolean.IsActive(Clear_Button, true);
            CheckBoolean.IsReady(Ready_TextBox, false);
        }

        private void Window_Closed(object sender, EventArgs e)
        {
           Application.Current.Shutdown();
        }
    }
}