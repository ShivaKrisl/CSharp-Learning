using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TypeConversion
{
    internal class ImplicitTypeCasting
    {
        internal void Main()
        {
            char a = 'A';
            double b = a;
            Console.WriteLine($"Char {a} is converted to double {b}");

            float c = 10.234567890F;
            double d = c;
            Console.WriteLine($"Float value {c} converted to double {d}");      
        }
    }

}
