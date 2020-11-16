using System;
using WebApplicationRazorInjectionDependances.Controllers;

namespace WebApplicationRazorInjectionDependances
{
 
        public class QuaterlySalaryCalculator : ISalaryCalculator
        {
            public Double CalculateSalary(Double yearlyAmount)
            {
                return yearlyAmount / 4;
            }
        }
    
}