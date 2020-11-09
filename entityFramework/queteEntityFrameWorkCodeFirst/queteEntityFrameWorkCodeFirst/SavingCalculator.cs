using System;

namespace queteEntityFrameWorkCodeFirst
{
    public class SavingCalculator
    {
        public Double CalculateTotalSaved(DateTime begin, DateTime end, SavingAccount savingAccount)
        {
            int beginYear = begin.Year;
            int endYear = end.Year;

            int numberOfYears = endYear - beginYear;

            return Formule(savingAccount.Funds, savingAccount.SavingsRate, numberOfYears);
        }

        public Double Formule(double initialDeposit , double savingRate, int years)
        {
            int periodeInteret = years ;
/*            Double result = Math.Pow((1000 * (1 + savingRate / (double)periodeInteret / 100)), (years * (double)periodeInteret));
*/            double calc = initialDeposit;
            for (int i = 1; i <= periodeInteret; i++)
            {
                calc = calc + calc * savingRate;
            }
            return calc;
      
        }

        public void Test()
        {

        }
        public double CalculateTotalSaved(double Rate, double Amount, int year)
        {
            double calc = Amount;
            for (int i = 1; i <= year; i++)
            {
                calc = calc + calc * Rate;
            }
            return calc;
        } 

    }
}