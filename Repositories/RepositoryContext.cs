using Entities.Models;
using Microsoft.EntityFrameworkCore;
using Repositories.Configuration;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory.Database;

namespace Repositories
{
    public class RepositoryContext: DbContext
    {
        public RepositoryContext(DbContextOptions options): base(options)
        {

        }

        public DbSet<ConcertType>? ConcertTypes { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Party>().ToTable(nameof(Party));
            modelBuilder.Entity<Classic>().ToTable(nameof(Classic));
            modelBuilder.Entity<OpenAir>().ToTable(nameof(OpenAir));
            modelBuilder.ApplyConfiguration(new ConcertTypeConfiguration());
        }
    }
}