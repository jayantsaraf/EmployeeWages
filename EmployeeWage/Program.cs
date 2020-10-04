using System;

namespace EmployeeWage
{
    class EmpWageBuilderObject
    {
        //// Constants
        public const int NUMBER_OF_DAYS = 20;
        public const int IS_FULL_TIME = 8;
        public const int EMP_RATE_PER_HOUR = 20;
        public const int MAX_HRS = 100;

        public string company;
        public int workDays;
        public int empRate;
        public int workHrs;

        public EmpWageBuilderObject(string Company, int workDays, int empRate, int workHrs)
        {
            this.company = Company;
            this.workDays = workDays;
            this.empRate = empRate;
            this.workHrs = workHrs;
        }
        public void CalculateWage()
        {
            Random random = new Random();
            int empCheck = 0, empHrs = 0, totalHrs = 0, empWage = 0, totalEmpWage = 0, days = 0;
            while (totalHrs <= this.workHrs && days < this.workDays)
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
            empWage = totalHrs * this.empRate * this.workDays;
            totalEmpWage += empWage;
            Console.WriteLine("Employee wage for " + company + " = " + totalEmpWage);

        }


        public static void Main()
        {
            Console.WriteLine("Welcome to Employee Wage Computation Program!");
            EmpWageBuilderObject company1 = new EmpWageBuilderObject("Reliance", 20, 40, 100);
            company1.CalculateWage();
            EmpWageBuilderObject company2 = new EmpWageBuilderObject("Bajaj", 30, 50, 90);
            company2.CalculateWage();
            ////Check Attendance function
            Random random = new Random();

        }

    }
}

