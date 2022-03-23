using System;

namespace EmployeeWage
{
    internal class Program
    {
        static void UC1()
        {
            Console.WriteLine("Welcome to Employee Wage Computation Program");
            Random random = new Random();
            int is_fultime = 1;
            int empCheck = random.Next(0, 2);
            if (empCheck == is_fultime)
            {
                Console.WriteLine("Employee is Present");
            }
            else
            {
                Console.WriteLine("Employee is Absent");
            }

            Console.ReadLine();
        }
       
     static void Main(string[] args)
     {
         Program.UC1();
     }    
    }
}
