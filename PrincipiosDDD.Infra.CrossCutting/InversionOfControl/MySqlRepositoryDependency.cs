using PrincipiosDDD.Domain.Interfaces;
using PrincipiosDDD.Infra.Data.Repository;
using Microsoft.Extensions.DependencyInjection;

namespace PrincipiosDDD.Infra.CrossCutting.InversionOfControl
{
    public static class MySqlRepositoryDependency
    {
        public static void AddMySqlRepositoryDependency(this IServiceCollection services)
        {
            services.AddScoped<IRepositoryWorker, WorkerRepository>();
        }
    }
}
