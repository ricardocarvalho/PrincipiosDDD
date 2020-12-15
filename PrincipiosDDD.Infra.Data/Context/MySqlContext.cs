using PrincipiosDDD.Domain.Entities;
using PrincipiosDDD.Infra.Data.Mapping;
using Flunt.Notifications;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Reflection;

namespace PrincipiosDDD.Infra.Data.Context
{
    public class MySqlContext : DbContext
    {
        public MySqlContext(DbContextOptions<MySqlContext> options) : base(options)
        {
        }

        public DbSet<Manager> Managers { get; set; }
        
        public DbSet<Worker> Workers { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Manager>(new ManagerMap().Configure);
            modelBuilder.Entity<Worker>(new WorkerMap().Configure);
            modelBuilder.Entity<PersonalProtectiveEquipment>(new PpeMap().Configure);
            modelBuilder.Entity<PpePossession>(new PpePossessionMap().Configure);

            var entites = Assembly
                .Load("PrincipiosDDD.Domain")
                .GetTypes()
                .Where(w => w.Namespace == "PrincipiosDDD.Domain.Entities" && w.BaseType.BaseType == typeof(Notifiable));

            foreach (var item in entites)
            {
                modelBuilder.Entity(item).Ignore(nameof(Notifiable.Invalid));
                modelBuilder.Entity(item).Ignore(nameof(Notifiable.Valid));
                modelBuilder.Entity(item).Ignore(nameof(Notifiable.Notifications));
            }
        }
    }
}
