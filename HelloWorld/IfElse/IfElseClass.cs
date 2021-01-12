using System;
using System.Collections.Generic;
using System.Text;

namespace HelloWorld.IfElse
{
    class IfElseClass
    {

        static void Main(string[] args)
        {

            int time = 9;
            if (time < 10)
            {

                Console.WriteLine("Good morning.");

            }
            else if (time < 20)
            {

                Console.WriteLine("Good day.");

            }
            else
            {

                Console.WriteLine("Good evening.");

            }

                Console.WriteLine();

            // Ternary Operator
                Console.WriteLine((time < 18)? "Good day.": "Good evening.");
        
        }

    }
}
