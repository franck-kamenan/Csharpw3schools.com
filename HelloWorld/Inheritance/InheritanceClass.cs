using System;
using System.Collections.Generic;
using System.Text;

namespace HelloWorld.Inheritance
{
    class InheritanceClass
    {
        static void Main(string[] args)
        {
            Bike moto = new Bike();
            moto.honk();
            Console.WriteLine(moto.brand + " " + moto.type);
        }
    }
}
