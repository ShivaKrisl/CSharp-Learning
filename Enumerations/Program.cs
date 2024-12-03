using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enumerations
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             * ENUMERATIONS
             * 1. is a collection of constants
             * 2. used to specify list of options allowed to be stored inside field/variable
             * 3. SYNTAX:
             *      MODIFIER enum ENUMNAME{
             *          //Space seperated constants
             *      }
             * 4. To access => ENUMNAME.ConstantName;
             * 
             * 5. Enums can also be used as return type for methods
             * 
             * 
             * *** 1. In enums every constant has an int value starting with 1
             * ***2. You can set your default int value like CONSTNAME = VALUE but next constants will follow sequential order with new
             * ***3. you can aslo type case enum to short, long, byte only (both signed and unsigned)
             * SYNTAX: 
             *        internal enum AgeGroup : <DTYPE>
                        {
                            Child, Teenager, Adult, Senior
                        }
                       DTYPE is optional, by default is int,
             */


            Person p1 = new Person();
            p1.PersonName = "Shiva";
            p1.PersonAge = AgeGroup.Adult;
            p1.Health = "Fever";

            Console.WriteLine(p1.ToString());

            // You can also return an enum datatype

            HealthStatus status = p1.GetStatus();
            Console.WriteLine(status);
        }
    }
}
