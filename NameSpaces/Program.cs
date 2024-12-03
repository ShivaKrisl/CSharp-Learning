using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HR;
using FO = FrontOfficers;

using static System.Console;

namespace NameSpaces
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             * NAMESPACES
             * 1. is a collection of classes and other types such as interfaces, structures, enumerations, and delegates.
             * 2. It is used to organize the classes and other types in a logical manner that are meant to be for specific purpose.
             * 3. It helps to avoid name conflicts that can occur when two classes have the same name.
             * 4. It helps to organize the code in a better way.
             * SYNTAX:
             *          namespace NAMESPACE_NAME{
             *              // here you classes, interfaces, structures, enumerations, and delegates
             *          }
             * 5. To access the members of a namespace, you can use the fully qualified name or use the using directive.
             *      a. Fully qualified name: NAMESPACE_NAME.CLASS_NAME
             *      b. Using directive: using NAMESPACE_NAME; in the import section
             * 6. In general it is recommended to use seperate file for each class.
             * 7. Multiple classes/files can share a single namespace.
             */

            // Example 1: Accessing the classes from different namespaces
            HR.Manager manager = new HR.Manager();
           FrontOfficers.CustomerEnquiry customerEnquiry = new FrontOfficers.CustomerEnquiry();


            // Using the using directive
            Executive executive = new Executive();

            /*
             * NESTED NAMESPACES
             * 1. A namespace can have another namespace as its member.
             * 2. It is called nested namespace.
             * 3. This helps to sub group related members into a single namespace in a total namespace.
             * 
             * SYNTAX:
             *          namespace PARENT_NAMESPACE{
             *          
             *                  // Outer namespace members
             *                  namespace CHILD_NAMESPACE{
             *                          // define your sub group members here
             *                  }
             *                  // Outer namespace members
             *          }
             * 4. To access the members of a nested namespace, you can use the fully qualified name or use the using directive.
             *      a. Fully qualified name: PARENT_NAMESPACE.CHILD_NAMESPACE.CLASS_NAME
             *      b. Using directive: using PARENT_NAMESPACE.CHILD_NAMESPACE; in the import section
             */

            /*
             * IMPORTING NAMESPACES
             * 1. The using directive is used to import the namespaces.
             * 2. It is used to avoid writing the fully qualified name of the classes.
             * 3. It must be placed at the top of the file.
             * 4. Inner namespaces are not imported by default when you import the outer namespace.
             * 5. You can import the inner namespace by using "using outerNamespace.innerNamespace;"
             * SYNTAX:
             *      using NAMESPACE_NAME;
             *      now you can use the classes from the namespace without writing the fully qualified name.
             * 
             */

            /*
             * ALIASING NAMESPACES
             * 1. Alias is used to provide a different name to the namespace.
             * 2. It is used when you have two namespaces with the same name.
             * 3. Used to create Shorter name for the lareger nested namespaces.
             * 
             * SYNTAX:
             *      using SHORT_NAME = NAMESPACE_NAME;
             *  4. Access using the SHORT_NAME 
             *  5. Aliasing can be used for the nested namespaces also.
             *  6. Alias name used in one file cannot be used in another file.
             *  
             *  
             *  USECASE:
             *  Say you have two namespaces NamespaceA and NamespaceB. Both have a class with the same name "Manager"
             *  Manager man = new Manager(); // This will give error as it is ambiguous from which namespace to use.
             *  To avoid this you can alias the namespaces and use the alias name to access the class.
             *  using A = NamespaceA;
             *  using B = NamespaceB;
             *  A.Manager manager1 = new A.Manager(); // is a class from NamespaceA
             *  B.Manager manager2 = new B.Manager(); // is a class from NamespaceB
             * 
             */

            // Example 2: Aliasing the namespaces
            FO.CustomerEnquiry customerEnquiry1 = new FO.CustomerEnquiry();
            FO.CustomerEnquiry customerEnquiry2 = new FO.CustomerEnquiry();

            /*
             * USING STATIC DIRECTIVE -- C# 6.0
             * 1. The using static directive is used to import the static class directly so that you can access the static members directly in the entire file.
             * 2. It is used to avoid writing the class name to access the static members.
             * 
             * SYNTAX:
             *      using static NAMESPACE_NAME.STATIC_CLASS_NAME;
             * 
             * EXMAPLE:
             *  Console is a static class which comes under System namespace.
             *  Console class only has static members like WriteLine, ReadLine etc.
             *  That is reason why we dont create an object of Console class to access its members.
             */

            WriteLine("Hello World!");
        }
    }
}
