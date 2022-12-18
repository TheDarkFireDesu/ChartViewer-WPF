namespace ChartViewer.Functions
{
    internal class CheckBoolean
    {
        public static void IsReady(TextBox textBox, bool status)
        {
            if (status)
            {
                textBox.Text = "Готово";
                textBox.Foreground = Brushes.Green;
            }

            else
            {
                textBox.Text = "Не готово";
                textBox.Foreground = Brushes.Red;
            }
        }

        public static void IsActive(Button button, bool status)
        {
            if (status)
            {
                button.IsEnabled = true;
            }
            else
            {
                button.IsEnabled = false;
            }
        }
    }
}
