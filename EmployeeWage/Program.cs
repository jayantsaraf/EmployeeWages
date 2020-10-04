using System;

namespace EmployeeWage
{
    class program
    {
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


