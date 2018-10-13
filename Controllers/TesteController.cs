using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using System.Web.Http;
using PrimeiraAplicacao.Models;
using Microsoft.Extensions.Configuration;
using PrimeiraAplicacao.Persistence.SingletonConnection;
using System.Data.SqlClient;

namespace PrimeiraAplicacao.Controllers
{

    [Route("api/teste")]
    public class TesteController : Controller
    {
        private readonly IConfiguration _configuration;
        public TesteController(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        [Route("get")]
        public string GetTest()
        {
            Musica mus = new Musica();
            mus.Nome = "FRIENDS";
            var connection = SingletonConnection.GetInstance().GetConnection(_configuration);
            string sql = "INSERT INTO musica(nome,autor, duracao)VALUES('all of me', 'bruno', '3:15')";
            SqlCommand command = new SqlCommand(sql, connection);
            connection.Open();
            var status = command.ExecuteNonQuery().ToString();
            connection.Close();

            return status;
        }
    }
}