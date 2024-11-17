using Public_Class_Demo_ClassLibraries;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPS.Fileds
{
    internal class ConstantFields
    {
        public void MainMethod()
        {
            /*
             * CONSTANT FIELDS => Constant fields are like static fields ie, They are common to all the objects and can be accessed only by the class name.
             * ** but, the difference is in Constant field once the value is assigned it cannot be changed later
             * ** constant fields must be initialized, in line with the declaration it self only.
             * ** Constants cannot be referenced variables
             */

            Student stud1 = new Student
            {
                studentHallTicket = 1390,
                studentName = "Shiva Krishna",
            };

            Student stud2 = new Student
            {
                studentHallTicket = 1394,
                studentName = "ChK"
            };

            Console.WriteLine("Student 1 details = ");
            Console.WriteLine("Hall Ticked  = " + stud1.studentHallTicket);
            Console.WriteLine("Name = " + stud1.studentName);
            Console.WriteLine("College = " + Student.collegeName);
            Console.WriteLine("Constant Field Value = "+Student.constField);
            Console.WriteLine("-----------------------------------------");

            Console.WriteLine("Student 2 details = ");
            Console.WriteLine("Hall Ticked  = " + stud2.studentHallTicket);
            Console.WriteLine("Name = " + stud2.studentName);
            Console.WriteLine("College = " + Student.collegeName);
            Console.WriteLine("-----------------------------------------");
            Console.WriteLine("Constant Field Value = " + Student.constField);

           
            // Trying to change value but will get error
            //Student.constField = "Value Changing";
        }
    }
}
