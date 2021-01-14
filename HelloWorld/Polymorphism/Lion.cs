using System;
using System.Collections.Generic;
using System.Text;

namespace HelloWorld.Polymorphism
{
    class Lion: Cat
    {
        public override void animalSound()
        {
            Console.WriteLine("Lion Sound");
        }
    }
}
