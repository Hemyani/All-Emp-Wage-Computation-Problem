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
            UC9 Amazon = new UC9("Amazon", 30, 25, 20);
            UC9 Infosys = new UC9("Infosys", 25, 22, 29);
            Amazon.CompanyEmpWage();
            Console.WriteLine(Amazon.toString());
            Infosys.CompanyEmpWage();
            Console.Write(Infosys.toString());
        }
    }
}