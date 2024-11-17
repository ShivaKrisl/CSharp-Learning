using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TypeConversion
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             * Type Conversion => is the process of converting data from one datatype(Source) to another datatype (destination)
             * 4 techiniques::
             * 1. Implicit Type Casting -> from lower numerical to higher numerical
             * 2. Explicit Type Casting -> higher numerical to lower
             * 3. Parsing / TryParse -> string  to numerical
             * 4. Conversion Methods -> convert one primitive type to other primitive type
             */

            /*
             * Implicit casting (conversion from lower to higher)
             * 1. sbyte -> short, int, long, float, double, decimal
             * 2. byte -> short, ushort, int, uint, long, ulong, float, double, decimal
             * 3. short -> int, long, float, double, decimal
             * 4. ushort -> int, uint, long, ulong, float, double, decimal
             * 5. int -> long, float, double, decimal
             * 6. uint -> long, ulong, float, double, decimal
             * 7. long -> float, double, decimal
             * 8. ulong -> float, double, decimal
             * 9. float -> double,
             * 10. double -> NONE
             * 11. decimal -> NONE
             * 12. char -> ushort, short, uint, int, ulong, long, float, double, decimal
             * 13. bool -> NONE
             * 14. string -> NONE
             */
            ImplicitTypeCasting implicitTypeCasting = new ImplicitTypeCasting();
            implicitTypeCasting.Main();

            /*
             * Explicit Type Conversion (conversion from higher numerical to lower)
             * SYNTAX : resultDtype var = (DestinationType) srcvariable
             * may cause in loosing the original value
             * eg: you want to convert 200 to sbyte => not in range so it roundoffs
             * 
             * 1. sbyte -> byte, ushort, uint, ulong
             * 2. byte -> sbyte
             * 3. short -> sbyte, byte, ushort, uint, ulong
             * 4. int -> sbyte, byte, short, ushort, uint, ulong
             * 5. uint -> sbyte, byte, short, ushort, int
             * 6. long -> sbyte, byte, short, ushort, int, uint, ulong
             * 7. ulong -> sbyte, byte, short, ushort, int, uint, long
             * 8. float -> sbyte, byte, short, ushort, int, uint, long, ulong, decimal
             * 9. double -> sbyte, byte, short, ushort, int, uint, long, ulong, float, decimal
             * 10. decimal -> sbyte, byte, short, ushort, int, uint, long, ulong, float, double
             * 11. char -> sbyte, byte, short, ushort, int, uint, long, ulong, float, double, decimal
             * 12. bool -> NONE
             * 13. string -> NONE 
             * 
             * USES =>
             * 1. When we want to convert Child class value to Parent class value
             */
            ExplicitTypeConversion explicitTypeConversion = new ExplicitTypeConversion();
            explicitTypeConversion.Main();

            /*
             * 3. Parse/Try Parse => To convert String Data Type to Numerical Data Type (but string should contain only Numbers)
             * Parse => will return FormatException if given string is unable to converted to Numerical data
             * TryParse => will return boolean value and has one out parameter. If boolean is True indicates that string is converted to numerical type and result is stored in out parameter.
             * Syntax => 
             * 
             *    bool check = destType.TryParse(SrcValue, Out destType var)
             *    if (check == true){
             *          // do operations with var 
             *    }
             *    else{
             *          // conversion failed
             *    }
             * 
             */
            TryParseConversion tryParseConversion = new TryParseConversion();
            tryParseConversion.Main();

            /*
             * Conversion Methods => used to convert from one primitive data type to other primitive data type
             * Here we use System.Convert Class that has all Static Conversion methods
             * 1. ToInt16()  -> convert to short
             * 2. ToInt32() -> convert to int
             * 3. ToInt64() -> to long
             * 4. ToDecimal()
             * 5. ToDouble()
             * 6. ToString()
             * 7. ToBoolean()
             * 8. ToDateTime()
             * 
             * NOTE =>  If given value is unable to convert to destination data type then it gives FormatException Error
             * 
             */
            ConversionMethods conversionMethods = new ConversionMethods();
            conversionMethods.Main();

            /*
             * 1. For all the possible cases of 'implicit casting' and 'explicit casting', it is preferred to use 'explicit casting' or 'conversion methods' always.
             * 2. For conversion from 'string' to 'numerical type', use TryParse, instead of 'Parse'; as 'TryParse' avoids exceptions.
             */
        }
    }
}
