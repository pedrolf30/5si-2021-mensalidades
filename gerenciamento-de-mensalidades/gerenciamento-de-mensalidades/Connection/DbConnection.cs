using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace gerenciamento_de_mensalidades.Connection
{
    class DbConnection
    {
        public static MySqlConnection getConnection()
        {
            String connectionString = ConfigurationManager.ConnectionStrings["gerenciamento-de-mensalidades.Properties.Settings.crudConnectionString"].ConnectionString;
            
            MySqlConnection conn = new MySqlConnection(connectionString);

            return conn;
        }
    }
}
