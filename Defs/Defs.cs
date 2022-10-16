using System.Windows.Media;

namespace ChartViewer
{
    public class Defs
    {
        public static void IsReady(TextBox _textBox, bool _status)
        {
            if (_status)
            {
                _textBox.Text = "Готово";
                _textBox.Foreground = Brushes.Green;
            }

            else
            {
                _textBox.Text = "Не готово";
                _textBox.Foreground = Brushes.Red;
            }

        }

        public static double[] CalculateX(int _min, int _max, double _step, int _NOF)
        {
            List<double> data_x = new();
            double spacing = 1;
            double offset = 0.0001;

            if (_min > 0) 
            {
                _min *= -1;
            }

            for (int i = _min; i < _max; i++)
            {
                data_x.Add(Math.Abs(i));
            }

            int array_length = data_x.ToArray().Length;

            double[] x = new double[array_length];
            
            switch (_NOF) 
            {
                case 7:
                    x = DataGen.Consecutive(array_length, spacing, offset);
                    break;

                case 8:
                    x = DataGen.Consecutive(array_length, spacing, offset);
                    break;

                case 9:
                    x = DataGen.Consecutive(array_length, spacing, offset);
                    break;

                default:
                    x = DataGen.Range(_min, _max, _step);
                    break;
            }       

            return x;
        }

        public static List<double> CalculateFunc(double a, double b, double c, double d, int NOF, int Length)
        {
            List<double> data_y = new();

            switch (NOF)
            {
                case -1:
                    break;

                case 1:
                    data_y = Basic.LinearFunction(a, b, Length);
                    break;

                case 2:
                    data_y = Polynomial.QuadraticFunction(a, b, c, Length);
                    break;

                case 3:
                    data_y = Polynomial.CubicFunction(a, b, c, d, Length);
                    break;

                case 4:
                    data_y = Polynomial.BiquadFunction(a, b, c, Length);
                    break;

                case 5:
                    data_y = Exponential.ExponentFunction(a, b, Length);
                    break;

                case 6:
                    data_y = Exponential.ExponentcialFunction(a, b, c, Length);
                    break;

                case 7:
                    data_y = Logarithmic.LogFunction(a, b, c, Length);
                    break;

                case 8:
                    data_y = Logarithmic.LogDecimalFunction(a, c, Length);
                    break;

                case 9:
                    data_y = Logarithmic.LogNaturalFunction(a, c, Length);
                    break;

                case 10:
                    data_y = Power.PowFunction(a, b, c, Length);
                    break;

                case 11:
                    data_y = Trigonometric.SinFunction(a, b, c, d, Length);
                    break;

                case 12:
                    data_y = Trigonometric.CosFunction(a, b, c, d, Length);
                    break;

                case 13:
                    data_y = Trigonometric.TgFunction(a, b, c, d, Length);
                    break;

                case 14:
                    data_y = Trigonometric.CtgFunction(a, b, c, d, Length);

                    break;
                case 15:
                    data_y = Trigonometric.SecFunction(a, b, c, d, Length);
                    break;

                case 16:
                    data_y = Trigonometric.CscFunction(a, b, c, d, Length);
                    break;

                case 17:
                    data_y = Reverse_Trigonometric.ArcSinFunction(a, b, c, d, Length);
                    break;

                case 18:
                    data_y = Reverse_Trigonometric.ArcCosFunction(a, b, c, d, Length);
                    break;

                case 19:
                    data_y = Reverse_Trigonometric.ArcTgFunction(a, b, c, d, Length);
                    break;

                case 20:
                    data_y = Reverse_Trigonometric.ArcCtgFunction(a, b, c, d, Length);
                    break;

                case 21:
                    data_y = Reverse_Trigonometric.ArcSecFunction(a, b, c, d, Length);
                    break;

                case 22:
                    data_y = Reverse_Trigonometric.ArcCscFunction(a, b, c, d, Length);
                    break;

                case 23:
                    break;

                case 24:
                    data_y = Special.AbsFunction(a, b, c, d, Length);
                    break;

                case 25:
                    data_y = Hyperbolic.HyperSinFunction(a, b, c, d, Length);
                    break;

                case 26:
                    data_y = Hyperbolic.HyperCosFunction(a, b, c, d, Length);
                    break;

                case 27:
                    data_y = Hyperbolic.HyperTgFunction(a, b, c, d, Length);
                    break;

                case 28:
                    data_y = Hyperbolic.HyperCtgFunction(a, b, c, d, Length);
                    break;

                case 29:
                    data_y = Hyperbolic.HyperSecFunction(a, b, c, d, Length);
                    break;

                case 30:
                    data_y = Hyperbolic.HyperCscFunction(a, b, c, d, Length);
                    break;

                case 31:
                    data_y = Reverse_Hyperbolic.AreaSinFunction(a, b, c, d, Length);
                    break;

                case 32:
                    data_y = Reverse_Hyperbolic.AreaCosFunction(a, b, c, d, Length);
                    break;

                case 33:
                    data_y = Reverse_Hyperbolic.AreaTgFunction(a, b, c, d, Length);
                    break;

                case 34:
                    data_y = Reverse_Hyperbolic.AreaCtgFunction(a, b, c, d, Length);
                    break;

                case 35:
                    data_y = Reverse_Hyperbolic.AreaSecFunction(a, b, c, d, Length);
                    break;

                case 36:
                    data_y = Reverse_Hyperbolic.AreaCscFunction(a, b, c, d, Length);
                    break;

                case 37:
                    data_y = Advanced_Trigonometric.VerSinFunction(a, b, c, d, Length);
                    break;

                case 38:
                    data_y = Advanced_Trigonometric.VerCosFunction(a, b, c, d, Length);
                    break;

                case 39:
                    data_y = Advanced_Trigonometric.HaverSinFunction(a, b, c, d, Length);
                    break;

                case 40:
                    data_y = Advanced_Trigonometric.HaverCosFunction(a, b, c, d, Length);
                    break;

                case 41:
                    data_y = Advanced_Trigonometric.ExSecFunction(a, b, c, d, Length);
                    break;

                case 42:
                    data_y = Advanced_Trigonometric.ExCscFunction(a, b, c, d, Length);
                    break;
            }

            return data_y;
        }

