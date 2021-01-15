using System;
using System.Collections.Generic;
using System.Text;

namespace HelloWorld.Abstraction
{
    class AbstractionClass
    {
        static void Main(string[] args)
        {
            SecondPigClass myPig = new SecondPigClass();
            myPig.animalSound();
            myPig.sleep();
        }
    }
}
