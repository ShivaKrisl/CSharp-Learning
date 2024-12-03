using ClassLibrary_For_Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLibrary_For_Interfaces.Polymorphism;
using ClassLibrary_For_Interfaces.MultipleInheritence;
using ClassLibrary_For_Interfaces.InterfaceInheritence;

namespace OOPS_Interfaces
{
    public class Program
    {
        static void Main(string[] args)
        {
            /*
             * INTERFACES
             * 1. Interface is "pure abstract class" that contains only abstract methods. ie it cannot have normal methods
             * 2. Interfaces starts with "I<NAME>"
             * 3. It will have members (fields, properties, etc..) and declaration of abstract methods.
             * 4. Access Modifiers of all members in interface must be Public and default is public and its implementations are public and abstract
             * 5. It childs classes should implement all its methods
             * 6.You cannot create object and reference variable for Interfaces
             * 7. A child class can implement multiple Interfaces ---> Multiple Inheritence
             * 8. Interface Inheritence => an Interface is a child of another Interface 
             * ****9 Interface can only have non-static events, abstract methods and non-static auto implemented properties and by default interface methods are abstract even without writing abstract keyword 
             * NOTE: 
             *  1. A normal class can be a parent of an Abstract class
             *  2. A normal class or Abstract class cannot be a parent of an Interface
             *  3. In normal classes you cannot create Abstract methods
             * SYNTAX:
             *  interface <INTERFACE_NAME>{
             *      // members
             *      // abstract method declarations
             *  }
             */

            Manager manager = new Manager(1, "Shiva", 5100000, 12);
            Console.WriteLine(manager.GetEmployeeDetails());
            Console.WriteLine($"Actual Salary = {manager.CalculateSalary(manager.Salary, manager.Tax)}");



            /*
             * POLYMORPHISM
             * 1. provides the ability to the developer to define different implementations for the same method in the same class or different classes
             * 2.Poly = many forms ie based on different situations a method executes different behaviour
             * 3.Polymorphism is 2 types
             *         1. STATIC POLYMORPHISM (Compile Time / Early Binding) --- eg: Method Overloading
             *                  which method should be executed if we have same methods but diff params -- if decision is taken by compiler then it                   is called as Compile time Polymorphism
             *          
             *         2. DYNAMIC (Run Time / Late Binding) --- eg: Method Overriding
             *                  Say an Interface having abstract method and multiple child classes implementing them. Which method should be                          executed? -- decision is taken by CLR during execution based on Object reference (Which obj is callling that method)
             *                  this is called as Run-time
             *                  
             */

            IParentClass obj;

            obj = new ChildClass1();  // creating ref to Child class 1
            obj.Add(10, 20);


            obj = new ChildClass2(); // Changing ref to class 2
            obj.Add(10, 20);


            /*
             * MULITPLE INHERITENCE
             * 1. It is the ability of a class to have more than one parent class. This can be acheieved using Interfaces
             * 2. C# does not support Multiple Inheritence using classes but it supports using Interfaces
             * 3. In this case child class should implement all the methods of all the interfaces
             * 4. If there are same methods in both the interfaces then child class should implement that method
             */

            //FlyingCar flyingCar = new FlyingCar();
            //flyingCar.NoOfWheels = 4;
            //flyingCar.NoOfWings = 2;
            //flyingCar.Drive();
            //flyingCar.Fly();
            //flyingCar.Land();
            //flyingCar.Stop();

            /* INTERFACE INHERITENCE
             * 1. An Interface can inherit from another Interface 
             * 2. In this case even when you create reference to Child Interface then you can access all the methods of Parent Interface
             * 3. 
             */
            Developer developer = new Developer(1, "Shiva", 5100000, new DateTime(2003, 08, 05));
            Console.WriteLine(developer.GetEmployeeDetails());

            /*
             * EXPLICIT INTERFACE IMPLEMENTATION
             * 1. Creating two methods with same method signature in two different interfaces and implementing both interfaces in same child class
             * 2. In this case you cannot access the methods of the interfaces directly using the object of the child class
             * 3. In this case to distinguish the methods you need to Add the Interface name before the method name
             * 
             * Eg:
             *      interface IVehicle{
             *              void Move();
             *      }
             *      interface IFlying{
             *              void Move();
             *      }
             *      
             *      class FlyingCar : IVehicle, IFlying{
             *              
             *              void IVehicle.Move(){
             *                  // Calling from IVehicle
             *              }
             *              void IFlying.Move(){
             *                  // Calling from IFlying
             *              }
             *      }
             * 
             * NOTE===> In this case you cannot access the methods of the interfaces directly using the object of the child class as they are explicitely implemented and private by default
             * To do so you need to Create Reference to the Interface and then call the method
             */

            IRoadVechile roadVechile = new FlyingCar();
            roadVechile.Move();



            IAirVehicle airVehicle = new FlyingCar();
            airVehicle.Move();



        }

    }
}
