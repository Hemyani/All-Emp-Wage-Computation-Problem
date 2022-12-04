using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace All_Emp_Wage_Computation_Problem
{
    class Program
    {
        static void Main(string[] args)
        {
            EmpWageBuilder empWageBuilder = new EmpWageBuilder();
            empWageBuilder.addCompanyEmpWage("TCS", 22, 3, 15);
            empWageBuilder.addCompanyEmpWage("Jio", 15, 3, 20);
            empWageBuilder.computeEmpWage();
            Console.WriteLine("Total wage for TCS company : " + empWageBuilder.getTotalWage("TCS"));
            Console.WriteLine("Total wage for Jio company : " + empWageBuilder.getTotalWage("Jio"));
        }
    }
}