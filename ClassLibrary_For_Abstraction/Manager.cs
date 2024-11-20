using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary_For_Abstraction
{
    public class Manager : Employee
    {
        public int Salary { get; set; }

        public Manager(int employeeID, string employeeName, int salary) : base(employeeID, employeeName)
        {
            this.Salary = salary;
        }

        public override string GetEmployeeDetails()
        {
            return "Employee ID: " + this.EmployeeID + " Employee Name: " + this.EmployeeName + " Salary: " + this.Salary;
        }

        public override double CalculateSalary(int salary, int tax)
        {
            return salary - (salary * tax / 100);
        }
    }
}
