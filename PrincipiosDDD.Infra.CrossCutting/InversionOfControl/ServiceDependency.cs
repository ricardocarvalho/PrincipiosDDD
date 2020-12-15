using PrincipiosDDD.Domain.Interfaces;
using PrincipiosDDD.Service.Services;
using Microsoft.Extensions.DependencyInjection;

namespace PrincipiosDDD.Infra.CrossCutting.InversionOfControl
{
    public static class ServiceDependency
    {
        public static void AddServiceDependency(this IServiceCollection services)
        {
            services.AddScoped<IServiceWorker, WorkerService>();
        }
    }
}
