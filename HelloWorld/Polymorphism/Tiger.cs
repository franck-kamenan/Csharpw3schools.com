using System;
using System.Collections.Generic;
using System.Text;

namespace HelloWorld.Polymorphism
{
    class Tiger: Cat
    {
        public override void animalSound()
        {
            Console.WriteLine("Tiger Sound");
        }
    }
}
