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
using System.Windows.Shapes;

namespace TiersPayant
{
    /// <summary>
    /// Logique d'interaction pour Declaration.xaml
    /// </summary>
    public partial class Declaration : Window
    {
        public String souscripteur;
        public String nom;
        public String matricule;
        public String centre;
        public int police;
        public String echeance;
        public String prestation;
        

        public Declaration()
        {
            InitializeComponent();
        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
