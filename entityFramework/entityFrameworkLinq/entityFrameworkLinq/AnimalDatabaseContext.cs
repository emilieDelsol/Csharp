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
            optionsBuilder.UseSqlServer(
                @"Server=LOCALHOST\SQLEXPRESS;Database=EntityLinqQuest;Integrated Security=True;MultipleActiveResultSets=True");
        }
    }
}