using System;
using System.Collections.Generic;
using System.Text;

namespace HelloWorld.ForLoop
{
    class ForLoopClass
    {
        static void Main(string[] args)
        {
            for(int i = 0; i < 5; i++)
            {
                Console.WriteLine(i);
            }

                Console.WriteLine();

            // For Each Loop, exclusively for arrays
            string[] cars = { "Volvo", "BMW", "Mazda" };
            foreach(string i in cars)
            {
                Console.WriteLine(i);
            }
        }
    }
}
