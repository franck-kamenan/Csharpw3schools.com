using System;
using System.Collections.Generic;
using System.Text;

namespace HelloWorld.ClassesAndObjects
{
    class Car
    {
        public string color = "red";
        public int maxSpeed = 200;
        public string secondColor;
        public int minSpeed;
        public string model;
        public int year;

        public void fullThrottle()
        {
            Console.WriteLine("The car is going as fast as it can!");
        }
    }
}
