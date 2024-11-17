using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPS_Methods.Methods.ParameterModifiers
{
    internal class ParamsParameterModifier
    {

        public int Sum(params int[] numbers)
        {
            int sum = 0;
            foreach (int number in numbers)
            {
                sum += number;
            }
            return sum;
        }

        public int ParamsMethod2(out int a, out int b, params int[] numbers)
        {
            a = numbers[0];
            b = numbers[1];
            int sum = 0;
            foreach (int number in numbers)
            {
                sum += number;
            }
            return sum;
        }
        public void Main()
        {
            int sum = Sum(1, 2, 3, 4, 5, 6, 7, 8, 9, 10);
            Console.WriteLine($"Sum of 10 numbers is {sum}");

            int a, b;
            int sum2 = ParamsMethod2(out a, out b, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10);
            Console.WriteLine($"Sum of 10 numbers is {sum2} and a = {a} and b = {b}");

        }
    }
}
