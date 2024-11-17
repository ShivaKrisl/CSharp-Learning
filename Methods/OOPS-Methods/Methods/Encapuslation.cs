using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using ClassLibraryForMethods;

namespace OOPS_Methods.Methods
{
    internal class Encapuslation
    {
        /*
         * Encapsulation =>  is a method of binding data members and its related properties that manipulate the data
         * it hides the internal details of object and provides essential members interacting with them
         * 
         * Need =>
         * ** Before setting a value into field we might want to perform some validations, checks, operations. thus, methods helps to do this.
         * 
         * Benifits =>
         * 1. Hides Implementation
         * 2. Modularity
         * 3. Data Integrity  => code present outside the class cannot access fields directly. They need to use Public methods
         * 
         * These are implemented using Private Fields & (Public properties or public methods)
         * like you have private fields and want to set/get values to it. But they cannot be set/get directly hence we use public methods to interact with these fields
         * 
         * ** Generally:
         * 1. For each field instead of setting values directly, we use 2 methods for each fields setMethod and getMethod
         * 2. For readonly fields you cannot have Set Method, they need to set only from constructor and will have GetMethod
         * 3. Not only private fields access we can also call private methods of the class in the Public Methods
         */

        public void Main()
        {
            EncapsulationClassLib product1 = new EncapsulationClassLib();
            product1.SetProductID(1);
            product1.SetProductName("S23FE");
            product1.SetProductPrice(33999);
            product1.SetProductQuantity(1);


            EncapsulationClassLib product2 = new EncapsulationClassLib();
            product2.SetProductID(2);
            product2.SetProductName("Dell");
            product2.SetProductPrice(65000.99);
            product2.SetProductQuantity(2);

            Console.WriteLine("Product 1 Details are = ");
            Console.WriteLine($"Product Id = {product1.GetProductID()}");
            Console.WriteLine($"Product Name = {product1.GetName()}");
            Console.WriteLine($"Product Price = {product1.GetPrice()}");
            Console.WriteLine($"Product Quantity = {product1.GetQuantity()}");
            Console.WriteLine($"Product Purchased Date = {product1.GetPurchasedDate()}");


        }
    }
}
