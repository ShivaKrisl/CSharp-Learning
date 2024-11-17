using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLibrary_For_Indexers;

namespace OOPS_Indexers
{
    internal class Program
    {
        static void Main(string[] args)
        {

            /*
             * INDEXERS
             * 1. are old concept in C#.
             * 2. are used to access elements of a class like an array.
             * 3. Indexers receive a value that search for a particualr item among group of items.
             * 4. It can also set or gets the value into group of items.
             * 5. INDEXERS ARE DEFINED USING 'THIS' KEYWORD.
             * 6. Indexers cannot have ref or out parameters.
             * 7. Indexers cannot be static.
             * 8. can be overloaded.
             * Syntax:
             * ACCESS_MODIFIER MODIFIER RETURN_TYPE this[INDEX_TYPE index]
             * {
             *   set{
             *          this.FEILD_NAME[index] = value;
             *    
             *   }
             *   
             *   get{
             *          return this.FEILD_NAME[index];  
             *   }
             * }
             */

            Car car = new Car();
            Console.WriteLine($"Initial Value = {car[3]}");
            car[3] = "Jaguar";
            Console.WriteLine($"After Changing Value = {car[3]}");
            Console.WriteLine("cars are:");
            for (int i = 0; i < 7; i++)
            {
                Console.WriteLine(car[i]);
            }

            car["third"] = "Nexas";
            Console.WriteLine($"With Index Overloading = {car["third"]}");
        }
    }
}
