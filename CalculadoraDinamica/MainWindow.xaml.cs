using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace CalculadoraDinamica
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            int num = 1;
            for (int fila = 1; fila < 4; fila++)
            {
                for (int c = 0; c < 3; c++)
                {
                    TextBlock t = new TextBlock();
                    t.Text = num.ToString();
                    Viewbox v = new Viewbox();
                    v.Child = t;

                    Button boton = new Button();
                    boton.Margin = new Thickness(5);
                    boton.Click += Button_Click;
                    boton.Tag = num;
                    Grid.SetColumn(boton, c);
                    Grid.SetRow(boton, fila);
                    boton.Content = v;

                    contenedor.Children.Add(boton);
                    num++;
                }
            }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            ResultadoTextBlock.Text += ((Button)sender).Tag.ToString();
        }
    }
}
