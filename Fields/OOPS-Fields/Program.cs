using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Public_Class_Demo_ClassLibraries;
using OOPS.Fileds;

namespace OOPS
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //System.Console.WriteLine("Hello World");

            /* Object Oriented Programming
             * 1. is a programming paradigm for building Scalabale applications
             * 2. Goal is to organize the code in a way that is easy to manage and maintain
             * 3. It organize the data and related operations into a single unit called class that can be used to create objects
             * 4. OBJECT => is an instance of a class that represents real world entity
             *      each object has its own state and behavior
             *      They are stored in Heap memory
             * 5. CLASS => is a blueprint/model for creating objects. It reperesents the struture(list of fileds and methods) of    data that you want to store in similar objects.. A class is not a collection of objects
             * 6. METHOD => is a function that is associated with a class. It is collection of statements to perform a specific     task/operation such as display, calculate, conditional check, read, update etc.
             *     Methods access fileds of the class to perform the operation and they should be member of the class
             */

            /*
             * Creating a Class
             *  <ACCESSMODIFIER> <MODIFIER> class ClassName{                       -- ClassName should be Pascal Cased
             *      // Your Class Data Fileds here
             *      
             *      // Your Class methods here
             *   }
             *   
             *   ACCESS MODIFIERS -> defines the scope of the class and its members. They are public, private, protected, internal, protected internal
             *   Solution is collection of projects
             *   1. public -> class and its members are accessible from any other class or assembly (other projects)
             *   2. private -> class and its members are accessible only within the class
             *   3. protected -> class and its members are accessible only within the class and its derived classes
             *   4. internal -> class and its members are accessible only within the same assembly(project)
             *   5. protected internal -> class and its members are accessible within the same assembly and its derived classes
             *   6. private protected -> class and its members are accessible only within the same assembly and its derived                 classes
             *   Default access modifier is Internal
             *   
             *   MODIFIERS -> defines the behavior of the class and its members. They are abstract, sealed, static, virtual, partial
             *   1. abstract -> class or method that is declared as abstract must be implemented in the derived class
             *   2. sealed -> class or method that is declared as sealed cannot be inherited or overridden
             *   3. static -> class or method that is declared as static can be accessed without creating an instance of the                    class
             *   4. virtual -> class or method that is declared as virtual can be overridden in the derived class
             *   5. partial -> class that is declared as partial can be split into multiple files. Multiple partial class files         can be combined into a single class
             *   
             *   ** Modifier is Optional
             *   
             *   Inside class you can have: 
             *   1. Data Fields
             *   2. Methods
             *   3. Constructors
             *   4. Properties
             *   5. Events
             *   6. Destructors
             *  
             */

            /*
             *  Creating an Object
             *  1. Objects are stored in Heap memory and they are nameless. only one Heap for entire application
             *  2. We create a reference variable of the class (stored in the call Stack) and refer it to the object created
             *  3. object is created using the new keyword
             *  4. One reference variable can refer to only one object at a time
             *  5. Reference variable can be used to access the data fields and methods of the class
             *  6. Reference Variables are local variables and they are stored in the call stack
             *  
             *  1. first Create a reference variable of the class
             *      ClassName referenceVariable;
             *  2. Create an object of the class using the new keyword
             *       new ClassName();
             *  3. Assign the object to the reference variable
             *       referenceVariable = new ClassName();
             */

            // Example
            Customer custObj = new Customer(10, "Shiva", "siva@gmail.com", "9398325300");
            custObj.getDetails();
            Console.WriteLine("----------------------------");

            // Fileds
            ReadAndRetrive readAndRetrive = new ReadAndRetrive();
            readAndRetrive.ReadAndRetriveFields();

            // Access Modifier of Fields
            AcessModifiers obj = new AcessModifiers();
            obj.ModifiersMainMethod();

            // Static Fields
            StaticFields staticFieldObject = new StaticFields();
            staticFieldObject.MainMethod();


        }
    }
}
