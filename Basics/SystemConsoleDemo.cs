using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearningCodeLanguage
{
    internal class SystemConsoleDemo
    {
        internal static void ConsoleMethods()
        {
            //Print messages line-by-line
            System.Console.WriteLine("Welcome");
            System.Console.WriteLine("to");
            System.Console.WriteLine("C# Programming");

            //Print messages side-by-side
            System.Console.Write("Welcome ");
            System.Console.Write("to ");
            System.Console.Write("C# Programming");

            //Wait for pressing some key on the keyboard
            System.Console.ReadKey();

            //clear the screen
            System.Console.Clear();

            System.Console.WriteLine("Thank you.");
        }
    }
}
