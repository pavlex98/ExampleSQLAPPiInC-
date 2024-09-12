using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExampleSQLApp
{
    internal class DB
    {
        MySqlConnection connection = new MySqlConnection("server=localhost;port=3306;username=root;password=root;database=firstDB");

        public void openConnection()
        {
            if (connection.State == System.Data.ConnectionState.Closed)
            {
                Console.WriteLine("no");
                connection.Open();
            }
        }
        public void closedConnection()
        {
            if (connection.State == System.Data.ConnectionState.Open)
            {
                Console.WriteLine("yes");
                connection.Close();
            }
        }
        public MySqlConnection getConnect()
        {
            return connection;
        }
    }

}
