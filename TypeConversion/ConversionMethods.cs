using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TypeConversion
{
    internal class ConversionMethods
    {

        internal void Main()
        {
            string s = "1000";

            double d = Convert.ToDouble(s);
            Console.WriteLine($"String = {s} converted to Double = {d}");
        }
    }
}
