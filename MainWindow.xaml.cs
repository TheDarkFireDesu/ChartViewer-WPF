using ChartViewer;
using LiveChartsCore;
using LiveChartsCore.SkiaSharpView;
using LiveChartsCore.Themes;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Reflection;
using System.Windows;
using System.Windows.Controls;

namespace ChartViewer
{
    public partial class MainWindow : Window
    {

        public double x = 0;
        public double y = 0;

        public double a = 0;
        public double b = 0;
        public double c = 0;

        bool IsLinear = false;

        public List<double> data = new List<double>();
        public double[] data_array = new double[200];

        public MainWindow()
        {
            InitializeComponent();
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

        private void ComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            ComboBox comboBox = (ComboBox)sender;
            int index = comboBox.SelectedIndex;

            ComboBoxItem selectedItem = (ComboBoxItem)comboBox.SelectedItem;

            //MessageBox.Show(selectedItem.Content.ToString());
           // MessageBox.Show(index.ToString());

            switch (index)
            {
                case 0:
                    break;

                case 1:
                    IsLinear = true;
                    func_Label.Content = $"y = {a}x + {b}";
                    break;

                case 2:
                    func_Label.Content = $"y = {a}x^2 + {b}x + {c}";
                    break;

                case 3:
                    func_Label.Content = $"y = e^{a}";
                    break;

                default:
                    func_Label.Content = "";
                    break;
            }
        }

        private void Calculate_Button_Click(object sender, RoutedEventArgs e)
        {
               // if (IsLinear == true)
               // {
                    data = FuncGraphCalc.LinearFunction(a, b);
                    data_array = data.ToArray();
               // }
        }

        private void Show_Button_Click(object sender, RoutedEventArgs e)
        {
            var seriesCollection = new ObservableCollection<ISeries>();
            var newLineSeries = FuncGraphCalc.GetLineSeries(data_array);

            MessageBox.Show(data.ToString());
            MessageBox.Show(data_array.ToString());

            CartesianChart_Main.Series = seriesCollection;
            seriesCollection.Add(newLineSeries);
        }
    }
}