using System;
using System.Collections.Generic;
using System.Text;

namespace HelloWorld.Interface
{
    class ThirdPigClass: IAnimalInterface, IFirstInterface, ISecondInterface
    {
        // Overriding the interface method from the interface isn't necessary
        public void animalSound()
        {
            Console.WriteLine("Pig Sound");
        }

        // Overriding the interface method from the interface isn't necessary
        public void myMethod()
        {
            Console.WriteLine("My Method");
        }

        // Overriding the interface method from the interface isn't necessary
        public void myOtherMethod()
        {
            Console.WriteLine("My Other Method");
        }
    }
}
