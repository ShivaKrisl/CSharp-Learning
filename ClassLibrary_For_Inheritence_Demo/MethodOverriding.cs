using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary_For_Inheritence_Demo
{
    public class MethodOverriding
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public virtual void Display(int id, string name, string location)
        {
            Console.WriteLine($"Id = {id} and Name = {name}");
        }

    }

    public class ChildClass_OverRiding : MethodOverriding
    {

        public string Location { get; set; }

        public override void Display(int id, string name, string location)
        {
            base.Display(id, name, location);
            Console.WriteLine($"Loaction = {location}");
        }

    }
}
