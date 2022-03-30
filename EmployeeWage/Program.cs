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
            Console.WriteLine("Hello, Welcome to Employeewages problem ");
            WageBuilder obj = new WageBuilder("Dmart", 20, 100, 20);
            obj.ComputeEmployeeWage();
            Console.WriteLine(obj.toString());
            WageBuilder obj1 = new WageBuilder("RMart", 10, 120, 21);
            obj1.ComputeEmployeeWage();
            Console.WriteLine(obj1.toString());

        }
    }
}