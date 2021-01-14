using System;
using System.Collections.Generic;
using System.Text;

namespace HelloWorld.Polymorphism
{
    class PolymorphismClass
    {
        static void Main(string[] args)
        {
            // with Polymorphism
            Animal myAnimal = new Animal();
            Animal myPig = new Pig();
            Animal myDog = new Dog();
            myAnimal.animalSound();
            myPig.animalSound();
            myDog.animalSound();
            Console.WriteLine();

            // without Polymorphism
            Animal mySecondAnimal = new Animal();
            Pig mySecondPig = new Pig();
            Dog mySecondDog = new Dog();
            mySecondAnimal.animalSound();
            mySecondPig.animalSound();
            mySecondDog.animalSound();
            Console.WriteLine();

            // Polymorphism with Virtual and Override
            Cat myCat = new Cat();
            Cat myLion = new Lion();
            Cat myTiger = new Tiger();
            myCat.animalSound();
            myLion.animalSound();
            myTiger.animalSound();
        }
    }
}
