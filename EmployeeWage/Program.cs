using System;

namespace EmployeeWage
{
    class Program
    {
        static void Main(string[] args)
        {
            ////constants
            int EMP_RATE_PER_HOUR = 20;
            int IS_FULL_TIME = 1;

            Console.WriteLine("Welcome to Employee Wage Computation Program!");

            ////Check Attendance function
            Random random = new Random();

            int IS_FULL_TIME = 1;
            Random random = new Random();
            ////program working

            int empCheck = random.Next(0, 2);
            if (empCheck == IS_FULL_TIME)
            {
                Console.WriteLine("Employee is present");
            }
            else
            {
                Console.WriteLine("Employee is absent");
            }

            
            ////variable
            int empHrs = 0;
            int empWage = 0;

            ////Computation of Wages

            empCheck = random.Next(0, 2);
            if (empCheck == IS_FULL_TIME)
            {
                empHrs = 8;
            }
            

            empWage = empHrs * EMP_RATE_PER_HOUR;
            Console.WriteLine("Employee wage = " + empWage);


        }
    }
}
