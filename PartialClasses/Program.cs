
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLibrary_For_PartialClasses;

namespace PartialClasses
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             * PARTIAL CLASSES
             * 1. Partial classes are used to split the definition of a class into multiple files.
             * 2. The partial keyword can be used to split the definition of a class, a struct, an interface, or a method over two or more source files.
             * 3. This helps different developers to work on different parts of the same class.
             * 4. At the time of compilation, the compiler combines all the partial classes into a single class.
             * ***  5. But namespace must be the same for all the partial classes and class name as well and should be in same assembly.
             * *** 6. Access modifiers must be the same for all the partial classes and it should be only Public or Internal.
             * *** 7. If any part of the partial class is declared as sealed, then the entire class is considered as sealed. same for abstract
             * *** 8. Partial can be applied for classes, structs, interfaces, and methods.
             */

            // Create an object of the Product class
            Product product = new Product();
            product.ProductId = 101;
            product.ProductName = "Laptop";
            product.Price = 45000;
            Console.WriteLine("Product Id: " + product.ProductId);
            Console.WriteLine("Product Name: " + product.ProductName);
            Console.WriteLine("Price: " + product.Price);
            Console.WriteLine("Tax: " + product.CalculateTax());


            /*
             * PARTIAL METHODS
             * 1. Partial Methods are declared in one classes and implemented in another part of the class.
             * 2. Partial methods are private by default and it cannot have any access modifier so there should be one more public method in the class to call the partial method.
             * 3. Partial methods can have only a single method signature and no body.
             * 4. Partial methods are used in Entity Framework to implement the OnModelCreating method.
             * 5. Partial methods can only return void. -- return type must be void, to return a value use out parameter or call that method in another method.
             * 6. Partial methods can be static or instance methods.
             * 7. In general a partial method should have atleast 3 partial classes.
             *      a. One for method declaration
             *      b. One for method implementation
             *      c. One for calling the method.
             */

        }
    }
}
