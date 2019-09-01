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

namespace TiersPayant
{
    /// <summary>
    /// Logique d'interaction pour MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            Connexion.EtablirConnexion();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {

            //string query = "Select count(1) From";
            PageAccueil pageAccueil = new PageAccueil();
            pageAccueil.Show();
            this.Hide();
        }
        private void Button_Close(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();

        }

    }
}
