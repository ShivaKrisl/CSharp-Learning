using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary_For_Interfaces.InterfaceInheritence
{
    public class Developer : IEmployee
    {
        public string Name { get; set; }

        public DateTime DateOfBirth
        {
            get;
            set;
        }
        public int CalculateAge()
        {
            int age = Convert.ToInt32((DateTime.Now.Year - DateOfBirth.Year));
            return age;
        }

        public int EmpID { get; set; }

        public double Salary { get; set; }

        public Developer(int empID, string name, double salary, DateTime dob)
        {
            this.EmpID = empID;
            this.Name = name;
            this.Salary = salary;
            this.DateOfBirth = dob;
        }

        public string GetEmployeeDetails()
        {
            return $"Employee ID: {this.EmpID}, Name: {this.Name}, Age: {this.CalculateAge()},Salary: {this.Salary}";
        }

    }
}
