using Public_Class_Demo_ClassLibraries;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace OOPS.Fileds
{
    internal class ReadAndRetrive
    {
        /*
             * Fields => are variables that are declared in the class. They are used to store the data
             * 1. They are isolated for each object
             * 
             *   Syntax:
             *   
             *      ACCESSMODFIER  MODIFIER  DATATYPE  fieldName;
             *      
             *  ACCESSMODIFIERS -> defines the scope of that field.
             *  1. public -> field is accessible from any other class or assembly
             *  2. private -> field is accessible only within the class
             *  3. protected -> field is accessible only within the class and its derived classes
             *  4. internal -> field is accessible only within the same assembly
             *  5. protected internal -> field is accessible within the same assembly and its derived classes
             *  6. private protected -> field is accessible only within the same assembly and its derived classes
             *  ** default access modifier is private
             *  
             *  MODIFIERS -> defines the behavior of the field
             *  1. static -> field is shared among all the objects of the class
             *  2. readonly -> field can be assigned a value only once
             *  3. const -> field is a constant and its value cannot be changed
             *  ** it is optional
             * 
             */

        public void ReadAndRetriveFields()
        {
            ProductsFields prodObj1 = new ProductsFields();
            prodObj1.productId = 101;
            prodObj1.productName = "Laptop";
            prodObj1.productCost = 50000;
            prodObj1.productStock = 10;

            ProductsFields prodObj2 = new ProductsFields();
            prodObj2.productId = 102;
            prodObj2.productName = "Mobile";
            prodObj2.productCost = 20000;
            prodObj2.productStock = 20;

            Console.WriteLine("Product 1 Details");
            Console.WriteLine("Product Id: " + prodObj1.productId);
            Console.WriteLine("Product Name: " + prodObj1.productName);
            Console.WriteLine("Product Cost: " + prodObj1.productCost);
            Console.WriteLine("Product Stock: " + prodObj1.productStock);

            Console.WriteLine("----------------------------");

            Console.WriteLine("Product 2 Details");
            Console.WriteLine("Product Id: " + prodObj2.productId);
            Console.WriteLine("Product Name: " + prodObj2.productName);
            Console.WriteLine("Product Cost: " + prodObj2.productCost);
            Console.WriteLine("Product Stock: " + prodObj2.productStock);
        }
    }
}
