using System.Collections.Generic;
using PrincipiosDDD.Domain.Entities;
using PrincipiosDDD.Domain.Interfaces;
using PrincipiosDDD.Infra.Data.Context;

namespace PrincipiosDDD.Infra.Data.Repository
{
    public class WorkerRepository : BaseRepository<Worker, int>, IRepositoryWorker
    {
        public WorkerRepository(MySqlContext mySqlContext) : base(mySqlContext)
        {
        }

        public void Remove(int id) =>
            base.Delete(id);


        public void Save(Worker obj)
        {
            if (obj.Id == 0)
                base.Insert(obj);
            else
                base.Update(obj, _mySqlContext.Entry(obj).Property(prop => prop.Password));
        }

        public Worker GetById(int id) =>
            base.Select(id);

        public IList<Worker> GetAll() =>
            base.Select();

    }
}
