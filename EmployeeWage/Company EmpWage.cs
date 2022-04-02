using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeWage
{
    internal class CompanyEmpWage 
    {
        //Variables
        public string companyName;
        public int wagePerHour, maxWorkingDays, maxWorkingHours, totalMonthWage;
        public CompanyEmpWage(string companyName, int wagePerHour, int maxWorkingDays, int maxWorkingHours) // CompanyEmpWage class constructor with arguments
        {
            this.companyName = companyName;
            this.wagePerHour = wagePerHour;
            this.maxWorkingDays = maxWorkingDays;
            this.maxWorkingHours = maxWorkingHours;
        }
        public void setTotalEmpWage(int totalMonthWage) // Creating method to just set Total Wage of Employee
        {
            this.totalMonthWage = totalMonthWage;
        }
        public override string ToString()
        {
            return "";
        }
    }
}
