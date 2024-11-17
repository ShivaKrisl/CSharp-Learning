using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPS_Methods.Methods.ParameterModifiers
{
    internal class NotesText
    {
        /*
         * Parameter Modifiers => is applicable to method parameters. It decides how the parameter value is to be passed from the method.And decides whether value changed parameter will change the original value or not.
         * 
         * C# has 5 types of Parameter Modifiers
         * 1. Default
         * 2. Ref
         * 3. Out
         * 4. Params
         * 5. In (C# 7.2)
         * 
         * 1. Default => This is the default parameter modifier. It is used to pass the value of the parameter to the method. It is also called as Value parameter. No specific syntax
         *   eg:
         *   void Get(int a, int b){  // here a and b are called as parameters
         *   }
         *   k = Get(a,b)  => here a and b are called as arguments passed to method.
         *   
         *   In case of default parameter, the value of the parameter is passed to the method. So any changes made to the parameter inside the method will not affect the original value.
         *   
         *   
         * 
         */

        /*
         * 2. ref Parameter => Called as Reference parameter. It is used to pass reference of parameter to the method.
        Value modified inside the method will affect the original value.
        ---> ref is to be used twice. and 
        ---> The argument must be initialized before passing to the method. else it will throw error.
            like: method(ref a = 10) => gives error
            to do so
            int a = 10;
            method(ref a);
            eg:
            void Get(ref int a, ref int b){  // here a and b are called as parameters
                b = 20;
                a = 100;
            }
            a = 1, b=2
            k = Get(ref a,ref b)  => a,b values will be changed to 100,20

         */

        /*
         *  3. Out Parameter => Called as Output parameter. 
                Here the value (argument) from the caller is not initialized to the parameter of method.Instead after method body execution at last parameter will be assigned to a new value which is returned to the caller.
                ie, from value flow from method definition to method caller
                ---> out is to be used twice in method definition and once in method call
                ---> Here the argument need not be initialized before passing to the method.
                ---> but inside method body, the parameter must be initialized before returning the value. else it will throw error.
                ----> It is used to return multiple values from a method.
                Say we want to return 3 values:
                first value is returned by return statement
                second and third values are returned by out parameters.
                eg:
                 void Get(out int a, out int b, int c){  // here a and b are called as parameters
                            a = 100;
                            b = 200;
                            c = a+b;
                            return c;
                   }
                int a,b,c = 100;
                c = Get(out a,out b,c)  => a,b values will be changed to 100,200 and c will be 300
                print(a,b,c) => 100,200,300

         */

        /*
         *  4. In Parameter Modifier => Introduced in C# 7.2
         *    It is used to pass the parameter as read-only.ie, it is used to pass parameter to method but you cannot change its value inside the method else it will throw error.
         *    You need to initialize the argument before passing to the method.
         *    eg:
                 void Get(in int a, in int b, int c){  // here a and b are called as parameters
                            //a = 100;
                            //b = 200;
                            c = a+b;
                            return c;
                   }
                int a = 10,b = 20,c = 100;
                c = Get(in a,in b,c)  => a,b values will be changed to 100,200 and c will be 300
                print(a,b,c) => 10,20,100
         *    
         */

        /*
         * 5. Ref returns => Introduced in C# 7.3
         * is the ability of a method to return the variable as reference.
         * eg:
         * public ref int Get(ref int a){
         *      return ref a;
         *    }
         * int ref a = Get(ref a);
         * a  = 1000;
         * now with this a will be 1000 
         * say we have a class field and method is returning the reference of that field. and we calling that method and storing it to some ref variable. now if we change ref variable value, it will change the class field value as well.
         * ie, without accessing object of class, we can change the field value.
         */

        /*
         * 6. Params => Introduced in C# 1.0
         * It is used to receive all the variables runtime as an array
         * It can be used only once for one method. And if you have multiple args to be passed to method, then params should be the last parameter in the method.
         */
    }
}
