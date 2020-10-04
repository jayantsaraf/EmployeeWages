using System;
using System.Collections.Generic;

namespace EmployeeWage
{
    class program
    {
        public static void Main()
        {
            Console.WriteLine("Welcome to Employee Wage Computation Program!");
            EmpWageBuilderObject company = new EmpWageBuilderObject();
            company.AddEmployee("Bajaj", 30, 50, 90);
            company.AddEmployee("Philips", 60, 70, 100);
            company.ComputeWage();

            Console.WriteLine("Enter the company name to find Employee Wage");
            string companyName = Console.ReadLine();
            Console.WriteLine("The total Employee Wage for " + companyName + " is " + company.getTotalWageByCompany(companyName));


        }
    }
}


