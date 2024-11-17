using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPS_Methods.Methods
{
    internal class LocalFunctions
    {
        /*
         * Local functions are functions that are defined inside another function. that can be used to perform some operation that is only required within the scope of the outer function.
         * scope of local function is limited to the outer function.
         * access modifiers and modifiers are not allowed for local functions.
         * Syntax: =>
         * OuterMethod(parameters){
         *       
         *      LocalMethodName(parameters); // method call
         *      
         *      DataType LocalMethodName(parameters){
         *          // code to be executed
         *      }
         * }
         */

        public string GetPassOrFail(params int[] marks)
        {

            int total = GetTotalMarks();

            int GetTotalMarks()
            {
                int sum = 0;
                foreach (int mark in marks)
                {
                    sum += mark;
                }
                return sum;
            }

            if(total > 450)
            {
                return "Pass";
            }

            return "Fail";
        }
        public void Main()
        {
            string result = GetPassOrFail(45,76,89,98,56,67);
            Console.WriteLine(result);
        }
    }
}
