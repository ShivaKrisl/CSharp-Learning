using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPS_Methods.Methods.ParameterModifiers
{
    internal class DefaultParameterModifier
    {

        public void DefauParameterMethod(int a, int b)
        {
            a = 100;
            b = 200;
            Console.WriteLine($" Inside the function : a = {a} and b = {b}");
        }

        public void Main()
        {
            int a = 10;
            int b = 20;
            Console.WriteLine($" Before calling the function : a = {a} and b = {b}");
            DefauParameterMethod(a, b);
            Console.WriteLine($" After calling the function : a = {a} and b = {b}");
        }
    }
}
