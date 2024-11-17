using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearningCodeLanguage
{
    internal class OperatorsAssignment
    {
        internal static void CalculateAreaOfCircle()
        {
            Console.Write("Enter Radius Value = ");
            double radius = System.Convert.ToDouble(Console.ReadLine());
            double area = Math.PI * radius * radius;
            Console.WriteLine("PI Value: {0}", Math.PI);
            Console.WriteLine("Area of circle with radius {0} is {1}", radius, area);
        }

        internal static void FeetToCentimeterConverter()
        {
            Console.Write("Enter Feet Value = ");
            double feet = System.Convert.ToDouble(Console.ReadLine());
            double centimeter = feet * 30.48;
            Console.WriteLine("{0} feet is equal to {1} centimeters", feet, centimeter);
        }

        internal static void MoneyRoundOffValue()
        {
            Console.Write("\r\n Instructions\r\nIf the number's last three digits are greater than or equal to 500; it should \"round up\" the number.\r\n\r\nIf the number's last three digits are less than 500; it should \"round down\" the number.\r\n\r\nIf the number is less than 500; it should round up to 1000. \n");

            Console.Write("Enter Money Value = ");
            int money = System.Convert.ToInt32(Console.ReadLine());
            
            int lastThreeDigits = money % 1000;
            int result = 0;
            result = lastThreeDigits < 500 ? 1000 : lastThreeDigits >=500 ? 1000 - lastThreeDigits + money :1000 - lastThreeDigits - money;
            

            Console.WriteLine("Rounded Money Value: {0}", result);
        }

        internal static void SecondsConverter()
        {
            Console.Write("Enter Seconds Value = ");
            int seconds = System.Convert.ToInt32(Console.ReadLine());
            int days = seconds / 86400;
            int hours = seconds / 3600;
            int minutes = (seconds % 3600) / 60;
            int remainingSeconds = seconds % 60;
            Console.WriteLine("{0} seconds is equal to {1} days, {2} hours, {3} minutes and {4} seconds", seconds, days, hours, minutes, remainingSeconds);
        }
    }
}
