using System;
using System.Collections.Generic;
using System.Text;

namespace HelloWorld.PropertiesAndEncapsulation
{
    class PropertiesAndEncapsulationClass
    {
        static void Main(string[] args)
        {
            Person somebody = new Person();
            somebody.Name = "John";
            somebody.Age = 36;
            Console.WriteLine(somebody.Name);
            Console.WriteLine(somebody.Age);
        }
    }
}
