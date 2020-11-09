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
                    new SavingAccount { Funds=2000000, SavingsRate= 5,rateCalc="mois"},
                    new SavingAccount{Funds=250000,SavingsRate= 15,rateCalc="année"},
                    new SavingAccount{Funds=10000000,SavingsRate= 2,rateCalc="année"}

                };

                context.Add(person);


                context.SaveChanges();


                SavingCalculator savingCalculator = new SavingCalculator();
                foreach (SavingAccount savingAccount in person.SavingAccounts)
                {
                    var dateBeginString = "5/1/2008 8:30:52 AM";
                    DateTime dateBegin = DateTime.Parse(dateBeginString,
                                              System.Globalization.CultureInfo.InvariantCulture);
                    var dateEndString = "5/1/2011 8:30:52 AM";
                    DateTime dateEnd = DateTime.Parse(dateEndString,
                                              System.Globalization.CultureInfo.InvariantCulture);
                    double calculTotal = savingCalculator.CalculateTotalSaved(dateBegin,dateEnd, savingAccount,savingAccount.rateCalc);
                    int beginYear = dateBegin.Year;
                    int endYear = dateEnd.Year;

                    int numberOfYears = endYear - beginYear;
                    MessageBox.Show($"Pour un montant initial de {savingAccount.Funds}, \nun taux de {savingAccount.SavingsRate}% par {savingAccount.rateCalc} \n au bout de {numberOfYears} ans le total de l'épargne est de {calculTotal}", "Useless message box",
                         MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    Console.WriteLine(calculTotal);

                }
            }
        }
    }

  

}