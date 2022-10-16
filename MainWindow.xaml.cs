using System;
using System.Collections.Generic;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;
using ScottPlot;

/*
FUNCTION:
    BASIC - COMPLETE (1 / 1)
    POLYNOMINAL - ( 2 / 3)
    EXPONENTIAL - ( 3 / 3)
    LOGARITHMIC - ( 3 / 3)
    POWER - (1 / 3)
    
    BASE TRIGONOMETRIC - (3 / 5)
    ADVANCED TRIGONOMETRIC - ( 0 / x)
    REVERSE TRIGONOMETRIC - (1 / x)
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
*/


namespace ChartViewer
{
    public partial class MainWindow : Window
    {
        public int NOF = -1;

        public double a = 0;
        public double b = 0;
        public double c = 0;
        public double d = 0;

        public List<double> data = new();
        public List<double> data_x = new();

        public double[] y = new double[60];
        public double[] x = new double[60];

        public MainWindow()
        {
            InitializeComponent();

            var plt = WpfPlot1.Plot;
            plt.Style(ScottPlot.Style.Black);
            plt.AxisAuto(0, 0.1);

            for (int i = -30; i < 30; i++)
            {
                data_x.Add(i);
            }

            x = data_x.ToArray();
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
        // VARIABLES INIT END
        // VARIABLES INIT END

        // TAB 1
        private void Linear_Button_Click(object sender, RoutedEventArgs e)
        {
            NOF = 1; 
            BaseFunc_Label.Content = Linear_Label.Content;
        }

        private void Quadratic_Button_Click(object sender, RoutedEventArgs e)
        {
            NOF = 2; 
            BaseFunc_Label.Content = Quadratic_Label.Content;
        }

        private void Cubic_Button_Click(object sender, RoutedEventArgs e)
        {
            NOF = 3; 
            BaseFunc_Label.Content = Cubic_Label.Content;
        }

        private void Biquad_Button_Click(object sender, RoutedEventArgs e)
        {
            NOF = 4; 
            BaseFunc_Label.Content = Biquad_Label.Content;
        }

        private void Exponent_Button_Click(object sender, RoutedEventArgs e)
        {
            NOF = 5; 
            BaseFunc_Label.Content = Exponent_Label.Content;
        }

        private void Exponential_Button_Click(object sender, RoutedEventArgs e)
        {
            NOF = 6; 
            BaseFunc_Label.Content = Exponential_Label.Content;
        }

        // TAB 2
        private void Log_Button_Click(object sender, RoutedEventArgs e)
        {
            NOF = 7; 
            BaseFunc_Label.Content = Log_Label.Content;
        }

        private void Log10_Button_Click(object sender, RoutedEventArgs e)
        {
            NOF = 8; 
            BaseFunc_Label.Content = Log10_Label.Content;
        }

        private void Ln_Button_Click(object sender, RoutedEventArgs e)
        {
            NOF = 9; 
            BaseFunc_Label.Content = Ln_Label.Content;
        }

        private void Pow_Button_Click(object sender, RoutedEventArgs e)
        {
            NOF = 10; 
            BaseFunc_Label.Content = Pow_Label.Content;
        }

        // TAB 3
        private void Sin_Button_Click(object sender, RoutedEventArgs e)
        {
            NOF = 11; 
            BaseFunc_Label.Content = Sin_Label.Content;
        }

        private void Cos_Button_Click(object sender, RoutedEventArgs e)
        {
            NOF = 12; 
            BaseFunc_Label.Content = Cos_Label.Content;

        }

        private void Tan_Button_Click(object sender, RoutedEventArgs e)
        {
            NOF = 13; 
            BaseFunc_Label.Content = Tan_Label.Content;
        }

        private void Ctg_Button_Click(object sender, RoutedEventArgs e)
        {
            NOF = 14; 
            BaseFunc_Label.Content = Ctg_Label.Content;
        }

        private void Sec_Button_Click(object sender, RoutedEventArgs e)
        {
            NOF = 15; 
            BaseFunc_Label.Content = Sec_Label.Content;
        }

        private void Csc_Button_Click(object sender, RoutedEventArgs e)
        {
            NOF = 16; 
            BaseFunc_Label.Content = Csc_Label.Content;
        }

        // TAB 4
        private void ArcSin_Button_Click(object sender, RoutedEventArgs e)
        {
            NOF = 17; 
            BaseFunc_Label.Content = ArcSin_Label.Content;
        }

        private void ArcCos_Button_Click(object sender, RoutedEventArgs e)
        {
            NOF = 18; 
            BaseFunc_Label.Content = ArcCos_Label.Content;
        }

        private void ArcTan_Button_Click(object sender, RoutedEventArgs e)
        {
            NOF = 19; 
            BaseFunc_Label.Content = ArcTan_Label.Content;
        }
        private void ArcCtg_Button_Click(object sender, RoutedEventArgs e)
        {
            NOF = 20; 
            BaseFunc_Label.Content = ArcCtg_Label.Content;
        }
        private void ArcSec_Button_Click(object sender, RoutedEventArgs e)
        {
            NOF = 21; 
            BaseFunc_Label.Content = ArcSec_Label.Content;
        }

        private void ArcCsc_Button_Click(object sender, RoutedEventArgs e)
        {
            NOF = 22; 
            BaseFunc_Label.Content = ArcCsc_Label.Content;
        }

        // NOF INIT END
        // NOF INIT END
        // NOF INIT END

        private void Calculate_Button_Click(object sender, RoutedEventArgs e)
        {
            Int_TextBox.Text = NOF.ToString();
            data.Clear();

            switch (NOF)
            {
                case 0:
                    break;

                case 1:
                    data = Basic.LinearFunction(a, b);
                    break;

                case 2:
                    data = Polynomial.QuadraticFunction(a, b, c);
                    break;

                case 3:
                    data = Polynomial.CubicFunction(a, b, c, d);
                    break;

                case 4:
                    data = Polynomial.BiquadFunction(a, b, c);
                    break;
            }

            y = data.ToArray();

            Ready_TextBox.Text = "Готово";
            Ready_TextBox.Foreground = Brushes.Green;
        }

        private void Show_Button_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                WpfPlot1.Plot.AddScatter(x, y);
                WpfPlot1.Refresh();
            }
            catch
            {
                if (x.Length == 0)
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
            Ready_TextBox.Text = "Не готово";
            Ready_TextBox.Foreground = Brushes.Red;


        }
    }
}