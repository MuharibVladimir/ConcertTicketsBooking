using Entities.Models;
using Microsoft.EntityFrameworkCore;
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
        public DbSet<PartyConcert> PartyConcerts { get; set; }
        public DbSet<ClassicConcert> ClassicConcerts { get; set; }
        public DbSet<OpenAirConcert> OpenAirConcerts { get; set; }
        public DbSet<User>? Users { get; set; }
        public DbSet<Place>? Places { get; set; }
        public DbSet<Booking>? Bookings { get; set; }

        //protected override void OnModelCreating(ModelBuilder modelBuilder)
        //{
        //    modelBuilder.base
        //}
    }
}