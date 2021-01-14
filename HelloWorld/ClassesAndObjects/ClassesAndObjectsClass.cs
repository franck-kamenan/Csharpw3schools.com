using System;
using System.Collections.Generic;
using System.Text;

namespace HelloWorld.ClassesAndObjects
{
    class ClassesAndObjectsClass
    {
        static void Main(string[] args)
        {
            Car carObject = new Car();
            carObject.fullThrottle();
            carObject.secondColor = "blue";
            carObject.minSpeed = 30;
            Console.WriteLine(carObject.color);
            Console.WriteLine(carObject.maxSpeed);
            Console.WriteLine(carObject.secondColor);
            Console.WriteLine(carObject.minSpeed);
            Console.WriteLine();

            Car Ford = new Car();
            Ford.model = "Mustang";
            Ford.color = "black";
            Ford.year = 1969;
            Console.WriteLine(Ford.model);
            Console.WriteLine(Ford.color);
            Console.WriteLine(Ford.year);
        }
    }
}
