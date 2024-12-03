using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary_For_Interfaces.InterfaceInheritence
{
    public interface IPerson
    {
        string Name { get; }

        DateTime DateOfBirth { get; set; }

        int CalculateAge();
    }
}
