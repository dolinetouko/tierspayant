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
    /// Logique d'interaction pour FeuilleDeSoins.xaml
    /// </summary>
    public partial class FeuilleDeSoins : Window
    {
        public FeuilleDeSoins()
        {
            InitializeComponent();
        }
        /// <summary>
        /// Enregistrer qui permet inserer les valeurs dans la table feuilles de soins et prestation
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            String connString = "datasource=localhost;port=3306;username=root;password= ";
            String conn = "datasource=localhost;port=3306;username=root;password= ";
            MySqlCommand cmd;
            string query = "INSERT INTO tierspayant.feuillesoins (souscripteur,numpolice,echeance,assure,matricule,patient,centre,totalcons,totalord,totalgnr,date) VALUES('" + this.Souscripteur.Text + "'," +
                "'" + this.NumPolice.Text + "','" + this.Echeance.Text + "','" + this.Assure.Text + "','" + this.Matricule.Text + "','" + this.Patient.Text + "','" + this.CentreDeSoins.Text + "','" + this.TotalConsultations.Text + "'," +
                "'" + this.totalord.Text + "','" + this.totalGeneral.Text + "','" + this.date.Text + "') ";

            string squery = "INSERT INTO tierspayant.prestation (typePrestation,Souscripteur,numeroPolice,echeance,Assure,Matricule,patient,centreDeSoins,date)  VALUES('" + this.Consultation.Text + "','" + this.Souscripteur.Text + "'," +
            "'" + this.NumPolice.Text + "','" + this.Echeance.Text + "','" + this.Assure.Text + "','" + this.Matricule.Text + "','" + this.Patient.Text + "','" + this.CentreDeSoins.Text + "','" + this.date.Text + "')";

            MySqlConnection connection;
            MySqlConnection connexion;
            connection = new MySqlConnection(connString);
            connexion = new MySqlConnection(conn);
            cmd = new MySqlCommand(query, connection);
            MySqlCommand command = new MySqlCommand(squery, connexion);
            // adapter = new MySqlDataAdapter(query,connection);
            MySqlDataReader myReader;
            MySqlDataReader Reader;
            try
            {
                connection.Open();
                connexion.Open();
                myReader = cmd.ExecuteReader();
                Reader = command.ExecuteReader();
                MessageBox.Show("Enregistrer");
                
                connection.Close();
                connexion.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        //permet de retourner à la page d'accueil
        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            PageAccueil accueil = new PageAccueil();
            accueil.Show();
            this.Hide();
        }
    }
}
