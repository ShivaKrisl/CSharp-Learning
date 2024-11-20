using ClassLibrary_For_Abstraction;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPS_Abstraction
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            * ABSTRACTION
            * 1. is a concept of representing objects in a simplified way by only focusing on essential features and ignoring the unnecessary details.
            * 2. It provides a way to create a blueprint or contract for derived classes to follow, ensuring consistency in the code.
            * 3. It is process of hiding the implementation details and showing only the functionality to the user.
            * 4. It can be achieved by using abstract classes and interfaces.
            * 5. Abstract class is a class that cannot be instantiated and is used to define a blueprint for derived classes.
            * 6. Abstract method is a method that is declared in an abstract class and does not have an implementation.
            * 7. Abstract class can have both abstract methods and non-abstract methods.
            * 8. Abstract class is parent class and its child classes are called as Derived classes.
            * 9. The derived classes must implement the abstract methods of the abstract class.
            * 
            * NOTE => A normal class can have abstract methods but it must be declared as abstract class. ie we cannot create abstract methods in a normal class.
            * 
            * ADVATNAGES
            * 1. Makes the program loosely coupled (makes the classes less dependent on each other).
            */

            /*
             * ABSTARCT CLASS
             * 1. Abstract class is a class that cannot be instantiated and is used to define a blueprint for derived classes.
             * 2. Child classes can inherit from the abstract class and implement its abstract methods.
             * 3. Abstract class can contains all type of members like fields, properties, methods, constructors, events, indexers, etc.
             * 4. An abstract class can have both abstract methods and non-abstract methods.
             * 5. It can be a child of other classes or other abstract classes or interfaces.
             * eg: Shape is an abstract class and Circle, Rectangle, Triangle are derived classes. as shape class cannot exist without a specific shape.
             *     Vechicle is an abstract class and Car, Bike, Bus are derived classes. as vechicle class cannot exist without a specific vechicle.
             *  
             *  ---------
             *  SYNTAX: <ACCESS_MODIFIER> abstract class <CLASS_NAME>{
             *          Members
             *  }
             *  
             *  
             */
            
            Manager manager = new Manager(101, "John", 50000);
            Console.WriteLine(manager.GetEmployeeDetails());


            /*
             * ABSTRACT METHODS
             * 1. are methods that are declared in an abstract class and does not have an implementation.
             * 2. The derived classes must implement the abstract methods of the abstract class using override keyword.
             * 3. It contains only the method signature and no body.
             * 4. Abstract methods are declared only in abstract classes and interfaces.
             * 
             * NOTE => 
             * 1. Abstract methods cannot be private or static or sealed or virtual.
             * 2. If parent class wants to have method body and it want it's child class to override it then use virtual keyword. -- Overriding
             * 3. If parent class wants to have method body and it doesn't want it's child class to override it then use sealed keyword. -- Sealing
             * 4. If parent class does not wants to have method body and it want it's child class to provide method body then use abstract keyword. -- Abstraction
             * 5. It is optional to use override the virtual methods but it is mandatory to override the abstract methods in child classes
             */

            Manager manager1 = new Manager(102, "Smith", 60000);
            Console.WriteLine(manager1.GetEmployeeDetails());
            Console.WriteLine("Manager Salary = "+manager1.CalculateSalary(manager1.Salary, 10));

            Developer developer = new Developer(201, "David", 40000);
            Console.WriteLine(developer.GetEmployeeDetails());
            Console.WriteLine("Developer Salary = " + developer.CalculateSalary(developer.Salary, 5));
        }
    }
}
