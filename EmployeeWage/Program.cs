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
<<<<<<< HEAD
            {
                Program.UC1();
                Program.UC2();
                Program.UC3();
                Program.UC4();
                Program.UC5();
                Program.UC6();
                Program.UC7();
              

            //UC8
            // UC8 main  method
            Console.WriteLine("Hello, Welcome to total employee wage calculation program ");
            Console.WriteLine("Please enter the number of Company: ");
            int limit = int.Parse(Console.ReadLine()), i = 0;
            while (i < limit)
            {
                i++;
                Console.WriteLine("\nEnter Company Name: ");
                string com = Console.ReadLine();
                Console.WriteLine("Enter Employee rate per hour: ");
                int sal = int.Parse(Console.ReadLine());
                Console.WriteLine("Enter Employee total working hour Limit: ");
                int wlimt = int.Parse(Console.ReadLine());
                Console.WriteLine("Enter TotalWorking days limit for your company: ");
                int days = int.Parse(Console.ReadLine());
                Program.EmployeeWage(com, sal, wlimt, days);

            }
        }
=======
        {
            Console.WriteLine("Hello, Welcome to Employeewages problem ");
            WageBuilder obj = new WageBuilder("Dmart", 20, 100, 20);
            obj.ComputeEmployeeWage();
            Console.WriteLine(obj.toString());
            WageBuilder obj1 = new WageBuilder("RMart", 10, 120, 21);
            obj1.ComputeEmployeeWage();
            Console.WriteLine(obj1.toString());
>>>>>>> UC-9WageBuilder

        }
    }
}