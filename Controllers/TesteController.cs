using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using System.Web.Http;
using PrimeiraAplicacao.Models;

namespace PrimeiraAplicacao.Controllers
{
    [Route("api/teste")]
    public class TesteController : Controller
    {

        [Route("get")]
        public string GetTest()
        {
            Musica mus = new Musica();
            mus.Nome = "FRIENDS";
            return mus.Nome;
        }
    }
}