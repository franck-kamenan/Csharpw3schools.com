using System;
using System.Collections.Generic;
using System.Text;

namespace HelloWorld.Variables
{
    class VariablesClass
    {

        static void Main(string[] args)
        {

            string name = "John";
            Console.WriteLine(name);
            Console.WriteLine("Hello " + name);

            string lastname = " Doe";
            string fullname = name + lastname;
            Console.WriteLine(fullname);

            int myNum = 15;
            Console.WriteLine(myNum);

            int mySecondNum;
            mySecondNum = 16;
            Console.WriteLine(mySecondNum);

            int myThirdNum = 17;
            Console.WriteLine(myThirdNum);
            myThirdNum = 18;
            Console.WriteLine(myThirdNum);

            int x = 5;
            int y = 6;
            Console.WriteLine(x + y);

            int a = 7;
            int b = 8;
            int c = 9;
            Console.WriteLine(a + b + c);

            const int constNum = 19;
            Console.WriteLine(constNum);

            double doubleNum = 5.99D;
            Console.WriteLine(doubleNum);

            char myLetter = 'D';
            Console.WriteLine(myLetter);

            bool myBool = true;
            Console.WriteLine(myBool);

            string myText = "Hello";
            Console.WriteLine(myText);

        }
    }
}
