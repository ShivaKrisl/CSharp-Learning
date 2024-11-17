using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPS_Methods.Methods
{
    internal class StaticLocalFunctions
    {
        /*
         * Static Local functions => introduced in C# 8.0
         * It is ability of a function to use local functions as static functions.
         * As a result of static The variables or parameters of OuterFunction cannot be accesed inside the local function (to do so we need pass these variables as an argument). This static is different from static keyword of Class, Method or Fields
         * 
         */


        public void StaticLocalMethod()
        {
            int a = 10, b = 20, c = 30;
            LocalFunction(b,c);

            static void LocalFunction(int b, int c)
            {

                //Console.WriteLine($"value of a inside local = {a}"); cannot access a 
                int a = 30;
                Console.WriteLine($"Value declared inside local = {a}");
                Console.WriteLine($"Values passed as paramter = {b} and {c}");
            }
        }

        public void Main()
        {
            StaticLocalMethod();
            //LocalFunction(); // cannot access LocalFunction as it is local to StaticLocalMethod
        }
    }
}
