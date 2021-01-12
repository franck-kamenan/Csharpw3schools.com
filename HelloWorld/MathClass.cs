using System;
using System.Collections.Generic;
using System.Text;

namespace HelloWorld
{
    class MathClass
    {

        static void Main(string[] args)
        {

            int x = 10;
            int y = 5;
            int nintendo = 64;
            double negative = -4.7;
            double virgule = 9.99;
            Console.WriteLine(Math.Max(x, y));
            Console.WriteLine(Math.Min(x, y));
            Console.WriteLine(Math.Sqrt(nintendo));
            Console.WriteLine(Math.Abs(negative));
            Console.WriteLine(Math.Round(virgule));

        }

    }
}
