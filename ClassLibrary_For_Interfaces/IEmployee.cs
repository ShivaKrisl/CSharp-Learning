using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary_For_Interfaces
{
    interface IEmployee
    {
        int EmpId { get; set; }

        string EmpName { get; set; }

        int Salary { get; set; }

        string GetEmployeeDetails();

        double CalculateSalary(int salary, int tax);

    }
}
