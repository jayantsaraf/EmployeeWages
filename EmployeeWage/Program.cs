using System;
using System.Collections.Generic;

namespace EmployeeWage
{
    class program
    {
        public static void Main()
        {
            Console.WriteLine("Welcome to Employee Wage Computation Program!");
            IComputeWage c1;
            c1 = new EmpWageBuilderObject();
            c1.AddEmployee("Bajaj", 30, 50, 90);
            c1.AddEmployee("Philips", 60, 70, 100);
            c1.ComputeWage();
        }
    }
}


