namespace ChartViewer.Functions
{
    internal class CheckBoolean
    {
        public static void IsReady(TextBox TextBox, bool Status)
        {
            if (Status)
            {
                TextBox.Text = "Готово";
                TextBox.Foreground = Brushes.Green;
            }

            else
            {
                TextBox.Text = "Не готово";
                TextBox.Foreground = Brushes.Red;
            }

        }
    }
}
