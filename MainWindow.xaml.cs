using System.Collections.Generic;
using System.Windows;

namespace WFPComboBox
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            List<Capitales> ListaCapitales = new List<Capitales>();

            ListaCapitales.Add(new Capitales { NombreCapital = "Buenos Aires," + " ", Pais = "Argetina" });
            ListaCapitales.Add(new Capitales { NombreCapital = "Caracas," + " ", Pais = "Venezuela" });
            ListaCapitales.Add(new Capitales { NombreCapital = "Bogota," + " ", Pais = "Colombia" });
            ListaCapitales.Add(new Capitales { NombreCapital = "Sao Paulo," + " ", Pais = "Brasil" });
            ListaCapitales.Add(new Capitales { NombreCapital = "Madrid," + " ", Pais = "España" });

            Capitales.ItemsSource = ListaCapitales;
        }

        private void TodasC_Checked(object sender, RoutedEventArgs e)
        {
            BuenosAires.IsChecked = true;
            Caracas.IsChecked = true;
            Bogota.IsChecked = true;
            SaoPaulo.IsChecked = true;
            Madrid.IsChecked = true;
        }

        private void TodasC_Unchecked(object sender, RoutedEventArgs e)
        {
            BuenosAires.IsChecked = false;
            Caracas.IsChecked = false;
            Bogota.IsChecked = false;
            SaoPaulo.IsChecked = false;
            Madrid.IsChecked = false;
        }

        private void IndividualChecked(object sender, RoutedEventArgs e)
        {
            if (BuenosAires.IsChecked == true && Caracas.IsChecked == true && Bogota.IsChecked == true && SaoPaulo.IsChecked == true && Madrid.IsChecked == true)
            {
                TodasC.IsChecked = true;
            }
            else
            {
                TodasC.IsChecked = null;
            }
        }

        private void IndividualNotChecked(object sender, RoutedEventArgs e)
        {
            if (BuenosAires.IsChecked == false && Caracas.IsChecked == false && Bogota.IsChecked == false && SaoPaulo.IsChecked == false && Madrid.IsChecked == false)
            {
                TodasC.IsChecked = false;
            }
            else
            {
                TodasC.IsChecked = null;
            }

        }



    }

    public class Capitales
    {
        public string NombreCapital { get; set; }
        public string Pais { get; set; }

    }
}
