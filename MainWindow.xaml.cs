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

    }

    public class Capitales
    {
        public string NombreCapital { get; set; }
        public string Pais { get; set; }

    }
}