        public static string FinalFormulaLabelView_NonLaTex(double a, double b, double c, double d, int NOF)
        {
            string content = "";

            switch (NOF)
            {
                case -1:

                    break;

                case 1:
                    content = $"{a}x + {b}";
                    break;

                case 2:
                    content = $"{a}x^2 + {b}x + {c}";
                    break;

                case 3:
                    content = $"{a}x^3 + {b}x^2 + {c}x + d";
                    break;

                case 4:
                    content = $"{a}x^4 + {b}x^2 + {c}";
                    break;

                case 5:
                    content = $"{a} * e^x + {b}";
                    break;

                case 6:
                    content = $"{a} * {b}^x + {c}";
                    break;

                case 7:
                    content = $"{a} * log{b}(x) + {d}";
                    break;

                case 8:
                    content = $"{a} * log(x) + {d}";
                    break;

                case 9:
                    content = $"{a} * ln(x) + {d}";
                    break;

                case 10:
                    content = $"{a} * x^{b} + {c}";
                    break;

                case 11:
                    content = $"{a} * sin({b}x + {c}) + {d}";
                    break;

                case 12:
                    content = $"{a} * cos({b}x + {c}) + {d}";
                    break;

                case 13:
                    content = $"{a} * tg({b}x + {c}) + {d}";
                    break;

                case 14:
                    content = $"{a} * ctg({b}x + {c}) + {d}";

                    break;
                case 15:
                    content = $"{a} * sec({b}x + {c}) + {d}";
                    break;

                case 16:
                    content = $"{a} * csc({b}x + {c}) + {d}";
                    break;

                case 17:
                    content = $"{a} * arcsin({b}x + {c}) + {d}";
                    break;

                case 18:
                    content = $"{a} * arccos({b}x + {c}) + {d}";
                    break;

                case 19:
                    content = $"{a} * arctg({b}x + {c}) + {d}";
                    break;

                case 20:
                    content = $"{a} * arcctg({b}x + {c}) + {d}";
                    break;

                case 21:
                    content = $"{a} * arcsec({b}x + {c}) + {d}";
                    break;

                case 22:
                    content = $"{a} * arccsc({b}x + {c}) + {d}";
                    break;

                case 23:
                    break;

                case 24:
                    content = $"{a} * | {b}x + {c} | + {d}";
                    break;

                case 25:
                    content = $"{a} * sh({b}x + {c}) + {d}";
                    break;

                case 26:
                    content = $"{a} * ch({b}x + {c}) + {d}";
                    break;

                case 27:
                    content = $"{a} * th({b}x + {c}) + {d}";
                    break;

                case 28:
                    content = $"{a} * cth({b}x + {c}) + {d}";
                    break;

                case 29:
                    content = $"{a} * asech({b}x + {c}) + {d}";
                    break;

                case 30:
                    content = $"{a} * csch({b}x + {c}) + {d}";
                    break;

                case 31:
                    content = $"{a} * arsh({b}x + {c}) + {d}";
                    break;

                case 32:
                    content = $"{a} * arch({b}x + {c}) + {d}";
                    break;

                case 33:
                    content = $"{a} * arth({b}x + {c}) + {d}";
                    break;

                case 34:
                    content = $"{a} * arcth({b}x + {c}) + {d}";
                    break;

                case 35:
                    content = $"{a} * arsech({b}x + {c}) + {d}";
                    break;

                case 36:
                    content = $"{a} * arcsch({b}x + {c}) + {d}";
                    break;

                case 37:
                    content = $"{a} * versin({b}x + {c}) + {d}";
                    break;

                case 38:
                    content = $"{a} * vercos({b}x + {c}) + {d}";
                    break;

                case 39:
                    content = $"{a} * haversin({b}x + {c}) + {d}";
                    break;

                case 40:
                    content = $"{a} * havercos({b}x + {c}) + {d}";
                    break;

                case 41:
                    content = $"{a} * exsec({b}x + {c}) + {d}";
                    break;

                case 42:
                    content = $"{a} * excsc({b}x + {c}) + {d}";
                    break;
            }

            return content;
        }
    }
}
