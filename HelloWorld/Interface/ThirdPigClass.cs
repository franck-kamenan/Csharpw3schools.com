using System;
using System.Collections.Generic;
using System.Text;

namespace HelloWorld.Interface
{
    class ThirdPigClass: IAnimalInterface
    {
        // Overriding the interface method from the interface isn't necessary
        public void animalSound()
        {
            Console.WriteLine("Pig Sound");
        }
    }
}
