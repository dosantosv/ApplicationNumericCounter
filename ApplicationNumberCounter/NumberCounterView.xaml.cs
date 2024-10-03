using System.Windows;

namespace ApplicationNumberCounter
{
    /// <summary>
    /// Interaction logic for NumberCounterView.xaml
    /// </summary>
    public partial class NumberCounterView : Window
    {

        private int _counter;
        public NumberCounterView()
        {
            InitializeComponent();
        }

        private void Button_Decrease_Click(object sender, RoutedEventArgs e)
        {
            _counter--;
            UpdateCounter();
        }

        private void Button_Increase_Click(object sender, RoutedEventArgs e)
        {
            _counter++;
            UpdateCounter();
        }

        private void Button_Reset_Click(object sender, RoutedEventArgs e)
        {
            _counter = 0;
            UpdateCounter();
        }

        private void UpdateCounter()
        {
            txtCounter.Text = _counter.ToString();
        }
    }
}
