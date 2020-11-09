using System;
using System.Collections.Generic;
using System.Windows.Forms;


namespace queteEntityFrameWorkCodeFirst
{
    public static class Program
    {
       
        static void Main()
        {
         

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

            MessageBox.Show($"{calcul}", "Useless message box",
                     MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }

        
    }

  

}