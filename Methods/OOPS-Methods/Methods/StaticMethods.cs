using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using ClassLibraryForMethods;
namespace OOPS_Methods.Methods
{
    internal class StaticMethods
    {
        /*
         * Static Methods are class methods that is common to all objects.
         * It can be called only by Class Name
         * 
         * **Static Methods are used to initialize Static Fields of the class 
         * 
         * To initialize Static Fields we can either:
         * 1. Initialize them in constructor
         * 2. Initialize them by Setter Public Methods 
         * 
         */

        /*
         * NOTES -----------
         * 1. Static Methods cannot access instance fields in its body, but can access other Static Fields of that class
         * 2. Static Methods cannot access instance methods in its body, but can access other Static Methods of that class.
         * 3. You cannot use this keyword
         */

        public void Main()
        {

            StaticMethodsClassLib obj = new StaticMethodsClassLib("SR University");
            obj.SetStudentName("Shiva Krishna");
            obj.SetTotalMarks(570);

            StaticMethodsClassLib ob2 = new StaticMethodsClassLib("NITW");
            ob2.SetStudentName("SomePerson");
            ob2.SetTotalMarks(530);
            

            // Here once you have changed Static field name all objects that field is updated to current value

            Console.WriteLine($"College name 1 = {obj.GetCollegeName()}");
            Console.WriteLine($"Total Marks 1 = {obj.GetTotalMarks()}");

            Console.WriteLine($"College Name 2 = {ob2.GetCollegeName()}");
            Console.WriteLine($"Total Marks 2 = {ob2.GetTotalMarks()}");

            // Set by Public Method -- use Class Name
            StaticMethodsClassLib.SetCollegeName("BVRIT");

            Console.WriteLine($"College name 1 = {obj.GetCollegeName()}");

            Console.WriteLine($"College Name 2 = {ob2.GetCollegeName()}");

            // Passing Object as reference
            double totalMarks = StaticMethodsClassLib.GetFinalMarksOfAll(obj, ob2);
            Console.WriteLine($"Total Marks of 2 Students = {totalMarks}");

            // Default arguments
            double cutOffMarksFor1 = obj.GetTotalCutOffMarks(12.5);
            double cutOffMarksFor2 = ob2.GetTotalCutOffMarks();

            Console.WriteLine($"CutOff Marks by passing argument for Object 1 = {cutOffMarksFor1}");
            Console.WriteLine($"CutOff Marks without passing argument for Object 2 = {cutOffMarksFor2}");


            /* Named Arguments
             *  Some methods may take many arguments and by default you need to pass values as per the order you defined arguments you defined. Hence this may lead to confusion. 
             *  Named args are used in method call to pass values. when they are used Order doesn't matter
             *  --- If one args is passed using named args then all params should also follow named args
             *  SYNTAX --
             *  methodName(paramName:value, ....)
             */
            StaticMethodsClassLib.NamedArgsExample(integerValue : 10, dateTimeValue : DateTime.Now, stringValue:"Shiva Krishna", booleanValue : true);
        }

    }
}
