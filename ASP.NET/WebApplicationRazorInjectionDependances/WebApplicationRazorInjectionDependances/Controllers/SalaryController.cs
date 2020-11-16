using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplicationRazorInjectionDependances.Controllers
{

    /*************************************************************************************
     * route à entrer dans la barre de navigation: https://localhost:44317/api/Salary/YearlyAmount?YearlyAmount=30000
     */
    [Route("api/[controller]")]
    [ApiController]
    public class SalaryController
    {
        private ISalaryCalculator _calculator;

        public SalaryController(ISalaryCalculator injectedCalculator)
        {
            _calculator = injectedCalculator;
        }
        [HttpGet("YearlyAmount")]
        public double Get(double yearlyAmount)
        {
            double calculatedSalary = _calculator.CalculateSalary(yearlyAmount);
            return calculatedSalary;
        }


    }
}
