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


        public static int CalculateWage()
        {
            int empCheck = 0, empHrs = 0, totalHrs = 0, empWage = 0, totalEmpWage = 0, days = 0;
            while (totalHrs <= MAX_HRS && days < NUMBER_OF_DAYS)
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
            empWage = totalHrs * EMP_RATE_PER_HOUR * DAYS;
            totalEmpWage += empWage;
        }
        Console.WriteLine("Total Employee Wage = " + totalEmpWage);
            return totalEmpWage;
        }

    static void Main(string[] args)
    {
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
        else
        {
            empHrs = 4;////Assuming part time hours = 4
        }

        //switch method to calculate part time wages
        switch (empCheck)
        {
            case 0:
                empHrs = 4;
                break;
            case 1:
                empHrs = 8;
                break;
            default:
                empHrs = 0;
                break;
        }

        empWage = empHrs * EMP_RATE_PER_HOUR;
        Console.WriteLine("Employee wage = " + empWage);

        ////Calculate Wages till total hours less than 100 and Days less than 20
        CalculateWage();

        ////Wages in a month
        empWage = empHrs * EMP_RATE_PER_HOUR * NUMBER_OF_DAYS;
        Console.WriteLine("Wages in a month = " + empWage);



    }
}
}
