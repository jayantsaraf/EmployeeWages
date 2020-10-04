using System;

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
    class EmpWageBuilderObject
    {
        //// Constants
        public const int NUMBER_OF_DAYS = 20;
        public const int IS_FULL_TIME = 8;
        public const int EMP_RATE_PER_HOUR = 20;
        public const int MAX_HRS = 100;

        public int numOfEmp = 0;
        public CompanyEmpWage[] companyWageArray = new CompanyEmpWage[5];

        public void AddEmployee(string company, int workDays, int empRate, int workHrs)
        {
            companyWageArray[this.numOfEmp++] = new CompanyEmpWage(company, workDays, empRate, workHrs);
        }

        public void ComputeWage()
        {
            for(int i=0; i<numOfEmp;i++)
            {
                int totalWage = CalculateWage(companyWageArray[i]);
                companyWageArray[i].SetEmpWage(totalWage);
            }
        }
        public int CalculateWage(CompanyEmpWage company)
        {
            Random random = new Random();
            int empCheck = 0, empHrs = 0, totalHrs = 0, empWage = 0, totalEmpWage = 0, days = 0;
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
                days += 1;
            }
            empWage = totalHrs * company.empRate * company.workDays;
            totalEmpWage += empWage;
            return totalEmpWage;

        }
        public static void Main()
        {
            Console.WriteLine("Welcome to Employee Wage Computation Program!");
            EmpWageBuilderObject company1 = new EmpWageBuilderObject();
            company1.AddEmployee("Bajaj", 30, 50, 90);
            company1.ComputeWage();
            EmpWageBuilderObject company2 = new EmpWageBuilderObject();
            company2.AddEmployee("Philips", 60, 70, 100);
            company2.ComputeWage();
            ////Check Attendance function
            Random random = new Random();

        }

    }
}

