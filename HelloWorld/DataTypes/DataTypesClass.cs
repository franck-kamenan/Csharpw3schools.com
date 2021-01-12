using System;
using System.Collections.Generic;
using System.Text;

namespace HelloWorld.DataTypes
{
    class DataTypesClass
    {

        static void Main(string[] args)
        {

            int myNum = 15;
            long myLongNum = 15000L;
            float myFloatNum = 5.75F;
            float mySecondFloatNum = 35e3F;
            double doubleNum = 5.99D;
            double secondDoubleNum = 12E4D;
            char myLetter = 'D';
            bool myBool = true;
            bool isCSharpFun = true;
            bool isFishTasty = false;
            string myText = "Hello";

            Console.WriteLine(myNum);
            Console.WriteLine(myLongNum);
            Console.WriteLine(myFloatNum);
            Console.WriteLine(mySecondFloatNum);
            Console.WriteLine(doubleNum);
            Console.WriteLine(secondDoubleNum);
            Console.WriteLine(myLetter);
            Console.WriteLine(myBool);
            Console.WriteLine(isCSharpFun);
            Console.WriteLine(isFishTasty);
            Console.WriteLine(myText);

        }

    }
}
