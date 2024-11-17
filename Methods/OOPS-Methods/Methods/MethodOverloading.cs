using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPS_Methods.Methods
{
    internal class MethodOverloading
    {
        /*
         * MethodOverloading => Multiple Methods having same name with different no.of parameters and diff order
         */
        public void Main()
        {
            GetDetails();
            GetDetails(390);
            GetDetails("Shiva Krishna");
            GetDetails("Shiva Krishna", 390);
            GetDetails(390, "Shiva Krishna");
        }

        public void GetDetails()
        {
            Console.WriteLine("Nothing was supplied");
        }

        public void GetDetails(int hallTicket)
        {
            Console.WriteLine($"Only HallTicket was supplied = {hallTicket}");
        }

        public void GetDetails(string name)
        {
            Console.WriteLine($"Only name was supplied = {name}");
        }

        public void GetDetails(int hallTicket, string name)
        {
            Console.WriteLine($"Both HallTicket = {hallTicket} and Name = {name} are supplied");
        }

        public void GetDetails(string name, int hallTicket)
        {
            Console.WriteLine($"Both name = {name} and HallTicket = {hallTicket} are supplied");
        }
    }
}
