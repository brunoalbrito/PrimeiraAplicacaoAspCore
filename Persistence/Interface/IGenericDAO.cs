using System;
using System.Collections;
using PrimeiraAplicacao.Models;

namespace PrimeiraAplicacao.Persistence.Interface
{
    public interface IGenericDAO<T>
    {
        bool AddMusica();
        T FindById(int id);

        IList FindAll();

        bool Update(T t);

        bool Remove(T t);

    }
}