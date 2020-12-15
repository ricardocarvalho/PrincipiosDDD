using System.Collections.Generic;
using PrincipiosDDD.Domain.Entities;

namespace PrincipiosDDD.Domain.Interfaces
{
    public interface IRepositoryWorker
    {
        void Save(Worker obj);

        void Remove(int id);

        Worker GetById(int id);

        IList<Worker> GetAll();
    }
}

