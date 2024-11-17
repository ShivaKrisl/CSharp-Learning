using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TypeConversion
{
    internal class TryParseConversion
    {
        internal void Main()
        {
            string s = "29994";
            bool check = ushort.TryParse(s, out ushort res);
            if (check)
            {
                Console.WriteLine($"Conversion success from String = {s} to UShort = {res}");
            }
            else
            {
                Console.WriteLine($"Conversion failed for supplied value string  = {s}");
            }
        }

    }
}
