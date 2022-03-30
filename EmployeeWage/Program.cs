﻿using System;

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

        public static void UC5()
        {
            Console.WriteLine("Welcome to UC5");

            int is_fulltime = 1;
            int is_parttime = 2;
            int totalWorkingHour = 0, wagePerHour = 20, dailyWage = 0;
            int totalWorkingDay = 1,workinghour;

            while (totalWorkingDay < 20)
            {
                Random random = new Random();
                int empCheck = random.Next(0, 3);
                switch (empCheck)
                {
                    case 1:
                        workinghour = 8;
                        Console.WriteLine("Employee is Present");
                        break;
                    case 2:
                        workinghour = 4;
                        Console.WriteLine("Employee is Parttime Worker");
                        break;
                    default:
                        workinghour = 0;
                        Console.WriteLine("Employee is Absent");
                        break;


                }
                totalWorkingDay++;
                totalWorkingHour = totalWorkingHour + workinghour;

            }
            dailyWage = wagePerHour * totalWorkingHour;

            Console.WriteLine("Total wage is : " + dailyWage);
            Console.ReadLine(); 
        }
        public static void UC6()
        {
            Console.WriteLine("Welcome to UC6");
            int isFullTime = 1;
            int isPartTime = 2;
            int totalWorkingday = 0, empratePerHour = 20, totalhour = 0;
            int num_of_workingDay = 20, max_Hour_In_a_month = 100,empHrs = 0;
            int totalSalary = 0;

            while (totalhour <= max_Hour_In_a_month && totalWorkingday < num_of_workingDay)

            {
                totalWorkingday++;
                Random random = new Random();
                int randomCheck = random.Next(0, 3);

                switch (randomCheck)
                {
                    case 1:
                        empHrs = 8;
                        Console.WriteLine("Employee is Present");
                        break;
                    case 2:
                        empHrs = 4;
                        Console.WriteLine("Employee is doing parttime:");
                        break;
                    default:
                        empHrs = 0;
                        Console.WriteLine("Employee is absent");
                        break;
                }
                totalhour += empHrs;
                Console.WriteLine("Day :" + totalWorkingday + "Daily worked hour", +empHrs);
            }
            totalSalary = totalhour * empratePerHour;
            Console.WriteLine("Total Employee wage is: " + totalSalary );
            Console.ReadLine();
        }

        public const int fullTime = 1;
        public const int partTime = 2;
        public const int empRatePerHour = 20;
        public const int empWorkingDays = 20;
        public const int workingHourLimit = 100;

        public static int UC7()
        {
            Console.WriteLine("Welcome to UC7");
            int empHrs = 0;
            int totalWorkingDays = 0;
            int totalWorkingHour = 0;
            int present = 0, halftime = 0, absent = 0;

            while (totalWorkingDays < empWorkingDays && totalWorkingHour < workingHourLimit)
            {
                totalWorkingDays++;
                Random random = new Random();
                int randomCheck = random.Next(3);
                switch (randomCheck)
                {
                    case fullTime:
                        empHrs = 8;
                        present++;
                        break;
                    case partTime:
                        empHrs = 4;
                        halftime++;
                        break;
                    default:
                        empHrs = 0;
                        absent++;
                        break;
                }
                totalWorkingHour = totalWorkingHour + empHrs;
            }
            int totalEmployeeWage = totalWorkingHour * empRatePerHour;
            Console.WriteLine("Total wage of the Employee is: " + totalEmployeeWage);
            Console.WriteLine("Total Working Hour is: " + totalWorkingHour + "Hours");
            Console.WriteLine("Employee is present for " + present + "Days");
            Console.WriteLine("Employee is Doing Partime for " + halftime + "Days");
            Console.WriteLine("Employee is Absent for " + absent + "Days");
            Console.ReadLine();
            return totalEmployeeWage;
            
        }


        static void Main(string[] args)
            {
                Program.UC1();
                Program.UC2();
                Program.UC3();
                Program.UC4();
                Program.UC5();
                Program.UC6();
                Program.UC7();
              
           
            }
        }

    }
}
