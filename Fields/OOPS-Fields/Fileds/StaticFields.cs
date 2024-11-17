using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Public_Class_Demo_ClassLibraries;

namespace OOPS.Fileds
{
    internal class StaticFields
    {

        public void MainMethod()
        {
            Student stud1 = new Student {
                studentHallTicket = 1390,
                studentName = "Shiva Krishna",
            };

            Student stud2 = new Student
            {
                studentHallTicket = 1394,
                studentName = "ChK"
            };

            Console.WriteLine("Student 1 details = ");
            Console.WriteLine("Hall Ticked  = "+stud1.studentHallTicket);
            Console.WriteLine("Name = " + stud1.studentName);
            Console.WriteLine("College = " + Student.collegeName);
            Console.WriteLine("-----------------------------------------");

            Console.WriteLine("Student 2 details = ");
            Console.WriteLine("Hall Ticked  = " + stud2.studentHallTicket);
            Console.WriteLine("Name = " + stud2.studentName);
            Console.WriteLine("College = " + Student.collegeName);
            Console.WriteLine("-----------------------------------------");

            /* Static fields are stored in class memory of heap and value is common for all objects 
             * They can be accessed only using ClassName
             * They are not constants value can be changed but once changed it reflects on entire objects of that class
             */

            Student.collegeName = "NITW";

            Console.WriteLine("Student 1 details = ");
            Console.WriteLine("Hall Ticked  = " + stud1.studentHallTicket);
            Console.WriteLine("Name = " + stud1.studentName);
            Console.WriteLine("College = " + Student.collegeName);
            Console.WriteLine("-----------------------------------------");

            Console.WriteLine("Student 2 details = ");
            Console.WriteLine("Hall Ticked  = " + stud2.studentHallTicket);
            Console.WriteLine("Name = " + stud2.studentName);
            Console.WriteLine("College = " + Student.collegeName);
            Console.WriteLine("-----------------------------------------");
        }
    }
}
