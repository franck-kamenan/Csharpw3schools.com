using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace HelloWorld.Arrays
{
    class ArraysClass
    {
        static void Main(string[] args)
        {
            // 4 ways to create an array
            string[] boats = new string[3];
            string[] bikes = new string[3] { "Yamaha", "BMW", "Harley" };
            string[] automobiles = new string[3] { "Volvo", "BMW", "Mazda" };
            string[] cars = { "Volvo", "BMW", "Mazda" };    
            
            Console.WriteLine(cars[0]);
            cars[0] = "WW";
            Console.WriteLine(cars[0]);            
            Console.WriteLine(cars.Length);   
            
            Console.WriteLine();            

            // For Loop
            for(int i = 0; i < cars.Length; i++)
            {
                Console.WriteLine(cars[i]);       
            }

            Console.WriteLine();

            // Foreach Loop
            foreach (string i in cars)
            {
                Console.WriteLine(i);
            }

            Console.WriteLine();

            // Sort Arrays
            Array.Sort(cars);
            foreach (string i in cars)
            {
                Console.WriteLine(i);
            }

            int[] numbers = { 5, 1, 9, 7 };
            Array.Sort(numbers);
            foreach (int i in numbers)
            {
                Console.WriteLine(i);
            }

            Console.WriteLine();

            // System Linq
            Console.WriteLine(numbers.Max());
            Console.WriteLine(numbers.Min());
            Console.WriteLine(numbers.Sum());
        }
    }
}
