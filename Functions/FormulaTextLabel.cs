namespace ChartViewer.Functions
{
    internal class FormulaTextLabel
    {
        static double a = Properties.Settings.Default.ValueA;
        static double b = Properties.Settings.Default.ValueB;
        static double c = Properties.Settings.Default.ValueC;
        static double d = Properties.Settings.Default.ValueC;

        public static string FinalFormulaTextCreate(int NOF)
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
