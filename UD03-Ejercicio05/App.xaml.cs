using System;
using System.Windows;
using System.Windows.Controls;

namespace UD03_Ejercicio05
{
    public partial class App : Application
    {


        private void Button_Click(object sender, RoutedEventArgs e)
        {
            (MainWindow as MainWindow).textoTextBlock.Text += (sender as Button).Tag.ToString();
        }
    }
}
