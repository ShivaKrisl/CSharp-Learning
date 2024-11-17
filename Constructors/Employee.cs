using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constructors
{
    internal class Employee
    {
        internal int Id;

        internal string Name;

        internal string JobTitle;

        internal static string CompanyName;

        internal Employee()
        {
            this.Id = 1;
            this.Name = "Default Name";
            this.JobTitle = "Default Title";
        }

        internal Employee(int id)
        {
            this.Id = id;
        }

        internal Employee(int id, string name)
        {
            this.Id = id;   
            this.Name = name;
        }



        internal Employee(int id, string name, string jobTitle)
        {
            this.Id = id;
            this.Name = name;
            this.JobTitle = jobTitle;
        }

        static Employee()
        {
            CompanyName = "Microsoft";
        }

        public override string ToString()
        {
            return $"Employee Id = {this.Id}, Name = {this.Name} and Job = {this.JobTitle}";
        }
    }
}
