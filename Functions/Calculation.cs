namespace ChartViewer.Functions
{
    public static class Calculation
    {
        private static Collection<double>? data_y;
        static int NOF = Properties.Settings.Default.NOF;

        public static Collection<double> CalculateFunction()
        {
            double a = Properties.Settings.Default.ValueA;
            double b = Properties.Settings.Default.ValueB;
            double c = Properties.Settings.Default.ValueC;
            double d = Properties.Settings.Default.ValueD;


            data_y = NOF switch
            {
                1 => Basic.LinearFunction(),

                2 => Polynomial.QuadraticFunction(),
                3 => Polynomial.CubicFunction(),
                4 => Polynomial.BiquadFunction(),

                5 => Exponential.ExponentFunction(),
                6 => Exponential.ExponentcialFunction(),

                7 => Logarithmic.LogFunction(),
                8 => Logarithmic.LogDecimalFunction(),
                9 => Logarithmic.LogNaturalFunction(),

                10 => Power.PowFunction(),

                11 => Trigonometric.SinFunction(),
                12 => Trigonometric.CosFunction(),
                13 => Trigonometric.TgFunction(),
                14 => Trigonometric.CtgFunction(),
                15 => Trigonometric.SecFunction(),
                16 => Trigonometric.CscFunction(),

                17 => ReverseTrigonometric.ArcSinFunction(),
                18 => ReverseTrigonometric.ArcCosFunction(),
                19 => ReverseTrigonometric.ArcTgFunction(),
                20 => ReverseTrigonometric.ArcCtgFunction(),
                21 => ReverseTrigonometric.ArcSecFunction(),
                22 => ReverseTrigonometric.ArcCscFunction(),

                //23 =>,
                24 => Special.AbsFunction(),

                25 => Hyperbolic.HyperSinFunction(),
                26 => Hyperbolic.HyperCosFunction(),
                27 => Hyperbolic.HyperTgFunction(),
                28 => Hyperbolic.HyperCtgFunction(),
                29 => Hyperbolic.HyperSecFunction(),
                30 => Hyperbolic.HyperCscFunction(),

                31 => ReverseHyperbolic.AreaSinFunction(),
                32 => ReverseHyperbolic.AreaCosFunction(),
                33 => ReverseHyperbolic.AreaTgFunction(),
                34 => ReverseHyperbolic.AreaCtgFunction(),
                35 => ReverseHyperbolic.AreaSecFunction(),
                36 => ReverseHyperbolic.AreaCscFunction(),

                37 => AdvancedTrigonometric.VerSinFunction(),
                38 => AdvancedTrigonometric.VerCosFunction(),
                39 => AdvancedTrigonometric.HaverSinFunction(),
                40 => AdvancedTrigonometric.HaverCosFunction(),
                41 => AdvancedTrigonometric.ExSecFunction(),
                42 => AdvancedTrigonometric.ExCscFunction(),
                _ => throw new NotImplementedException(),
            };

            return data_y;
        }
    }
}
