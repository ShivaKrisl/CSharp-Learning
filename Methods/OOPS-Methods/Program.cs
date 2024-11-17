using OOPS_Methods.Methods;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using OOPS_Methods.Methods.ParameterModifiers;

namespace OOPS_Methods
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             * Method ==> is a function (block of code) to do operation on fields of a class.
             * 1. Written inside class
             * 2. Are not stored inside objects but can be called by objects
             * 3. They can take zero or more inputs as args (parameters) and can return value
             * 
             * Syntax => 
             *   <AcessModifier> <Modifier> Return-Type METHODNAME (dtype parameter1, dtype parameter2, etc...){
             *      // code to be executed
             *      return output
             *   }
             * AccessModifiers => are optional and are same like fields modifiers (private, internal, public, protected, private protected, internal protected) default is private
             * Modifiers => are optional. so no default value
             *      These are
             *      -static
             *      -virtual
             *      -abstract
             *      -override
             *      -new
             *      -partial
             *      -sealed
             *      
             */

            // General Method Example
            //MethodGeneralClass methodGeneralClass = new MethodGeneralClass();
            //methodGeneralClass.Main();

            // Encapsulation

            // Static Methods
            StaticMethods obj = new StaticMethods();
            obj.Main();

            // Method overloading
            MethodOverloading methodOverloading = new MethodOverloading();
            methodOverloading.Main();

            // Default Parameter Modifier
            DefaultParameterModifier defaultParameterModifier = new DefaultParameterModifier();
            defaultParameterModifier.Main();

            // Ref Parameter Modifier
            RefParameterModifier refParameterModifier = new RefParameterModifier();
            refParameterModifier.Main();

            // Out Parameter Modifier
            OutParameterModifier outParameterModifier = new OutParameterModifier();
            outParameterModifier.Main();

            // params Parameter Modifier
            ParamsParameterModifier paramsParameterModifier = new ParamsParameterModifier();
            paramsParameterModifier.Main();

            // Local Functions
            LocalFunctions localFunctions = new LocalFunctions();
            localFunctions.Main();

            // Static Local Functions
            StaticLocalFunctions staticLocalFunctions = new StaticLocalFunctions();
            staticLocalFunctions.Main();
        }
    }
}
