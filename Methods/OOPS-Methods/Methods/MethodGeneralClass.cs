using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using ClassLibraryForMethods;

namespace OOPS_Methods.Methods
{
    internal class MethodGeneralClass
    {
        public void Main()
        {
            Product product1 = new Product(1, "Mobile", 12500, 1);
            product1.CalculateTax();
            Product product2 = new Product(2, "Laptop", 45000, 2);
            product2.CalculateTax();
            Product product3 = new Product(3, "Desktop", 6500, 2);
            product3.CalculateTax();


            //product1.setPid(10);

            Console.WriteLine("Product One Details = ");
            Console.WriteLine(product1.ToString());

            Console.WriteLine("Product Two Details = ");
            Console.WriteLine(product2.ToString());

            Console.WriteLine("Product Three Details = ");
            Console.WriteLine(product3.ToString());

        }


    }
}
