using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel.Const
{
    static class Const
    {
        static public string stroka_parol = "server=localhost;port=3306;username=root;database=hotel;";

        static public void openConnection()
        {
            MySqlConnection connection = new MySqlConnection(stroka_parol);
            if (connection.State == System.Data.ConnectionState.Closed)
            {
                connection.Open();
            }

        }

        static public void closeConnection()
        {
            MySqlConnection connection = new MySqlConnection(stroka_parol);
            if (connection.State == System.Data.ConnectionState.Open)
            {
                connection.Close();
            }

        }
        static public MySqlConnection getConnection()
        {
            MySqlConnection connection = new MySqlConnection(stroka_parol);
            return connection;
        }

        static public void openConnection(MySqlConnection connection)
        {
            if (connection.State == System.Data.ConnectionState.Closed)
            {
                connection.Open();
            }

        }

        static public void closeConnection(MySqlConnection connection)
        {
            if (connection.State == System.Data.ConnectionState.Open)
            {
                connection.Close();
            }

        }
        static public MySqlConnection getConnection(MySqlConnection connection)
        {
            return connection;
        }


    }
}
