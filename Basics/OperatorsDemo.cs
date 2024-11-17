using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearningCodeLanguage
{
    internal class OperatorsDemo
    {
        internal static void ArithmeticOperatorsDemo()
        {
            int a = 10;
            int b = 20;
            int c = a + b;
            Console.WriteLine("Addition of a and b = " + c);
            c = a - b;
            Console.WriteLine("Subtraction of a and b = " + c);
            c = a * b;
            Console.WriteLine("Multiplication of a and b = " + c);
            c = a / b;
            Console.WriteLine("Division of a and b = " + c);
            c = a % b;
            Console.WriteLine("Modulus of a and b = " + c);
            Console.ReadKey();
            RelationalOperatorsDemo();
        }

        internal static void RelationalOperatorsDemo()
        {
            int a = 10;
            int b = 20;
            Console.WriteLine("a is equal to b = " + (a == b));
            Console.WriteLine("a is not equal to b = " + (a != b));
            Console.WriteLine("a is greater than b = " + (a > b));
            Console.WriteLine("a is less than b = " + (a < b));
            Console.WriteLine("a is greater than or equal to b = " + (a >= b));
            Console.WriteLine("a is less than or equal to b = " + (a <= b));
            Console.ReadKey();
            LogicalOperatorsDemo();
        }

        internal static void LogicalOperatorsDemo()
        {
            int a = 10;
            int b = 20;
            Console.WriteLine("a is equal to b = " + (a == b));
            Console.WriteLine("a is not equal to b = " + (a != b));
            Console.WriteLine("a is greater than b = " + (a > b));
            Console.WriteLine("a is less than b = " + (a < b));
            Console.WriteLine("a is greater than or equal to b = " + (a >= b));
            Console.WriteLine("a is less than or equal to b = " + (a <= b));
            Console.ReadKey();
            BitwiseOperatorsDemo();
        }

        internal static void BitwiseOperatorsDemo()
        {
            int a = 10;
            int b = 20;
            Console.WriteLine("a & b = " + (a & b));
            Console.WriteLine("a | b = " + (a | b));
            Console.WriteLine("a ^ b = " + (a ^ b));
            Console.WriteLine("~a = " + ~a);
            Console.ReadKey();
            AssignmentOperatorsDemo();
        }

        internal static void AssignmentOperatorsDemo()
        {
            int a = 10;
            int b = 20;
            Console.WriteLine("a = b = " + (a = b));
            Console.WriteLine("a += b = " + (a += b));
            Console.WriteLine("a -= b = " + (a -= b));
            Console.WriteLine("a *= b = " + (a *= b));
            Console.WriteLine("a /= b = " + (a /= b));
            Console.WriteLine("a %= b = " + (a %= b));
            Console.WriteLine("a &= b = " + (a &= b));
            Console.WriteLine("a |= b = " + (a |= b));
            Console.WriteLine("a ^= b = " + (a ^= b));
            Console.WriteLine("a >>= b = " + (a >>= b));
            Console.WriteLine("a <<= b = " + (a <<= b));
            Console.ReadKey();
            TernanryOperatorsDemo();
        }

        internal static void TernanryOperatorsDemo()
        {
            int a = 10;
            int b = 20;

            string result = a > b ? "a is greater than b" : "a is less than or equal to b";
            Console.WriteLine(result);
            Console.ReadKey();
            UnaryOperatorsDemo();
        }

        internal static void UnaryOperatorsDemo()
        {
            int a = 10;
            int b = 20;
            Console.WriteLine("a++ = " + (a++));
            Console.WriteLine("b-- = " + (b--));
            Console.WriteLine("++a = " + (++a));
            Console.WriteLine("--b = " + (--b));
            Console.ReadKey();
            ConcatinationDemo();
        }

        internal static void ConcatinationDemo()
        {
            string name = "Shiva Krishna Beeraboina";
            int age = 22;
            string message = "Hey " + name + ", your age is " + age + ".";
            System.Console.WriteLine(message);
        }
    }
}
