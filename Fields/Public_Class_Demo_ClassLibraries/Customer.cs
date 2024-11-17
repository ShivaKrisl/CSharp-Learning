using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Public_Class_Demo_ClassLibraries
{
    public class Customer
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string Email { get; set; }

        public string Phone { get; set; }

        public string Address { get; set; }

        public string City { get; set; }

        public string State { get; set; }

        public string Zip { get; set; }

        public Customer()
        {
            // Default Constructor
            Console.WriteLine("Default Constructor called");
        }

        public Customer(int id, string name, string email, string phone)
        {
            this.Id = id;
            this.Name = name;
            this.Email = email;
            this.Phone = phone;

            Console.WriteLine("Parameterized Constructor called");
        }

        public void getDetails()
        {
            Console.WriteLine("Customer Details are ");
            Console.WriteLine("Id: " + this.Id);
            Console.WriteLine("Name: " + this.Name);
            Console.WriteLine("Email: " + this.Email);
            Console.WriteLine("Phone: " + this.Phone);

        }

    }
}
