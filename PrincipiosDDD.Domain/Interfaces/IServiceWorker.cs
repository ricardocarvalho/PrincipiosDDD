using System.Collections.Generic;
using PrincipiosDDD.Domain.Models;

namespace PrincipiosDDD.Domain.Interfaces
{
    public interface IServiceWorker
    {
        WorkerModel Insert(CreateWorkerModel userModel);

        WorkerModel Update(int id, UpdateWorkerModel userModel);

        void Delete(int id);

        WorkerModel RecoverById(int id);

        IEnumerable<WorkerModel> RecoverAll();
    }
}
