using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPS_Methods.Methods.ParameterModifiers
{
    internal class RefParameterModifier
    {

        public void RefParameterMethod(ref int a, ref int b)
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

            RefParameterMethod(ref a, ref b);

            Console.WriteLine($" After calling the function : a = {a} and b = {b}");

        }
    }
}
