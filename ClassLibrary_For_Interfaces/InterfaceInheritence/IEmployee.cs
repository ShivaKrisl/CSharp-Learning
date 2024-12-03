using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary_For_Interfaces.InterfaceInheritence
{
    public interface IEmployee : IPerson
    {
        int EmpID { get; }

        double Salary { get; }

        string GetEmployeeDetails();

    }
}
