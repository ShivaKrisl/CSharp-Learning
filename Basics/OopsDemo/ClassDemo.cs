using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearningCodeLanguage.OopsDemo
{
    internal class ClassDemo
    {
        static string name = "Shiva";
        static int age = 22;
        static int salary = 125000;
        static string designation = "Software Engineer";

        internal  void Display()
        {
            Console.WriteLine("Name: " + name);
            Console.WriteLine("Age: " + age);
            Console.WriteLine("Salary: " + salary);
            Console.WriteLine("Designation: " + designation);
        }
    }
}
