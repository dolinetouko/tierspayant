using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using MySql.Data.MySqlClient;
using System.Threading.Tasks;

namespace TiersPayant
{
    class Connexion
    {
        private static MySqlConnection connection;
        /*private static MySqlCommand cmd;
        private static DataTable dt;
        private static MySqlDataAdapter sda;*/

        public static void EtablirConnexion()
        {
            try
            {
                MySqlConnectionStringBuilder builder = new MySqlConnectionStringBuilder();
                builder.Server = "localhost";
                builder.UserID = "root";
                builder.Password = "";
                builder.Database = "tierspayant";
                builder.SslMode = MySqlSslMode.None;
                connection = new MySqlConnection(builder.ToString());
                Console.WriteLine("data connection successful");
                /*Message.Show("Database connection successful","connection",MessageBoxButton);*/
            }
            catch(Exception ex)
            {
                Console.WriteLine("Connection failed");
            }
        }
    }
}
