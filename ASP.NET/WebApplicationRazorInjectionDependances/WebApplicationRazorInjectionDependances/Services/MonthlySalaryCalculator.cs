using System;
using WebApplicationRazorInjectionDependances.Controllers;

namespace WebApplicationRazorInjectionDependances
{
    public class MonthlySalaryCalculator : ISalaryCalculator
    {
        public Double CalculateSalary(Double yearlyAmount)
        {
            return yearlyAmount / 12;
        }
    }
}