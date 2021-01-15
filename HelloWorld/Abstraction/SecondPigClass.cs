using System;
using System.Collections.Generic;
using System.Text;

namespace HelloWorld.Abstraction
{
    class SecondPigClass: SecondAnimalClass
    {
        // Overriding the abstract method from the abstract class
        public override void animalSound()
        {
            Console.WriteLine("Pig Sound");
        }
    }
}
