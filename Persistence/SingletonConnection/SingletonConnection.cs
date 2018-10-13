using System;
using System.Data.SqlClient;
using Microsoft.Extensions.Configuration;

namespace PrimeiraAplicacao.Persistence.SingletonConnection
{
    public class SingletonConnection
    {

        private static SingletonConnection singleton;

        private SqlConnection connection;

        public static SingletonConnection GetInstance()
        {
            if (singleton != null)
            {
                return singleton;
            }
            return singleton = new SingletonConnection();
        }

        public SqlConnection GetConnection(IConfiguration configuration)
        {
                // SqlConnectionStringBuilder builder = new SqlConnectionStringBuilder();
                // builder.DataSource = "localhost";
                // builder.UserID = "sa";              // update me
                // builder.Password = "Admin1234";      // update me
                // builder.InitialCatalog = "playlist";
                connection = new SqlConnection(configuration.GetConnectionString("MyConnectionString"));;
                return connection;
        }
    }
}