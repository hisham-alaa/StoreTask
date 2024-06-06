using Microsoft.EntityFrameworkCore;
using StoreTask.Core.Models;
using System.Reflection;

namespace StoreTask.Repository.Contexts
{
    public class StoreTaskDbContext : DbContext
    {
        public StoreTaskDbContext(DbContextOptions options) : base(options)
        {

        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Client>()
                .HasIndex(c => c.Code)
                .IsUnique();
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
        }

        DbSet<Client> Clients { get; set; }

    }
}
