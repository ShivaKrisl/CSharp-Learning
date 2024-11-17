using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPS_Methods.Methods.ParameterModifiers
{
    internal class OutParameterModifier
    {
        public int OutParameterModifierMethod(out int a, out int b, int c)
        {
            a = 100;
            b = 200;
            c = 300;
            //Console.WriteLine($"Inside the function : a = {a} and b = {b} and c = {c}");
            return c;
        }
        public void Main()
        {
            int a, b;
            int c = 100;
            Console.WriteLine($"Before method execution assigned c = {c}, a,b are not assigned");
            c = OutParameterModifierMethod(out a, out b, c);
            Console.WriteLine($"After method execution values of a = {a}, b = {b}, returned c = {c}");
        }
    }
}
