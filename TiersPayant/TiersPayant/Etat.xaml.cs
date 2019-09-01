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
using MySql.Data.MySqlClient;

namespace TiersPayant
{
    /// <summary>
    /// Logique d'interaction pour Etat.xaml
    /// </summary>
    public partial class Etat : Window
    {
        public Etat(string id,string typePrestation, string sous, string echea, string ass, string mat, string pat, string center, string dat)
        {
            InitializeComponent();
            idprestation.Text = id;
            type.Text = typePrestation;
            souscripteur.Text = sous;
            echeance.Text = echea;
            assure.Text = ass;
            matricule.Text = mat;
            patient.Text = pat;
            centre.Text = center;
            date.Text = dat;
        }

        //permet de modifier un champ
        private void Modifier(object sender, RoutedEventArgs e)
        {
            String connString = "datasource=localhost;port=3306;username=root;password= ";
            MySqlCommand cmd;



            MySqlConnection connection;
            connection = new MySqlConnection(connString);
            try
            {
                connection.Open();
                String sql = "Update tierspayant.prestation set typePrestation = '" + this.type.Text + "',souscripteur='" + this.souscripteur.Text + "'," +
                    " echeance ='" + this.echeance.Text + "',Assure='" + this.assure.Text + "',Matricule ='" + this.matricule.Text + "'," +
                    "patient ='" + this.patient.Text + "',centreDeSoins='" + this.centre.Text + "' ,date='" + this.date.Text + "' Where idPrestation = '" + this.idprestation.Text + "'  ";

                cmd = new MySqlCommand(sql, connection);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Modification réussie");
                

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            PageAccueil pageAccueil = new PageAccueil();
            pageAccueil.Show();
            this.Hide();
        }

        //permet de supprimer un champ
        private void Supprimer(object sender, RoutedEventArgs e)
        {
            String connString = "datasource=localhost;port=3306;username=root;password= ";
            MySqlCommand cmd;



            MySqlConnection connection;
            connection = new MySqlConnection(connString);
            try
            {
                connection.Open();
                String sql = "Delete From tierspayant.prestation where idPrestation = '" + this.idprestation.Text + "' ";

                cmd = new MySqlCommand(sql, connection);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Suppression réussie");
               

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Retour(object sender, RoutedEventArgs e)
        {
            PageAccueil page = new PageAccueil();
            page.Show();
            this.Hide();
        }
    }
}
