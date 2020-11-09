using Microsoft.EntityFrameworkCore;

namespace queteEntityFrameWorkCodeFirst
{
    class MrRichardAccountContext : DbContext
    {
        public virtual DbSet<SavingAccount> SavingAccounts { get; set; }
        public virtual DbSet<Person> Persons { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            // I add a connection to a database instance while the context configures
            optionsBuilder.UseSqlServer(
                @"Server=LOCALHOST\SQLEXPRESS;Database=EntityQuest;Integrated Security=True");
        }

    }
}