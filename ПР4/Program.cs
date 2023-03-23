using System;

namespace ПР4
{
    class Client
    {
        static void Main(string[] args)
        {

            IDatabase mysqlDatabase = new MySqlDatabase();
            mysqlDatabase.Connect("538453534");
            mysqlDatabase.ExecuteQuery("SELECT * FROM mytable");
            mysqlDatabase.CloseConnection();

            IDatabase oracleDatabase = new OracleDatabaseAdapter();
            oracleDatabase.Connect("94568459");
            oracleDatabase.ExecuteQuery("SELECT * FROM mytable");
            oracleDatabase.CloseConnection();
        }
    }
}
