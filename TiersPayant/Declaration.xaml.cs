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
using Finisar.SQLite;
using System.Data.SqlClient;
using MySql.Data.MySqlClient;

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

       
        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            String connString = "datasource=localhost;port=3306;username=root;password= ";
            MySqlCommand cmd;



            MySqlConnection connection;
            connection = new MySqlConnection(connString);

            try
            {
                connection.Open();
                String query = "truncate table tierspayant.prestation";
                cmd = new MySqlCommand(query, connection);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Suppréssion réussie");


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            PageAccueil pageAccueil = new PageAccueil();
            pageAccueil.Show();
            this.Hide();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            this.Hide();
        }
    }
}
