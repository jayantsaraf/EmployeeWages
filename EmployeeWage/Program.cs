using System;
using System.Collections.Generic;

namespace EmployeeWage
{

    public class CompanyEmpWage
    {
        public string company;
        public int workDays;
        public int empRate;
        public int workHrs;
        public int totalEmpWage;
        public int[] dailyWage;
        public CompanyEmpWage(string Company, int workDays, int empRate, int workHrs)
        {
            this.company = Company;
            this.workDays = workDays;
            this.empRate = empRate;
            this.workHrs = workHrs;
            this.dailyWage = new int[workDays];
        }
        public void SetEmpWage(int totalWage)
        {
            this.totalEmpWage = totalWage;
            Console.WriteLine("Employee wage for" + this.company + " = " + totalEmpWage);
        }

    }
    public class EmpWageBuilderObject
    {
        //// Constants
        public const int NUMBER_OF_DAYS = 20;
        public const int IS_FULL_TIME = 8;
        public const int EMP_RATE_PER_HOUR = 20;
        public const int MAX_HRS = 100;

        public int numOfEmp = 0;
        List<CompanyEmpWage> CompanyWageList = new List<CompanyEmpWage>();
        Dictionary<string, CompanyEmpWage> companyToWage;
        public void AddEmployee(string companyName, int workDays, int empRate, int workHrs)
        {
            CompanyEmpWage c1 = new CompanyEmpWage(companyName, workDays, empRate, workHrs);
            CompanyWageList.Add(c1);
        }
        public int getTotalWageByCompany(string companyName)
        {
            int totalWage = companyToWage[companyName].totalEmpWage;
            return totalWage;
        }

        public void ComputeWage()
        {
            foreach (CompanyEmpWage i in CompanyWageList)
            {
                int totalWage = CalculateWage(i);
                i.SetEmpWage(totalWage);
            }
        }
        public int CalculateWage(CompanyEmpWage company)
        {
            Random random = new Random();
            int empCheck = 0, empHrs = 0, totalHrs = 0, empWage = 0, totalEmpWage = 0, days = 0, i = 0;
            int[] dailyWage = new int[company.workDays];
            while (totalHrs <= company.workHrs && days < company.workDays)
            {
                empCheck = random.Next(0, 2);
                if (empCheck == IS_FULL_TIME)
                {
                    empHrs = 8;
                    totalHrs += empHrs;
                }
                else
                {
                    empHrs = 4;
                    totalHrs += empHrs;
                }
                company.dailyWage[i++] = empHrs * company.empRate;
                days += 1;
            }
            empWage = totalHrs * company.empRate * company.workDays;
            totalEmpWage += empWage;
            return totalEmpWage;
        }
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

