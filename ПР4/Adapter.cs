using MySql.Data.MySqlClient;
using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.Text;

namespace ПР4
{
    public interface IDatabase
    {
        void Connect(string connectionString);

        void CloseConnection();
        void ExecuteQuery(string query);
    }

    public class MySqlDatabase : IDatabase
    {
        private MySqlConnection connection;

        public void Connect(string connectionString)
        {
           //connection = new MySqlConnection(connectionString);
            Console.WriteLine($"Подключение к базе данных MySQL {connectionString} выполнено успешно.");
        }

        public void ExecuteQuery(string query)
        {
            Console.WriteLine($"Выполнение запроса '{query}' к базе данных");
        }

        public void CloseConnection() 
        {
            Console.WriteLine($"Подключение к базе данных MySQL разорвано.");
        }

    }

    public class OracleDatabaseAdapter : IDatabase
    {
        private OracleConnection connection;

        public void Connect(string connectionString)
        {
            //connection = new OracleConnection(connectionString);
            Console.WriteLine($"Подключение к базе данных Oracle {connectionString} выполнено успешно.");
        }

        public void ExecuteQuery(string query)
        {
            Console.WriteLine($"Выполнение запроса '{query}' к базе данных");
        }

        public void CloseConnection()
        {
            Console.WriteLine($"Подключение к базе данных Oracle разорвано.");
        }
    }
}
