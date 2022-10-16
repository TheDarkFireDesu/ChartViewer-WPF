using System.Collections.Generic;
using System.Windows.Controls;
using System.Windows.Media;

namespace ChartViewer
{
    public class Defs
    {
        public static void IsReady(TextBox Ready_TextBox, bool Status)
        {
            if (Status == true)
            {
                Ready_TextBox.Text = "Готово";
                Ready_TextBox.Foreground = Brushes.Green;
            }
            else
            {
                Ready_TextBox.Text = "Не готово";
                Ready_TextBox.Foreground = Brushes.Red;
            }
        }

        public static List<double> CalculateFunc(double a, double b, double c, double d, int NOF, int Length, double Step)
        {
            List<double> data_y = new();

            switch (NOF)
            {
                case -1:
                    break;

                case 1:
                    data_y = Basic.LinearFunction(a, b, Length, Step);
                    break;

                case 2:
                    data_y = Polynomial.QuadraticFunction(a, b, c, Length, Step);
                    break;

                case 3:
                    data_y = Polynomial.CubicFunction(a, b, c, d, Length, Step);
                    break;

                case 4:
                    data_y = Polynomial.BiquadFunction(a, b, c, Length, Step);
                    break;

                case 5:
                    data_y = Exponential.ExponentFunction(a, b, Length, Step);
                    break;

                case 6:
                    data_y = Exponential.ExponentcialFunction(a, b, c, Length, Step);
                    break;

                case 7:
                    data_y = Logarithmic.LogFunction(a, b, c, Length, Step);
                    break;

                case 8:
                    data_y = Logarithmic.LogDecimalFunction(a, c, Length, Step);
                    break;

                case 9:
                    data_y = Logarithmic.LogNaturalFunction(a, c, Length, Step);
                    break;

                case 10:
                    data_y = Power.PowFunction(a, b, c, Length, Step);
                    break;

                case 11:
                    data_y = Trigonometric.SinFunction(a, b, c, d, Length, Step);
                    break;

                case 12:
                    data_y = Trigonometric.CosFunction(a, b, c, d, Length, Step);
                    break;

                case 13:
                    data_y = Trigonometric.TgFunction(a, b, c, d, Length, Step);
                    break;

                case 14:
                    data_y = Trigonometric.CtgFunction(a, b, c, d, Length, Step);
                    
                    break;
                case 15:
                    data_y = Trigonometric.SecFunction(a, b, c, d, Length, Step);
                    break;

                case 16:
                    data_y = Trigonometric.CscFunction(a, b, c, d, Length, Step);
                    break;

                case 17:
                    data_y = Reverse_Trigonometric.ArcSinFunction(a, b, c, d, Length, Step);
                    break;

                case 18:
                    data_y = Reverse_Trigonometric.ArcCosFunction(a, b, c, d, Length, Step);
                    break;

                case 19:
                    data_y = Reverse_Trigonometric.ArcTgFunction(a, b, c, d, Length, Step);
                    break;

                case 20:
                    data_y = Reverse_Trigonometric.ArcCtgFunction(a, b, c, d, Length, Step);
                    break;

                case 21:
                    data_y = Reverse_Trigonometric.ArcSecFunction(a, b, c, d, Length, Step);
                    break;

                case 22:
                    data_y = Reverse_Trigonometric.ArcCscFunction(a, b, c, d, Length, Step);
                    break;
            }

            return data_y;
        }

        public static string FinalFormulaLabelView_NonLaTex(double a, double b, double c, double d, int NOF)
        {
            string content = "Итоговая формула: ";

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
            }

            return content;
        }
    }
}
