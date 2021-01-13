using System;
using System.Collections.Generic;
using System.Text;

namespace HelloWorld.WhileLoop
{
    class WhileLoopClass
    {
        static void Main(string[] args)
        {
            int i = 0;
            while(i < 5)
            {
                Console.WriteLine(i);
                i++;
            }

                Console.WriteLine();

            int j = 0;
            do
            {
                Console.WriteLine(j);
                j++;
            }
            while (j < 5);
        }
    }
}
