using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary_For_Abstraction
{
    public abstract class Employee
    {
        public int EmployeeID { get; set; }

        public string EmployeeName { get; set; }

        public Employee(int employeeID, string employeeName)
        {
            this.EmployeeID = employeeID;
            this.EmployeeName = employeeName;
        }

        public abstract string GetEmployeeDetails();

        public abstract double CalculateSalary(int salary, int tax); // say like for Manager tax is 10% and for Developer tax is 5%
    }
}
