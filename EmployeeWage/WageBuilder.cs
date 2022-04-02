using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeWage
{
    internal class EmpWageBuilder : Interface
    {
        //constant variables
        const int IS_FULL_TIME = 1;
        const int IS_PART_TIME = 2;
        List<CompanyEmpWage> list = new List<CompanyEmpWage>(); // creating a List having CompanyEmpWage Class Object as datatype
        IDictionary<string, CompanyEmpWage> dictionary = new Dictionary<string, CompanyEmpWage>(); //Creating Dictionary having Company And Employee total Wage
        public void AddCompany(string companyName, int wagePerHour, int maxWorkingDays, int maxWorkingHours) // creating class method to add company in array
        {
            var companyObj = new CompanyEmpWage(companyName, wagePerHour, maxWorkingDays, maxWorkingHours);
            list.Add(companyObj); //Adding company to List
            dictionary.Add(companyName, companyObj); //Adding value to dictionary
        }
        public void IterateOverListOfCompany()
        {
            for (int i = 0; i < list.Count; i++)
            {
                list[i].setTotalEmpWage(ComputeWage(list[i]));
                // ComputeWage(list[i]);
            }
        }
        public int ComputeWage(CompanyEmpWage obj) //Creating a class method for Wage Computation with parameters
        {
            int empWorkHour = 0, empDailyWage = 0, empTotalHour = 0, empTotalWorkDays = 0, totalMonthWage = 0;
            Random random = new Random(); // Creating object of Random class
            while (empTotalHour <= obj.maxWorkingHours && empTotalWorkDays <= obj.maxWorkingDays) // Checking that Employee total work hours should be less than or equal to 100 or Employee working days should be Less or equl to 20 
            {
                int check = random.Next(0, 3); // Generating random number 0 , 1 , 2
                // Checking that employee is present for full time ,part time or not using switch
                switch (check)
                {
                    case IS_FULL_TIME:
                        // Console.WriteLine("Employee is Present for Full Time");
                        empWorkHour = 8;
                        break;

                    case IS_PART_TIME:
                        // Console.WriteLine("Employee is Present for Part Time");
                        empWorkHour = 4;
                        break;
                    default:
                        // Console.WriteLine("Employee is Absent");
                        empWorkHour = 0;
                        break;
                }
                empDailyWage = empWorkHour * obj.wagePerHour; // Calculating Daily Wage of Employee
                                                              // Console.WriteLine($"Employee Daily Wage for Day {empTotalWorkDays} : {empDailyWage}\n");
                totalMonthWage += empDailyWage; // Adding Daily Wage to Total Wage
                empTotalWorkDays++;
                empTotalHour += empWorkHour;
            }
            if (empTotalHour > obj.maxWorkingHours) //Checking that hours are more than 100 or not
            {
                int a = empTotalHour - obj.maxWorkingHours;
                empTotalHour -= a;
                int wage = a * obj.wagePerHour; // Calculate exatra hours wage
                totalMonthWage -= wage; // Minus extra hours wage from emp total wage
            }
            if (empTotalWorkDays > obj.maxWorkingDays)
            {
                empTotalWorkDays -= 1;
            }
            Console.WriteLine("\n\nCompany Name : " + obj.companyName);
            Console.WriteLine($"\nEmployee total working days for {obj.companyName} company is : {empTotalWorkDays}");
            Console.WriteLine($"Employee total working hours for {obj.companyName} company is : {empTotalHour}\n");
            Console.WriteLine($"Employee Total Month Wage for {obj.companyName} company is : {totalMonthWage}\n");
            return totalMonthWage;
        }
        public int getTotalWage(string company) //Creating method to get Total Wage queried by Companies
        {
            return dictionary[company].totalMonthWage;//Returning Total Wage of Employee
        }
    }
}