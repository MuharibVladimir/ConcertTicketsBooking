using Entities.Models;
using Microsoft.EntityFrameworkCore;
using Repositories.Configuration;
using System;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory.Database;

namespace Repositories
{
    public class RepositoryContext: DbContext
    {
        public RepositoryContext(DbContextOptions options): base(options)
        {
            Database.EnsureCreated();
        }

        public DbSet<Concert>? Concerts { get; set; }
        public DbSet<User>? Users { get; set; }
        public DbSet<Ticket>? Tickets { get; set; }
        public DbSet<Place>? Places { get; set; }
        public DbSet<Booking>? Bookings { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Concert>()
                .HasDiscriminator(b => b.ConcertType)
                .HasValue<Party>(ConcertTypes.Party)
                .HasValue<Classic>(ConcertTypes.Classic)
                .HasValue<OpenAir>(ConcertTypes.OpenAir);
        }
    }
}