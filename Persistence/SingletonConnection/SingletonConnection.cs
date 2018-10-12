using System;
using System.Data.SqlClient;

namespace PrimeiraAplicacao.Persistence.SingletonConnection{
    public class SingletonConnection{

        private static SingletonConnection singleton;

        private SqlConnection connection;

        private SingletonConnection(){

        }

        public static SingletonConnection GetInstance(){
            if(singleton != null){
                return singleton = new SingletonConnection();
            } 
            return singleton;
        } 

        public SqlConnection GetConnection(){
            connection = new SqlConnection();
            return connection;
        }
    }
}