using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLibrary_For_Inheritence_Demo;

namespace OOPS_Inheritence
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             * INHERITANCE
             * 1. Inheritance is a mechanism in which one class acquires the properties and behavior of another class.
             * 2. The class whose properties and behavior are acquired is called the base class or parent class or super class.
             * 3. The class that acquires the properties and behavior is called the derived class or child class or sub class.
             * 4. This allows classes to be arranged in a hierarchy that represents "is-a-type-of" relationships.
             * 5. Child class can access all the members including (fields, methods, properties, constructors) of the parent class even private members. and it can have its own members.
             * 6. Object of child class it has access to all the members of parent class as well as its own class.
             * 7. Object of child class can be assigned to parent class but vice versa is not possible.
             * Example:
             * Employee is a parent class and Manager, Salesman are child classes. Manager and Salesman are also type of Employee.
             * Employee has common properties like Name, Age, Salary, Designation, etc. 
             * Manager has additional properties like Department, Incentive, etc.
             * Salesman has additional properties like Target, Commission, etc.
             * 
             * NOTE: Whenever there exists IS-A relationship among classes then you have to implement Inheritence
             */

            // Create object of Manager class
            Manager manager = new Manager();
            manager.Id = 1;
            manager.Name = "John";
            manager.Age = 30;
            manager.Salary = 50000;
            manager.Department = "IT";
            manager.Incentive = 5000;



            // Create object of Salesman class
            Salesman salesman = new Salesman();
            salesman.Id = 2;
            salesman.Name = "Smith";
            salesman.Age = 25;
            salesman.Salary = 30000;
            salesman.Target = 100000;
            salesman.Commission = 5000;


            /*
             * TYPES OF INHERITENCE
             * 1. SINGLE LEVEL => One Parent Class and One Child Class
             *      eg: Parent = Person and Child = Teacher ie, ever Teacher is a Person
             *      
             * 2. MULTI-LEVEL => Level Wise. ie; Ancestor > child1 > child2 > .....  here Child1 is a parent of Child2
             *      eg: Parent = Person, Child1 = Teacher, Child2 = Professor .. . ie, Every Teacher is a Person and Every Teacher has some designation like Professor, etc
             *      
             * 3. HIERARCHICAL INHERTITENCE => One Parent and Mutiple Single Level Child Classes dependent on them
             *      eg: Parent = Person, Child1 = Teacher, Child2 = Physician, Child3 = Doctor. ie, Every Teacher, Physician, Doctor, is a Person
             *      
             * 4. MULTIPLE INHERITENCE => Multiple Parent Classes but One Child Class extending them. ie, One child can act as both Parents
             *      eg: Parent1 = Doctor, Parent2 = Physician and Child = Physiotherapist. Now, a Physiotherapist can act as both Physician and Doctor at       a time
             *      ** C# doesnt support this => to do so we need to use Interfaces, make parent class as Interfaces
             *  
             *  5. HYBRID INHERITENCE => Combination of any 2 of above types of Inheritence
             *      eg: 
             *      class Parent{
             *      }
             *      class Child1 : Parent{
             *      }
             *      class Child2 : Child1{
             *      }
             *      class Child3 : Child1{
             *      }
             *      Here Parent, Child1, Child2 exhibits Multi-level Inheritence while Child2 and Child3 exhibits Hierarchy to Child1
             *      Thus a combination of Multi-level and Hierarchy.
             */


            /*
             * BASE KEYWORD:
             * 1. is a pre-defined k/w used to refer/call the Parent class members(field, property, methods, constructors,..) in its child class.
             * 2. It's optional to use as by default we can access the Parent class members in its child class directly
             * NOTE: It is must to use "base" when a child class has member name that matches with parent class member ie, naming confliction
             * 
             */

            BaseChild obj = new BaseChild(childId : 10, parentId : 20);
            obj.SetLocation("Hyd");
            obj.Name = "Shiva";
            Console.WriteLine(obj.DisplayDetails());

            BaseChild obj1 = new BaseChild(childId: 100, parentId: 200);
            obj1.SetLocation("Bgr");
            obj1.Name = "ShivaK";
            Console.WriteLine(obj1.DisplayDetails());


            /*
             * PARENT CLASS CONSTRUCTORS
             * 1. Whenever you want to intialize members by creating object to child class using constructor then you need to call Parent class constructor in your child class constructor to initialize Parent Class members.
             * 2. First Parent Class Constructor fields are initialized then Child Class Constructor
             * SYNTAX: 
             *  ChildClass{
             *      ChildClassConstructor(paramsforParent,paramsforchild...) : base(paramsforparent...){
             *          initialize Child class params
             *      }
             *  }
             */

            BaseChild ob2 = new BaseChild(childId: 10, parentId: 20);
            ob2.SetLocation("Hyd");
            ob2.Name = "Shiva";
            Console.WriteLine(ob2.DisplayDetails());

            /*
             * METHOD HIDING => OverWriting the parent Class Method
             * 1. Is a process of hiding Parent class method by creating same method(with same signature) in its child class using new keyword
             * 2. The Parent class method is never called in this case unless you create seperate object for Parent Class
             * SYNTAX:
             * ParentClass{
             *      RetType Method1(params){
             *          code;
             *      }
             * }
             * 
             * ChildClass{
             *     new RetType Method1(params){
             *          code;
             *     }
             * }
             */

            /*
             * METHOD OVERRIDING
             * 1. Is process in which Child class Extends a Parent class method
             * 2. Parent class will have a method and child class will extend that method and add new code to it
             * 3. Here, when child class method is called both these methods gets executed
             * 4. In parent class method you need to use "virtual" modifier & in Child class method you need to use override modifier
             * 5. SYNTAX:
             *      class ParentClass{
             *          ACCESSMODIFIER virtual Type Method(params){
             *              code;
             *          }
             *      }
             *      
             *      class Child : ParentClass{
             *            ACCESSMODIFIER override Type Method(params){
             *            
             *              base.Method(params); // call the Parent class method first
             *              code;
             *          }  
             *      }
             *      
             */

            ChildClass_OverRiding over = new ChildClass_OverRiding();
            over.Id = 10;
            over.Name = "BSK";
            over.Location = "HYD";
            over.Display(over.Id, over.Name, over.Location);

            /*
             * SEALED CLASSES
             * 1. Is a class which is Instantiable but cannot be Inherited
             * 2. The Sealed classes cannot be Inherited, ie we cannot create it as parent class, however it can be Child of different Parent class
             * 3. Sealed Class cannot contain Virtual and Abstract Methods
             * SYNTAX:
             *   sealed class CLASSNAME{
             *   }
             */

            /*
             * SEALED METHODS
             * 1. Is used only in Method overriding, where you want to prevent overriding parent class method in further child classes
             * 2. ie Opposite of Override
             * eg:
             *  class Parent{
             *      virtual method(params){
             *      }
             *  }
             *  
             *  class Child1 : Parent{
             *      sealed  override method(params){
             *          base.method(params)
             *      }
             *  }
             *  
             *  class Child2 : Child1{
             *      here you cannot override the method from class 1 as it was sealed there
             *  }
             */

        }
    }
}
