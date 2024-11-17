using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearningCodeLanguage
{
    internal class LoopingDemo
    {
        internal static void WhileLoopDemo()
        {
            // let do simple task checking a number is prime or not
            Console.WriteLine("Enter a number to check Prime or not = ");
            int n = System.Convert.ToInt32(Console.ReadLine());
            int i = 2;
            bool flag = false;
            try
            {
                while (i <= (int)(Math.Sqrt(n)))
                {
                    if (n % 0 == 0)
                    {
                        flag = true;
                        break;
                    }
                    i += 1;
                }

                if (flag)
                {
                    Console.WriteLine("{0} is not a Prime Number", n);
                }
                else
                {
                    Console.WriteLine("{0} is a Prime Number", n);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            
        }

        internal static void DoWhileLoopDemo()
        {
            // let do simple task checking a number is prime or not
            Console.WriteLine("Enter a number to check Prime or not = ");
            int n = System.Convert.ToInt32(Console.ReadLine());
            int i = 2;
            bool flag = false;
            do
            {
                if (n % i == 0)
                {
                    flag = true;
                    break;
                }
                i += 1;
            } while (i <= (int)Math.Sqrt(n));
            if (flag)
            {
                Console.WriteLine("{0} is not a Prime Number",n);
            }
            else
            {
                Console.WriteLine("{0} is a Prime Number",n);
            }
        }

        internal static void ForLoopDemo()
        {
            // let do simple task checking a number is prime or not
            Console.WriteLine("Enter a number to check Prime or not = ");
            int n = System.Convert.ToInt32(Console.ReadLine());
            bool flag = false;
            for (int i = 2; i<= (int)Math.Sqrt(n); i++)
            {
                if (n%i == 0)
                {
                    flag = true;
                    break;
                }
            }
            if (flag)
            {
                Console.WriteLine("{0} is not a Prime Number",n);
            }
            else
            {
                Console.WriteLine("{0} is a Prime Number",n);
            }
        }

        internal static void ForEachLoopDemo()
        {
            int[] arr = {1,2,3,4,5,6,7,8,9,10};
            foreach(int value in arr)
            {
               Console.Write(value+" ");
            }
            Console.WriteLine();
            string name = "Shiva Krishna Beeraboina";
            foreach(char ch in name)
            {

               Console.Write(ch);
            }   
            Console.WriteLine();
        }

        internal static void GotoDemo()
        {
            int repeat = 0;
            Console.WriteLine("USA");
            Console.WriteLine("UK");
            Console.WriteLine("Australia");
            Console.WriteLine("Canada");
            Console.WriteLine("Germany");
            Console.WriteLine("France");
            Console.WriteLine("Japan");
            Console.WriteLine("India");

            ComeHere:
            Console.WriteLine("China");
            Console.WriteLine("Russia");
            Console.WriteLine("South Africa");
            repeat += 1;
            Console.ReadKey();
            // This is backward goto -- leads to infinite loop hence need to specify condition to break
            if (repeat <=5)
                goto ComeHere;
            Console.WriteLine("Brazil");
            Console.WriteLine("Argentina");
            Console.WriteLine("Mexico");
            Console.WriteLine("Spain");
        }

    }
}
