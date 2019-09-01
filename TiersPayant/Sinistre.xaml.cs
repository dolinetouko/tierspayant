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
    /// Logique d'interaction pour Sinistre.xaml
    /// </summary>
    public partial class Sinistre : Window
    {
        public Sinistre()
        {
            InitializeComponent();
        }


        private void Button_Click(object sender, RoutedEventArgs e)
        {


            String connString = "datasource=localhost;port=3306;username=root;password= ";
            String conn = "datasource=localhost;port=3306;username=root;password= ";
            MySqlCommand cmd;
            string query = "INSERT INTO tierspayant.sinistre (numdossier,numcontrat,accident,declarationmaladie,agence,souscripteur,adresse,assure,malade,debutmaladie,finmaladie,circonstance,responsable,assureur,pvconstat,declaration,totaldent,totalhonoraire) VALUES('" + this.numDossier.Text + "'," +
                "'" + this.numContrat.Text + "','" + this.accident.Text + "','" + this.declarationMaladie.Text + "','" + this.agence.Text + "','" + this.souscripte.Text + "','" + this.adresse.Text + "','" + this.nomAssure.Text + "','" + this.nomMalade.Text + "','" + debutMaladie.Text + "','" + this.finMaladie.Text + "','" + this.circonstance.Text + "'," +
                "'" + this.responsable.Text + "','" + this.nomAssureur.Text + "','" + this.constat.Text + "','" + this.declaration.Text + "','" + this.totalDent.Text + "','" + this.totalHonoraire.Text + "') ";

            string squery = "INSERT INTO tierspayant.prestation (typePrestation,Souscripteur,numeroPolice,echeance,Assure,Matricule,patient,centreDeSoins,date)  VALUES('" + this.Declaration.Text + "','" + this.souscripte.Text + "'," +
        "'" + this.numDossier.Text + "','" + this.finMaladie.Text + "','" + this.nomAssure.Text + "','" + this.numContrat.Text + "','" + this.nomMalade.Text + "','" + this.agence.Text + "','" + this.declaration.Text + "')";

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
        private void Totaliser(object sender, RoutedEventArgs e)
        {
            try
            {
                int montsoindentaire, montprothesedentaire, montorthodontie, montdetartrage, montautresastuces;
                if (montantsoinsdentaires.Text == "")
                {
                    montantsoinsdentaires.Text = "0";

                }
                if (montantprothesesdentaires.Text == "")
                {
                    montantprothesesdentaires.Text = "0";
                }
                if (montantorthodonthie.Text == "")
                {
                    montantorthodonthie.Text = "0";

                }
                if (montantdetartrage.Text == "")
                {
                    montantdetartrage.Text = "0";

                }
                if (montantautresactes.Text == "")
                {
                    montantautresactes.Text = "0";

                }
                montsoindentaire = Int32.Parse(montantsoinsdentaires.Text);
                montprothesedentaire = Int32.Parse(montantprothesesdentaires.Text);
                montorthodontie = Int32.Parse(montantorthodonthie.Text);
                montdetartrage = Int32.Parse(montantdetartrage.Text);
                montautresastuces = Int32.Parse(montantautresactes.Text);

                int totalfinal = montsoindentaire + montprothesedentaire + montorthodontie + montdetartrage + montautresastuces;

                totalHonoraire.Text = totalfinal.ToString();
            }
            catch (Exception x)
            {
                MessageBox.Show(x.Message);
            }
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            PageAccueil page = new PageAccueil();
            page.Show();
            this.Hide();
        }
    }
}
