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
            int filas = 3, columnas = 3, numero = 1;

            for (int i = 1; i <= filas; i++)
            {
                Button b1 = null;
                for (int j = 0; j < columnas; j++)
                {
                    b1 = new Button
                    {
                        Tag = numero,
                        Content = new Viewbox
                        {
                            Child = new TextBlock { Text = $"{numero}" }
                        }
                    };
                    numero++;
                    Grid.SetRow(b1, i);
                    Grid.SetColumn(b1, j);
                    tabla.Children.Add(b1);
                }
            }





        }


    }
}
