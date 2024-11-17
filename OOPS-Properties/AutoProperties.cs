using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPS_Properties
{
    internal class AutoProperties
    {

        public int empId { get; set; }

        public string empName { get; set; }

        public string jobTitle { get; set; }

        // default value
        public string companyName { get; set; } = "Microsoft";

        public int salary { get; set; }



        public void DisplayEmployeeDetails()
        {
            Console.WriteLine("Employee ID: " + empId);
            Console.WriteLine("Employee Name: " + empName);
            Console.WriteLine("Job Title: " + jobTitle);
            Console.WriteLine("Company Name: " + companyName);
            Console.WriteLine("Salary: " + salary);
        }


    }
}
