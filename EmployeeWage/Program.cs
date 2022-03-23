using System;

namespace EmployeeWage
{
    internal class Program
    {
        public static void UC1()
        {
            Console.WriteLine("Welcome to Employee Wage Computation Program");
            Console.WriteLine("Welcome to UC-1");
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
            Console.WriteLine("Welcome to UC2");
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
        public static void UC3()
        {
            Console.WriteLine("Welcome to UC3");
            Random random = new Random();
            int is_fulltime = 1;
            int is_parttime = 2;
            int totalWorkingHour = 8;
            int partTimeWorkingHour = 4;
            int wagePerHour = 20;
            int dailyWage = 0;
            int empCheck = random.Next(0, 3);

            if (empCheck == is_fulltime)
            {
                Console.WriteLine("Employee is Present");
                dailyWage = totalWorkingHour * wagePerHour;
                Console.WriteLine("Total wage of a day: " + dailyWage);
            }
            else if (empCheck == is_parttime)
            {
                Console.WriteLine("Employee is parttime worker");
                dailyWage = (partTimeWorkingHour * wagePerHour);
                Console.WriteLine("Total wage of halfday: " + dailyWage);
            }
            else
            {
                Console.WriteLine("Employee is Absent");
                dailyWage = totalWorkingHour * 0;
                Console.WriteLine("Total wage of a day: " + dailyWage);

            }
            Console.ReadLine();


        }
        public static void UC4()
        {
            Console.WriteLine("Welcome to UC4");
            Random random = new Random();
            int empCheck = random.Next(0, 3);
            int is_fulltime = 1;
            int is_parttime = 2;

            int totalWorkingHour, wagePerHour = 20, dailyWage = 0;
            switch (empCheck)
            {
                case 1:
                    totalWorkingHour = 8;
                    Console.WriteLine("Employee is Present");
                    break;
                case 2:
                    totalWorkingHour = 4;
                    Console.WriteLine("Employee is Parttime Worker");
                    break;
                default:
                    totalWorkingHour = 0;
                    Console.WriteLine("Employee is Absent");
                    break;


            }
            dailyWage = wagePerHour * totalWorkingHour;
            Console.WriteLine("Total wage is : " + dailyWage);
            Console.ReadLine();
        }



        static void Main(string[] args)
            {
                Program.UC1();
                Program.UC2();
                Program.UC3();
                Program.UC4();
            }

    }
}
