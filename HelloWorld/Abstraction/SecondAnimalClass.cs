using System;
using System.Collections.Generic;
using System.Text;

namespace HelloWorld.Abstraction
{
    abstract class SecondAnimalClass
    {
        // Abstract method(doesn't have a body)
        public abstract void animalSound();

        // Normal method
        public void sleep()
        {
            Console.WriteLine("zzz");
        }
    }
}
