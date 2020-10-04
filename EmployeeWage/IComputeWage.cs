using System;
using System.Collections.Generic;
using System.Text;

namespace EmployeeWage
{
    interface IComputeWage
    {
        public void AddEmployee(string company, int workDays, int empRate, int workHrs);
        public void ComputeWage();
    }
}
