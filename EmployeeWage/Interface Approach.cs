using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeWage
{
    internal interface Interface
    {
        void AddCompany(string companyName, int wagePerHour, int maxWorkingDays, int maxWorkingHours);
        void IterateOverListOfCompany();
    }
}