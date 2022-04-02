using EmployeeWage;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeWage
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Employee Wage Compuatation Program\n");
            EmpWageBuilder empWageBuilder = new EmpWageBuilder();
            empWageBuilder.AddCompany("RKP", 20, 20, 100);
            empWageBuilder.AddCompany("DPJ", 40, 25, 100);
            empWageBuilder.IterateOverListOfCompany();
            Console.WriteLine($"\nTotal Wage for RKP company is : {empWageBuilder.getTotalWage("RKP")}");
            Console.WriteLine($"\nTotal Wage for DPJ company is : {empWageBuilder.getTotalWage("DPJ")}");
            Console.ReadLine();
        }
    }
}
