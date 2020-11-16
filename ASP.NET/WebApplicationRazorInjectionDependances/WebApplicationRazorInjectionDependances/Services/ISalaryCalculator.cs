using System;

namespace WebApplicationRazorInjectionDependances.Controllers
{
    public interface ISalaryCalculator
    {
        Double CalculateSalary(Double yearlyAmount);
    }
}