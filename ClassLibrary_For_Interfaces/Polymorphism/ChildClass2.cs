using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary_For_Interfaces.Polymorphism
{
    public class ChildClass2 : IParentClass
    {
        public void Add(int a, int b)
        {
            Console.WriteLine("From Child2");
        }
    }
}
