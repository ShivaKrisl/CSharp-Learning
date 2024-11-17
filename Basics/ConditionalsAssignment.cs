using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Channels;
using System.Text;
using System.Threading.Tasks;

namespace LearningCodeLanguage
{
    internal class ConditionalsAssignment
    {
        internal static void HeightCategory()
        {
            Console.WriteLine("Enter your height in Inches: ");
            double inch = System.Convert.ToDouble(Console.ReadLine());
            double cm = inch * 2.54;
            string category = "";
            if (cm >= 195)
            {
                category = "Abnormal height";
            }
            else if (cm >= 165 && cm < 195)
            {
                category = "Tall";
            }
            else if (cm >=150 && cm < 165)
            {
                category = "Average Height";
            }
            else
            {
                category = "Dwarf";
            }
            Console.WriteLine("Your height in centimeters is: " + cm);
            Console.WriteLine("You are in the category of: " + category);
        }

        internal static void LargestOfThreeNumbers()
        {
            int a, b, c;
            Console.WriteLine("Enter three space seperated numbers: ");
            string input = Console.ReadLine();
            string[] inputs = input.Split(' ');
            a = System.Convert.ToInt32(inputs[0]);
            b = System.Convert.ToInt32(inputs[1]);
            c = System.Convert.ToInt32(inputs[2]);
            if (a > b)
            {
                if (a > c)
                {
                    Console.WriteLine("{0} is the largest", a);
                }
                else
                {
                    Console.WriteLine("{0} is the largest", c);
                }
            }
            else
            {
                if (b > c)
                {
                    Console.WriteLine("{0} is the largest", b);
                }
                else
                {
                    Console.WriteLine("{0} is the largest", c);
                }
            }
        }

        internal static void MarksFinder()
        {
            Console.WriteLine("Enter your Grade = ");
            char grade = System.Convert.ToChar(Console.ReadLine());
            grade = char.ToUpper(grade);
            switch (grade)
            {
                case 'O':
                    Console.WriteLine("Marks >= 90");
                    break;
                case 'A':
                    Console.WriteLine("Marks >= 80 and < 90");
                    break;
                case 'B':
                    Console.WriteLine("Marks >= 70 and < 80");
                    break;
                case 'C':
                    Console.WriteLine("Marks >= 60 and < 70");
                    break;
                case 'D':
                    Console.WriteLine("Marks >= 50 and < 60");
                    break;
                case 'E':
                    Console.WriteLine("Marks >35 and < 50");
                    break;
                case 'F':
                    Console.WriteLine("Marks <= 35");
                    break;
                default:
                    Console.WriteLine("Invalid Grade");
                    break;      
            }

        }
    }
}