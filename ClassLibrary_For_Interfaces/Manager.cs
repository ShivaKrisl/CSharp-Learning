using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary_For_Interfaces
{
    public class Manager : IEmployee
    {
        public int EmpId { get; set; }

        public string EmpName { get; set; }

        public int Salary { get; set; }

        public int Tax { get; set; }

        public Manager(int empId, string empName, int salary, int tax)
        {
            this.EmpId = empId;
            this.EmpName = empName;
            this.Salary = salary;
            this.Tax = tax;
        }

        public double CalculateSalary(int salary, int tax)
        {
            double sal = 0;
            sal = salary - (salary * tax / 100);
            return sal;
        }

        public string GetEmployeeDetails()
        {
            return $"Employee Details: Name = {this.EmpName}, Id = {this.EmpId}, Expected CTC = {this.Salary}, Tax = {this.Tax}";
        }
    }
}
