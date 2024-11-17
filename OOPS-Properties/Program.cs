using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPS_Properties
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             * Property => is a composite member of class which contains two accessors (Set and Get)
             * ---> It recieves the incoming value, validates the value then assign it to the field 
             * ---> If validation fails it will not assign the value it will skip the value 
             * ---> Whenever user supplies a value to a property it is first validated the assigned to field.
             * Thus, property provides secure layer for fields
             * ---> A property requires "private field" by default with name like "_FieldName"
             * **private field because if we use public field it can be accessible outside class without accessing the property resulting in miss assigning value
             * 
             * ADV: 
             * 1. Act as protection layer before storing value to field
             * 2. No memory is allocated for property & method
             * 3. It is recommended to create property to all fields of class
             * 
             */
            /*
             * Accessors of Properties: Get and Set
             * 
             * Set =>  used to assign value to field. At time of compilation it is converted to as set method. The "value" var provided is by default and its value is the value supplied by user
             * --> has only one parameter called value
             * --> should not return any value
             * 
             * Get => used to access field value. Since, we cannot access private field we need to use get accessor
             * --> should not have any parameters
             * --> should return the field value
             * 
             * SYNTAX:
             * 1. First declare a private field
             *  eg: private string _carBrand;
             * 2. Create a  property for it with name same as field name but recommended to use Pascal Names in field and properties
             * eg:  <AccessModifier> <Modifier> string CarBrand{
             *          
             *      }
             * 3. Inside it write Set and Get Accessors
             * eg:  public string CarBrand{
             *          set{
             *              // custom validation logic
             *              // init
             *              this._carBrand = value;
             *          }
             *          get{
             *              // validaton or some logic
             *              // return value
             *              
             *          }
             *      }
             * ---> It is possible that we can use different Access Modifiers for set and get fields. say like internal for property name, private for set.
             * **NOTE: You can set access modifiers either for Set or Get but not both at a time. Except when property has public access modifier in that you can set public for both Set and Get
             * ---> But, access modifier of set should be more restrictive than others
             *  ** While accessing or inserting, use the property name not field name
             */

            Employee emp = new Employee(1, "Shiva", "Microsoft");


            Console.WriteLine(emp.ToString()); // Id validation failed so default 0 is assigned

            /*
             * If you want to access the value, and perform operations you can use get accessor only -- read only property
             * Write only property is used to assign value to field but not to read the value
             */


            /*
             * AUTO - IMPLEMENTED PROPERTIES
             * 1. are properties with no defination for set and get accessors
             * 2. are used when there is no custom validation or logic to be implemented
             * 3. are used to create property easily (with shorter syntax)
             * 4. creates a private field (with name as _propertyName) automatically while compilation time
             * 5. Auto Implemented properties can be ReadOnly but it can't be WriteOnly
             * 6. Here the developer don't need to create private field compiler will create it automatically with _. However you can set access Modifiers for get and set accessors seperately
             */

            /*
             * AUTO INITIALIZATION OF PROPERTIES
             * 1. is a new feature of C# 6.0
             * 2. used to initialize the properties with default values
             * SYNTAX: accessmodifier modifier dtype propertyName {get; set;} = value;
             * 
             */

            AutoProperties obj = new AutoProperties();
            obj.empId = 1;
            obj.empName = "Shiva";
            obj.jobTitle = "SWE";
            obj.salary = 100000;
            obj.DisplayEmployeeDetails();
        }
    }
}
