using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TypeConversion
{
    internal class ExplicitTypeConversion
    {
        internal void Main()
        {
            double b = 22.04d;
            int a = (int)b;
            Console.WriteLine($"Double Value = {b} converted to Int = {a}");

            float c = 65.99f;
            char ch = (char)c;
            Console.WriteLine($"Float Value = {c} converted to character = {ch}");

            int k = 256;
            byte s = (byte)k;
            Console.WriteLine($"Integer value = {k} converted to byte = {s}");

        }
    }
}
