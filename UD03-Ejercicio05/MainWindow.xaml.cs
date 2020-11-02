using System.Windows;
using System.Windows.Controls;


namespace UD03_Ejercicio05
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            textoTextBlock.Text += (sender as Button).Tag.ToString();
        }
    }
}
