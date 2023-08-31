using Microsoft.EntityFrameworkCore;
using MotivatonApp.Server.Repository.Configuration;
using MotivatonApp.Shared.Models;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory.Database;

namespace Repository
{
    public class RepositoryContext: DbContext
    {
        public RepositoryContext(DbContextOptions options) : base(options)
        { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Motivation>().HasKey(x => x.Id);

            modelBuilder.ApplyConfiguration(new MotivationConfiguration());
        }

        public DbSet<Motivation> Motivations { get; set; }

    }
}