using Microsoft.EntityFrameworkCore;
using System;

namespace entityframeworkLinq
{
    class AnimalDatabaseContext : DbContext
    {
        public virtual DbSet<Animal> Animals { get; set; }
        public virtual DbSet<Specie> Specie { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            // I add a connection to a database instance while the context configures
            optionsBuilder.UseSqlServer(
                @"Server=LOCALHOST\SQLEXPRESS;Database=EntityLinqQuest;Integrated Security=True");
        }
    }
}