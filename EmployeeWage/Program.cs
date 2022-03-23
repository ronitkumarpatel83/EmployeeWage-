using System;

namespace EmployeeWage
{
    internal class Program
    {
        public static void UC1()
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
        public static void UC2()
        {
            Random random = new Random();
            int is_fulltime = 1;
            int totalWorkingHour = 8;
            int wagePerHour = 20;
            int dailyWage = 0;
            int empCheck = random.Next(0, 2);

            if (empCheck == is_fulltime)
            {
                Console.WriteLine("Employee is Present");
                dailyWage = totalWorkingHour * wagePerHour;
                Console.WriteLine("Total wage of a day: " + dailyWage);
            }
            else
            {
                Console.WriteLine("Employee is Absent");
                dailyWage = totalWorkingHour * 0;
                Console.WriteLine("Total wage of a day: " + dailyWage);

            }
            Console.ReadLine();




        }
        static void Main(string[] args)
        {
            Program.UC1();
            Program.UC2();
            
        }
    }
}
