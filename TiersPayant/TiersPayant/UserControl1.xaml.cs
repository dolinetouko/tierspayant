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
using MySql.Data.MySqlClient;
using System.Data;

namespace TiersPayant
{
    /// <summary>
    /// Logique d'interaction pour UserControl1.xaml
    /// </summary>



    public partial class UserControl1 : UserControl
    {

        private string idprestation;
        private string type;
        private static string souscripte;
        private static string Echeance;
        private static string Assure;
        private static string Matricule;
        private static string Patient;
        private static string Centre;
        private static string Date;
        public UserControl1()
        {
            InitializeComponent();
            String connString = "datasource=localhost;port=3306;username=root;password= ";
            MySqlCommand cmd;



            MySqlConnection connection;
            connection = new MySqlConnection(connString);

            try
            {
                connection.Open();
                String query = "Select idPrestation,typePrestation,Souscripteur,numeroPolice,echeance,Assure,Matricule,patient,centreDeSoins,date FROM tierspayant.prestation";
                cmd = new MySqlCommand(query, connection);
                cmd.ExecuteNonQuery();

                MySqlDataAdapter dataAdp = new MySqlDataAdapter(cmd);
                DataTable dt = new DataTable("tierspayant");
                dataAdp.Fill(dt);
                DataGrid.ItemsSource = dt.DefaultView;
                dataAdp.Update(dt);


                connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        //affichage fiche de declaration sinistre
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Sinistre declaration = new Sinistre();
            declaration.Show();
        }//affichage fiche d'hospitalisation
        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            Hospitalisation hospitalisation = new Hospitalisation();
            hospitalisation.Show();
        }
        //affichage fiche de laboratoire
        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            Laboratoire labo = new Laboratoire();
            labo.Show();
        }
        //affichage fiche de feuille de soins
        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            FeuilleDeSoins feuille = new FeuilleDeSoins();
            feuille.Show();
        }

     

        //confirmation de suppressio,
        private void Button_Supprimer(object sender, RoutedEventArgs e)
        {

            Declaration declaration = new Declaration();
            declaration.Show();


        }

        //permet de recuperer les informations d'un champ selectionné dans le datagrid
        private void DataGrid_SelectionChanged(object sender, RoutedEventArgs e)
        {

            afficher.IsEnabled = true;
            DataGrid dg = sender as DataGrid;
                    DataRowView Dr = dg.SelectedItem as DataRowView;

                    if (Dr != null)
                    {

                        idprestation = Dr["idPrestation"].ToString();
                        type = Dr["typePrestation"].ToString();
                        souscripte = Dr["souscripteur"].ToString();
                        Echeance = Dr["echeance"].ToString();
                        Assure = Dr["Assure"].ToString();
                        Matricule = Dr["Matricule"].ToString();
                        Patient = Dr["patient"].ToString();
                        Centre = Dr["centreDeSoins"].ToString();
                        Date = Dr["date"].ToString();

                    }


        }
            
        //envoi et affichage des informations d'un champ
    private void Button_Click_4(object sender, RoutedEventArgs e)
        {

            Etat etat = new Etat(idprestation, type, souscripte, Echeance, Assure, Matricule, Patient, Centre, Date);
            etat.Show();
            
        }

        //selectionner tous les champs
        private void CheckBox_Checked(object sender, RoutedEventArgs e)
        {
            DataGrid.SelectAllCells();
            supprimer.IsEnabled = true;
            afficher.IsEnabled = false;
            //chk.IsChecked = true;
        }

        /* private void chkValue(object sender, RoutedEventArgs e)
         {


            int i = DataGrid.SelectedIndex;

              var dataGridCellInfo = new DataGridCellInfo(
      DataGrid.Items[i], DataGrid.Columns[2]);


              Console.WriteLine(DataGrid.Items[i]);
              Console.WriteLine(DataGrid.Columns[2]);
              Console.WriteLine(dataGridCellInfo);

           chk.IsChecked = true;

         }*/



        //deselectionner tous les champs
        private void CheckBox_Unchecked(object sender, RoutedEventArgs e)
        {
            DataGrid.UnselectAllCells();
            supprimer.IsEnabled = false;
            afficher.IsEnabled = false;
        }
       
         
    


        private void chkclick(object sender, RoutedEventArgs e)
        {

            CheckBox chk = sender as CheckBox;
            bool check = chk.IsChecked.Value;
            if (check)
            {

                //chk = DataGrid.Columns[0].GetCellContent(p) as CheckBox;
                if (chk != null)
                    chk.IsChecked = true;

            }
            else
            {

                //chk = DataGrid.Columns[0].GetCellContent(p) as CheckBox;
                if (chk != null)
                    chk.IsChecked = false;

            }

        }

      
        private void supprimer_Elements(object sender, RoutedEventArgs e)
        {

        }
    }
}
