using System.Windows;

namespace Wpf_FirstApp
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        bool variabile = true;
        public MainWindow()
        {
            InitializeComponent();
        }
        private void btnRun1_Click(object sender, RoutedEventArgs e)
        {
            if (variabile)
            {
                tbHello.Text = "Stopped";
                btnRun1.Content = "Run";
            }
            else
            {
                tbHello.Text = "Running";
                btnRun1.Content = "Stop";
            }

            variabile = !variabile;
        }
    }
}