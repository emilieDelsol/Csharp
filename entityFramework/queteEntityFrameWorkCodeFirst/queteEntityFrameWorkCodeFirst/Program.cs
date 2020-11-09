using System;
using System.Collections.Generic;
using System.Windows.Forms;


namespace queteEntityFrameWorkCodeFirst
{
    public static class Program
    {
       
        static void Main()
        {
            MessageBox.Show("Hello, world !", "Useless message box",
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

            using (var context = new MrRichardAccountContext())
            {
                context.Database.EnsureDeleted();
                context.Database.EnsureCreated();

                Person person = new Person
                {
                    PersonName = "Mr Richard"
                };
                person.SavingAccounts = new List<SavingAccount>
                {
                    new SavingAccount { Funds=2000000, SavingsRate= 1.05},
                    new SavingAccount{Funds=250000,SavingsRate= 1.15},
                    new SavingAccount{Funds=10000000,SavingsRate= 1.02}
                    
                };

                context.Add(person);
              
            
                context.SaveChanges();
               
            }
            SavingCalculator savingCalculator = new SavingCalculator();

            double calcul =savingCalculator.Formule(2000000,1.05, 3);

            Console.WriteLine(Convert.ToString(calcul));

            Console.ReadLine();
        }

        
    }

    /*
        class ShopContext : DbContext
        {
            // Product entites can be accessed by this context
            public virtual DbSet<Product> Products { get; set; }
            // Shop entities can be accessed by this context
            public virtual DbSet<Shop> Shops { get; set; }

            // OnConfiguring is a hook that executes while the context configures itself
            protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
            {
                // I add a connection to a database instance while the context configures
                optionsBuilder.UseSqlServer(
                    @"Server=LOCALHOST\SQLEXPRESS;Database=Shop;Integrated Security=True");
            }
        }

        public class Shop
        {
            public Guid ShopId { get; set; }
            public String City { get; set; }
            public ICollection<Product> Products { get; set; }
        }

        public class Product
        {
            public Guid ProductId { get; set; }
            public Double Price { get; set; }
            public String Name { get; set; }
        }
    */

}