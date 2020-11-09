using System;

namespace queteEntityFrameWorkCodeFirst
{
    public class SavingCalculator
    {
        public Double CalculateTotalSaved(DateTime begin, DateTime end, SavingAccount savingAccount, string rateCalc)
        {

            int beginYear = begin.Year;
            int endYear = end.Year;

            int numberOfYears = endYear - beginYear;

            return Formule(savingAccount.Funds, savingAccount.SavingsRate, numberOfYears, rateCalc);
        }

        public Double Formule(double initialDeposit , double savingRate, int years, string rateCalc)
        {
            int periodeInteret;
            if (rateCalc=="mois")
            {
                periodeInteret = years*12;
            }
            else
            {
                periodeInteret = years;
            }
            
            double calc = initialDeposit;
            for (int i = 1; i <= periodeInteret; i++)
            {
                calc = calc + calc * savingRate/100;
            }
            return calc;
      
        }


    }
}