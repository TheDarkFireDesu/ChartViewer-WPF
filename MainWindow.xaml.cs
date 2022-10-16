using System;
using System.Collections.Generic;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;
using ScottPlot;

/*
FUNCTION:
    BASIC - (1 / 1)
    POLYNOMINAL - ( 3 / 3)
    EXPONENTIAL - ( 3 / 3)
    LOGARITHMIC - ( 3 / 3)
    POWER - (1 / 1)

    SPECIAL - (1 / 5)
    
    BASE TRIGONOMETRIC - (5 / 5)
    ADVANCED TRIGONOMETRIC - ( 0 / 5)
    REVERSE TRIGONOMETRIC - (3 / 5)

    HYPERBOLIC - (0 / 5)
    REVERSE
END.

NUMBER OF FUNC:
    1 - LINEAR

    2 - QUADRATIC
    3 - CUBIC
    4 - BIQUAD

    5 - EXP
    6 - EXPONENTIAL

    7 - LOG
    8 - LOG10
    9 - LN

    10 - POW

    11 - SIN
    12 - COS
    13 - TAN
    14 - CTG
    15 - SEC
    16 - CSC

    17 - ARCSIN
    18 - ARCCOS
    19 - ARCTAN
    20 - ARCCTG
    21 - ARCSEC
    22 - ARCCSC

    24 - ABS

    25 - HYPER SIN
    26 - HYPER COS
    27 - HYPER TG
    28 - HYPER CTG
    29 - HYPER SEC
    30 - HYPER CSC
    
    31 - ARC HYPER SIN
    32 - ARC HYPER COS
    33 - ARC HYPER TG
    34 - ARC HYPER CTG
    35 - ARC HYPER SEC
    36 - ARC HYPER CSC

    37 - SIN-VER
    38 - COS-VER
    39 - HAVER-SIN
    40 - HAVER-COS
    41 - EXSEC
    42 - EXCSC
END.
*/


namespace ChartViewer
{
    public partial class MainWindow : Window
    {
        public int NOF = -1; // number by order
        public static double Step = 1;

        public double a = 0;
        public double b = 0;
        public double c = 0;
        public double d = 0;

        public List<double> data_y = new();

        public double[] y = new double[62];
        public double[] x = DataGen.Range(-30, 30, Step);

        public bool HasLaTex = false;
        public bool HasInterpolation = false;

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
                a_Label.Content = $"a = {a_TextBox.Text}";
            }

