using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary_For_Inheritence_Demo
{
    public class MethodHiding
    {
        public int Id { get; set; }

        public string Name { get; set; }


        public string Display()
        {
            return $"Id = {Id} and Name = {Name}";
        }
    }

    public class ChildClass_MethodHiding : MethodHiding
    {
        public int Salary { get; set; }

        public new string Display()
        {
            return $"Id = {Id} and Name = {Name} and Salary = {Salary}";
        }

    }
}
