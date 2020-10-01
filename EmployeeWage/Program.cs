using System;

namespace EmployeeWage
{

    class Program
    {
        //// Constants
        public const int NUMBER_OF_DAYS = 20;
        public const int IS_FULL_TIME = 8;
        public const int EMP_RATE_PER_HOUR = 20;
        public const int MAX_HRS = 100;



        public static void Main()
        {
            Console.WriteLine("Welcome to Employee Wage Computation Program!");
            CalculateWage("Reliance", 20, 40, 100);
            CalculateWage("Bajaj", 30, 50, 96);
            ////Check Attendance function
            Random random = new Random();

        }

        private static void CalculateWage(string company, int workDays, int empRate, int workHrs)
        {
            Random random = new Random();
            int empCheck = 0, empHrs = 0, totalHrs = 0, empWage = 0, totalEmpWage = 0, days = 0;
            while (totalHrs <= workHrs && days < workDays)
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
            empWage = totalHrs * empRate * workDays;
            totalEmpWage += empWage;
            Console.WriteLine("Employee wage for " + company + " = " + totalEmpWage);

        }

    }
}

