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
            int DAYS = 1;

            Console.WriteLine("Welcome to Employee Wage Computation Program!");

            ////Check Attendance function
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
            int totalHrs = 0;
            int totalEmpWage = 0;

            ////Computation of Wages

            empCheck = random.Next(0, 2);
            if (empCheck == IS_FULL_TIME)
            {
                empHrs = 8;
            }
            

            empWage = empHrs * EMP_RATE_PER_HOUR;
            Console.WriteLine("Employee wage = " + empWage);

            ////Calculate Wages till total hours less than 100 and Days less than 20
            for (DAYS = 1; DAYS <= 20; DAYS += 1)
            {
                while (totalHrs <= 100)
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
                }
                empWage = totalHrs * EMP_RATE_PER_HOUR * DAYS;
                totalEmpWage += empWage;
            }
            Console.WriteLine("Total Employee Wage = " + totalEmpWage);


        }
    }
}
