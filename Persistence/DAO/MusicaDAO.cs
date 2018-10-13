using System;
using System.Collections;
using System.Data.SqlClient;
using PrimeiraAplicacao.Persistence.Interface;
using PrimeiraAplicacao.Models;

namespace PrimeiraAplicacao.Persistence.DAO{
    public class MusicaDAO : IGenericDAO<Musica>
    {

        public bool AddMusica()
        {
            throw new NotImplementedException();
        }

        public IList FindAll()
        {
            throw new NotImplementedException();
        }

        public Musica FindById(int id)
        {
            throw new NotImplementedException();
        }

        public bool Remove(Musica t)
        {
            throw new NotImplementedException();
        }

        public bool Update(Musica t)
        {
            throw new NotImplementedException();
        }
    }
}