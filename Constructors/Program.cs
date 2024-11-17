using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constructors
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             * Constructor => Special method of class, which contains initialization logic of fields.
             * ---> Constructor initializes the fields and can also contains the additional initialization logic (if any).
             *  SYNTAX => 
             *      <ACCESS MODIFIER> <MODIFIER> ClassName (Params){
             *              // Initi logic
             *      }
             *      Access Modifiers => same as for fields and methods  -- default is private
             *      * public
             *      * private
             *      * protected
             *      * internal
             *      * private protected
             *      * protected internal
             *      
             *      Modifiers => Can be Only Static (optional)
             * RULES-----
             * 1. Constructor name should be same as class name
             * 2. It is recommended to use public or internal as access modifier for constructor.if it is a "private member", it can be called within the same class only; so you can create object of a class only inside the same class; but not outside the class.
             * 3. Constructor can have one or more parameters.
             * 4. Constructor have no return type
             * 5. A class can have one or more constructors; but all the constructors of the class must have different types of parameters. -- Overloading
             */

            Employee emp1 = new Employee();
            Employee emp2 = new Employee();

            Console.WriteLine("Calling with default Constructor --");
            Console.WriteLine("Employee One Details = ");
            Console.WriteLine(emp1.ToString());
            Console.WriteLine("Employee Two Details = ");
            Console.WriteLine(emp2.ToString());

            emp1 = new Employee(id: 1, name: "Shiva", jobTitle:"SWE");
            emp2 = new Employee(id: 2, name: "Keer", jobTitle: "SA");

            Console.WriteLine("Calling Parametarized Constructor -- ");
            Console.WriteLine("Employee One Details = ");
            Console.WriteLine(emp1.ToString());
            Console.WriteLine("Employee Two Details = ");
            Console.WriteLine(emp2.ToString());

            /*
             * Instance Constructor v/s Static Constructor
             * 1. Instance Constructor => Initializes both instance fields and static fields of a class
             * --> SYNTAX: <AccessModifier> ClassName (parameters){
             *                  // init logic
             *              }
             * --> Executes everytime when an object is created
             * --> Default Access Modifier is Private and you can change it
             * --> You can write any init logic as it can be executed on every obj creation
             * 2. Static Constructor => Initializes Static fields of a class
             * --> SYNTAX: public static ClassName (){
             *                  // Init logic for Static Fields
             *              }
             * --> Executes only once when class is accessed for first time
             * --> Defualt Access Modifier is Public and it cannot be changed
             * --> Should contain Initialization Logic that executes only once (when class is accessed for first time)
             * --> It should be ParameterLess
             * --> Cannot use this keyword
             * --> Static Fields can only be accessed using Class Name
             */
            Console.WriteLine();
            Console.WriteLine($"Company Name of both Employees = {Employee.CompanyName}");
            Console.WriteLine("Employee One Details = ");
            Console.WriteLine(emp1.ToString());
            Console.WriteLine("Employee Two Details = ");
            Console.WriteLine(emp2.ToString());

            /*
             * Types 
             * 1. Parameterized => Constructor having one or more Params passed as argument
             * 2. Parameterless => Constructors not any having Params passed as argument
             * 
             * 1. Implicit Constructor => When a class has no constructor defined the by default C# provides empty/parameterless Constructor called as Default Constructor. Here Class should not have any Constructor (ZERO)   
             * 2. Explicit Constructor =>   Constructor is created by developer.
             */

            /*
             * Constructor OverLoading => Multiple Constructors having different parameters
             * It is always recommended to write Parameterless constructor first
             */
            Employee emp3 = new Employee(id:1); // Constructor 2
            Employee emp4 = new Employee(id: 2, "Shiva"); // Constructor 3
            Employee emp5 = new Employee(id: 3, "shiva", "SWE"); // Constructor 4

            /*
             * Object Initializer => used when some fields are not intialized in constructor and we want to initalize while creating object
             * Syntax : 
             *      new ClassName(params){
             *          field = value,
             *          field = value..
             *      }
             *   
             */
            Employee emp = new Employee(10)
            {
                Name =  "Shiva",
                JobTitle = "Software"
            };
            Console.WriteLine(emp.ToString());
        }
    }
}