            catch { a = 0; }
        }

        private void b_TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            try
            {
                b = Convert.ToDouble(b_TextBox.Text);
                b_Label.Content = $"b = {b_TextBox.Text}";
            }

            catch { b = 0; }
        }

        private void c_TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            try
            {
                c = Convert.ToDouble(c_TextBox.Text);
                c_Label.Content = $"c = {c_TextBox.Text}";
            }

            catch { c = 0; }
        }

        private void d_TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            try
            {
                d = Convert.ToDouble(d_TextBox.Text);
                d_Label.Content = $"d = {d_TextBox.Text}";
            }

            catch { d = 0; }
        }
        // VARIABLES INIT END


        // TAB 1
        private void Linear_Button_Click(object sender, RoutedEventArgs e)
        {
            NOF = 1; 
            BaseFunc_Label.Content = Linear_Label.Content;
            FinalFunc_Label.Content = Defs.FinalFormulaLabelView_NonLaTex(a, b, c, d, NOF);
        }

        private void Quadratic_Button_Click(object sender, RoutedEventArgs e)
        {
            NOF = 2; 
            BaseFunc_Label.Content = Quadratic_Label.Content;
            FinalFunc_Label.Content = Defs.FinalFormulaLabelView_NonLaTex(a, b, c, d, NOF);
        }

        private void Cubic_Button_Click(object sender, RoutedEventArgs e)
        {
            NOF = 3; 
            BaseFunc_Label.Content = Cubic_Label.Content;
            FinalFunc_Label.Content = Defs.FinalFormulaLabelView_NonLaTex(a, b, c, d, NOF);
        }

        private void Biquad_Button_Click(object sender, RoutedEventArgs e)
        {
            NOF = 4; 
            BaseFunc_Label.Content = Biquad_Label.Content;
            FinalFunc_Label.Content = Defs.FinalFormulaLabelView_NonLaTex(a, b, c, d, NOF);
        }

        private void Exponent_Button_Click(object sender, RoutedEventArgs e)
        {
            NOF = 5; 
            BaseFunc_Label.Content = Exponent_Label.Content;
            FinalFunc_Label.Content = Defs.FinalFormulaLabelView_NonLaTex(a, b, c, d, NOF);
        }

        private void Exponential_Button_Click(object sender, RoutedEventArgs e)
        {
            NOF = 6; 
            BaseFunc_Label.Content = Exponential_Label.Content;
            FinalFunc_Label.Content = Defs.FinalFormulaLabelView_NonLaTex(a, b, c, d, NOF);
        }

        // TAB 2
        private void Log_Button_Click(object sender, RoutedEventArgs e)
        {
            NOF = 7; 
            BaseFunc_Label.Content = Log_Label.Content;
            FinalFunc_Label.Content = Defs.FinalFormulaLabelView_NonLaTex(a, b, c, d, NOF);
        }

        private void Log10_Button_Click(object sender, RoutedEventArgs e)
        {
            NOF = 8; 
            BaseFunc_Label.Content = Log10_Label.Content;
            FinalFunc_Label.Content = Defs.FinalFormulaLabelView_NonLaTex(a, b, c, d, NOF);
        }

        private void Ln_Button_Click(object sender, RoutedEventArgs e)
        {
            NOF = 9; 
            BaseFunc_Label.Content = Ln_Label.Content;
            FinalFunc_Label.Content = Defs.FinalFormulaLabelView_NonLaTex(a, b, c, d, NOF);
        }

        private void Pow_Button_Click(object sender, RoutedEventArgs e)
        {
            NOF = 10; 
            BaseFunc_Label.Content = Pow_Label.Content;
            FinalFunc_Label.Content = Defs.FinalFormulaLabelView_NonLaTex(a, b, c, d, NOF);
        }

        // TAB 3
        private void Sin_Button_Click(object sender, RoutedEventArgs e)
        {
            NOF = 11; 
            BaseFunc_Label.Content = Sin_Label.Content;
            FinalFunc_Label.Content = Defs.FinalFormulaLabelView_NonLaTex(a, b, c, d, NOF);
        }

        private void Cos_Button_Click(object sender, RoutedEventArgs e)
        {
            NOF = 12; 
            BaseFunc_Label.Content = Cos_Label.Content;
            FinalFunc_Label.Content = Defs.FinalFormulaLabelView_NonLaTex(a, b, c, d, NOF);

        }

        private void Tan_Button_Click(object sender, RoutedEventArgs e)
        {
            NOF = 13; 
            BaseFunc_Label.Content = Tan_Label.Content;
            FinalFunc_Label.Content = Defs.FinalFormulaLabelView_NonLaTex(a, b, c, d, NOF);
        }

        private void Ctg_Button_Click(object sender, RoutedEventArgs e)
        {
            NOF = 14; 
            BaseFunc_Label.Content = Ctg_Label.Content;
            FinalFunc_Label.Content = Defs.FinalFormulaLabelView_NonLaTex(a, b, c, d, NOF);
        }

        private void Sec_Button_Click(object sender, RoutedEventArgs e)
        {
            NOF = 15; 
            BaseFunc_Label.Content = Sec_Label.Content;
            FinalFunc_Label.Content = Defs.FinalFormulaLabelView_NonLaTex(a, b, c, d, NOF);
        }

        private void Csc_Button_Click(object sender, RoutedEventArgs e)
        {
            NOF = 16; 
            BaseFunc_Label.Content = Csc_Label.Content;
            FinalFunc_Label.Content = Defs.FinalFormulaLabelView_NonLaTex(a, b, c, d, NOF);
        }

        // TAB 4
        private void ArcSin_Button_Click(object sender, RoutedEventArgs e)
        {
            NOF = 17; 
            BaseFunc_Label.Content = ArcSin_Label.Content;
            FinalFunc_Label.Content = Defs.FinalFormulaLabelView_NonLaTex(a, b, c, d, NOF);
        }

        private void ArcCos_Button_Click(object sender, RoutedEventArgs e)
        {
            NOF = 18; 
            BaseFunc_Label.Content = ArcCos_Label.Content;
            FinalFunc_Label.Content = Defs.FinalFormulaLabelView_NonLaTex(a, b, c, d, NOF);
        }

        private void ArcTan_Button_Click(object sender, RoutedEventArgs e)
        {
            NOF = 19; 
            BaseFunc_Label.Content = ArcTan_Label.Content;
            FinalFunc_Label.Content = Defs.FinalFormulaLabelView_NonLaTex(a, b, c, d, NOF);
        }
        private void ArcCtg_Button_Click(object sender, RoutedEventArgs e)
        {
            NOF = 20; 
            BaseFunc_Label.Content = ArcCtg_Label.Content;
            FinalFunc_Label.Content = Defs.FinalFormulaLabelView_NonLaTex(a, b, c, d, NOF);
        }
        private void ArcSec_Button_Click(object sender, RoutedEventArgs e)
        {
            NOF = 21; 
            BaseFunc_Label.Content = ArcSec_Label.Content;
            FinalFunc_Label.Content = Defs.FinalFormulaLabelView_NonLaTex(a, b, c, d, NOF);
        }

        private void ArcCsc_Button_Click(object sender, RoutedEventArgs e)
        {
            NOF = 22; 
            BaseFunc_Label.Content = ArcCsc_Label.Content;
            FinalFunc_Label.Content = Defs.FinalFormulaLabelView_NonLaTex(a, b, c, d, NOF);
        }
        // NOF INIT END

        // INTERFACE
        private void Calculate_Button_Click(object sender, RoutedEventArgs e)
        {
            Int_TextBox.Text = NOF.ToString();

            data_y = Defs.CalculateFunc(a, b, c, d, NOF, x.Length, Step);
            y = data_y.ToArray();

            X_Length_TextBox.Text = "X: " + x.Length.ToString();
            Y_Length_TextBox.Text = "Y: " + y.Length.ToString();

            Defs.IsReady(Ready_TextBox, true);
            Show_Button.IsEnabled = true;
        }

        private void Show_Button_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                if (HasInterpolation == true)
                {
                    (double[] smoothXs, double[] smoothYs) = ScottPlot.Statistics.Interpolation.Cubic.InterpolateXY(x, y, 200);

                    WpfPlot1.Plot.AddScatter(smoothXs, smoothYs);
                    WpfPlot1.Refresh();
                }

                else
                {
                    var plt = WpfPlot1.Plot.AddScatter(x, y);
                    plt.OnNaN = ScottPlot.Plottable.ScatterPlot.NanBehavior.Ignore;
                    WpfPlot1.Refresh();
                }
            }
            catch
            {
                if (x.Length != y.Length)
                {
                    MessageBox.Show("Массивы не одинаковой длины");
                }

                else if (x.Length == 0)
                {
                    MessageBox.Show("Что-то неладное с X");
                }

                else if (y.Length == 0)
                {
                    MessageBox.Show("Что-то неладное с Y");
                }

                else if (NOF == -1)
                {
                    MessageBox.Show("Выберите функцию!");
                }
            }

            NOF = -1;

            Show_Button.IsEnabled = false;
            Clear_Button.IsEnabled = true;
            Defs.IsReady(Ready_TextBox, false);
        }

        private void Clear_Button_Click(object sender, RoutedEventArgs e)
        {
            WpfPlot1.Plot.Clear();
            WpfPlot1.Plot.AddCrosshair(0, 0);
            WpfPlot1.Refresh();

            Clear_Button.IsEnabled = false;
        }

        private void Interpolation_CheckBox_Checked(object sender, RoutedEventArgs e)
        {
            HasInterpolation = true;
        }
    }
}