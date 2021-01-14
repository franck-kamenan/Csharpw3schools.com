using System;
using System.Collections.Generic;
using System.Text;

namespace HelloWorld.Constructors
{
    class ConstructorsClass
    {
        static void Main(string[] args)
        {
            SecondCarClass ford = new SecondCarClass();
            Console.WriteLine(ford.model);

            SecondCarClass mercedes = new SecondCarClass("SLK");
            Console.WriteLine(mercedes.model);

            SecondCarClass opel = new SecondCarClass("Astra", "Red");
            Console.WriteLine("it is a " + opel.color + " " + opel.model);
        }
    }
}
