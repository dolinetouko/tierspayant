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
    /// Logique d'interaction pour Laboratoire.xaml
    /// </summary>
    public partial class Laboratoire : Window
    {
        public Laboratoire()
        {
            InitializeComponent();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
        String connString = "datasource=localhost;port=3306;username=root;password= ";
            String conn = "datasource=localhost;port=3306;username=root;password= ";
            MySqlCommand cmd;
        string query = "INSERT INTO tierspayant.laboratoire (souscripteur,numpolice,echeance,assure,matricule,patient,centre,mntlabo,mntimagerie,mntoptique,mntautres,totalgnr,date) VALUES('" + this.Souscripteur.Text + "'," +
            "'" + this.NumPolice.Text + "','" + this.Echeance.Text + "','" + this.Assure.Text + "','" + this.Matricule.Text + "','" + this.Patient.Text + "','" + this.CentreDeSoins.Text + "','" + this.TotalLaboratoire.Text + "'," +
            "'" + this.TotalImagerie.Text + "','" + this.TotalOptiques.Text + "','" + this.TotalAutres.Text + "','" + this.totalgeneral.Text + "','" + this.date.Text + "') ";

            string squery = "INSERT INTO tierspayant.prestation (typePrestation,Souscripteur,numeroPolice,echeance,Assure,Matricule,patient,centreDeSoins,date)  VALUES('" + this.prescription.Text + "','" + this.Souscripteur.Text + "'," +
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

        private void totallaboratoire(object sender, RoutedEventArgs e)
        {
            try
            {
                int montlab1, montlab2, montlab3, montlab4, montlab5;
                if (MontantLaboratoire1.Text == "")
                {
                    MontantLaboratoire1.Text = "0";

                }
                if (MontantLaboratoire2.Text == "")
                {
                    MontantLaboratoire2.Text = "0";
                }
                if (MontantLaboratoire3.Text == "")
                {
                    MontantLaboratoire3.Text = "0";

                }
                if (MontantLaboratoire4.Text == "")
                {
                    MontantLaboratoire4.Text = "0";

                }
                if (MontantLaboratoire5.Text == "")
                {
                    MontantLaboratoire5.Text = "0";

                }
                montlab1 = Int32.Parse(MontantLaboratoire1.Text);
                montlab2 = Int32.Parse(MontantLaboratoire2.Text);
                montlab3 = Int32.Parse(MontantLaboratoire3.Text);
                montlab4 = Int32.Parse(MontantLaboratoire4.Text);
                montlab5 = Int32.Parse(MontantLaboratoire5.Text);

                int numberfinal = montlab1 + montlab2 + montlab3 + montlab4 + montlab5;

                TotalLaboratoire.Text = numberfinal.ToString();
            }
            catch (Exception x)
            {
                MessageBox.Show(x.Message);
            }

        }



        private void totalimagerie(object sender, RoutedEventArgs e)
        {

            try
            {
                int montimg1, montimg2, montimg3, montimg4, montimg5;
                if (MontantImagerie1.Text == "")
                {
                    MontantImagerie1.Text = "0";

                }
                if (MontantImagerie2.Text == "")
                {
                    MontantImagerie2.Text = "0";
                }
                if (MontantImagerie3.Text == "")
                {
                    MontantImagerie3.Text = "0";

                }
                if (MontantImagerie4.Text == "")
                {
                    MontantImagerie4.Text = "0";

                }
                if (MontantImagerie5.Text == "")
                {
                    MontantImagerie5.Text = "0";

                }
                montimg1 = Int32.Parse(MontantImagerie1.Text);
                montimg2 = Int32.Parse(MontantImagerie2.Text);
                montimg3 = Int32.Parse(MontantImagerie3.Text);
                montimg4 = Int32.Parse(MontantImagerie4.Text);
                montimg5 = Int32.Parse(MontantImagerie5.Text);

                int imgfinal = montimg1 + montimg2 + montimg3 + montimg4 + montimg5;

                TotalImagerie.Text = imgfinal.ToString();
            }
            catch (Exception x)
            {
                MessageBox.Show(x.Message);
            }

        }

        private void totaloptiques(object sender, RoutedEventArgs e)
        {

            try
            {
                int montopt1, montopt2, montopt3, montopt4, montopt5;
                if (MontantOptiques1.Text == "")
                {
                    MontantOptiques1.Text = "0";

                }
                if (MontantOptiques2.Text == "")
                {
                    MontantOptiques2.Text = "0";
                }
                if (MontantOptiques3.Text == "")
                {
                    MontantOptiques3.Text = "0";

                }
                if (MontantOptiques4.Text == "")
                {
                    MontantOptiques4.Text = "0";

                }
                if (MontantOptiques5.Text == "")
                {
                    MontantOptiques5.Text = "0";

                }
                montopt1 = Int32.Parse(MontantOptiques1.Text);
                montopt2 = Int32.Parse(MontantOptiques2.Text);
                montopt3 = Int32.Parse(MontantOptiques3.Text);
                montopt4 = Int32.Parse(MontantOptiques4.Text);
                montopt5 = Int32.Parse(MontantOptiques5.Text);

                int optfinal = montopt1 + montopt2 + montopt3 + montopt4 + montopt5;

                TotalOptiques.Text = optfinal.ToString();
            }
            catch (Exception x)
            {
                MessageBox.Show(x.Message);
            }

        }

        private void totalautres(object sender, RoutedEventArgs e)
        {

            try
            {
                int montaut1, montaut2, montaut3, montaut4, montaut5;
                if (MontantAutres1.Text == "")
                {
                    MontantAutres1.Text = "0";

                }
                if (MontantAutres2.Text == "")
                {
                    MontantAutres2.Text = "0";
                }
                if (MontantAutres3.Text == "")
                {
                    MontantAutres3.Text = "0";

                }
                if (MontantAutres4.Text == "")
                {
                    MontantAutres4.Text = "0";

                }
                if (MontantAutres5.Text == "")
                {
                    MontantAutres5.Text = "0";

                }
                montaut1 = Int32.Parse(MontantAutres1.Text);
                montaut2 = Int32.Parse(MontantAutres2.Text);
                montaut3 = Int32.Parse(MontantAutres3.Text);
                montaut4 = Int32.Parse(MontantAutres4.Text);
                montaut5 = Int32.Parse(MontantAutres5.Text);

                int autfinal = montaut1 + montaut2 + montaut3 + montaut4 + montaut5;

                TotalAutres.Text = autfinal.ToString();
            }
            catch (Exception x)
            {
                MessageBox.Show(x.Message);
            }

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            PageAccueil page = new PageAccueil();
            page.Show();
            this.Hide();
        }
        private void MT_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                if (TotalLaboratoire.Text == "")
                {
                    TotalLaboratoire.Text = "0";
                }
                if (TotalImagerie.Text == "")
                {
                    TotalImagerie.Text = "0";
                }
                if (TotalOptiques.Text == "")
                {
                    TotalOptiques.Text = "0";
                }
                if (TotalAutres.Text == "")
                {
                    TotalAutres.Text = "0";
                }
                int lab = Int32.Parse(TotalLaboratoire.Text);
                int img = Int32.Parse(TotalImagerie.Text);
                int opt = Int32.Parse(TotalOptiques.Text);
                int aut = Int32.Parse(TotalAutres.Text);
                int totgen = lab + img + opt + aut;
                totalgeneral.Text = totgen.ToString();
            }
            catch (Exception b)
            {

            }
        }

       
    }
}
