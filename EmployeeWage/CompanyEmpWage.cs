using System;
using System.Collections.Generic;
using System.Text;

namespace EmployeeWage
{
    public class CompanyEmpWage
    {
        public string company;
        public int workDays;
        public int empRate;
        public int workHrs;
        public int totalEmpWage;
        public CompanyEmpWage(string Company, int workDays, int empRate, int workHrs)
        {
            this.company = Company;
            this.workDays = workDays;
            this.empRate = empRate;
            this.workHrs = workHrs;
        }
        public void SetEmpWage(int totalWage)
        {
            this.totalEmpWage = totalWage;
            Console.WriteLine("Employee wage for" + this.company + " = " + totalEmpWage);
        }
    }
}
