using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPS_Properties
{
    internal class Employee
    {
        private int _empId;

        private string _empName;

        private string _jobTitle;

        private static string _companyName = "Microsoft";

        private int _salary;

        // Define - Properties

        public int empId
        {
            set
            {
                if (value >=100)
                {
                    this._empId = value;
                }
            }
            get
            {
                return this._empId;
            }
        }

        public string empName
        {
            set
            {
                this._empName = value;
            }
            get
            {
                return this._empName;
            }
        }

        public string jobTitle
        {
            set
            {
                this._jobTitle = value;
            }
            get
            {
                return this._jobTitle;
            }
        }

        public static string companyName
        {   
            get
            {
                return _companyName;
            }
        }

        // Read only property
        public int Salary
        {
            get
            {
                return this._salary;
            }
        }

        internal Employee(int id, string name, string title)
        {
            this.empName = name;
            this.empId = id;
            this.jobTitle = title;
            this._salary = 100000;
        }

        public override string ToString()
        {
            return $"Name = {this.empName}, Id = {this.empId} and Job {this.jobTitle} Company name = {companyName} and Salary = {this.Salary}";
        }
    }
}
