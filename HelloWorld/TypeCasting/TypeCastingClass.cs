using System;
using System.Collections.Generic;
using System.Text;

namespace HelloWorld.TypeCasting
{
    class TypeCastingClass
    {

        static void Main(string[] args)
        {

            // Implicit Casting
            byte myByte = 9;
            Console.WriteLine(myByte);
            short myShort = myByte;
            Console.WriteLine(myShort);
            int myInt = myShort;
            Console.WriteLine(myInt);
            long myLong = myInt;
            Console.WriteLine(myLong);
            float myFloat = myLong;
            Console.WriteLine(myFloat);
            double myDouble = myFloat;
            Console.WriteLine(myDouble);

            // No Implicit Casting between "decimal" and "double" or "float"
            decimal myDecimal = myLong;
            Console.WriteLine(myDecimal);

            Console.WriteLine();

            // Explicit Casting
            decimal mySecondDecimal = 9.87m;
            Console.WriteLine(mySecondDecimal);
            double mySecondDouble = (double)mySecondDecimal;
            Console.WriteLine(mySecondDouble);
            float mySecondFloat = (float)mySecondDouble;
            Console.WriteLine(mySecondFloat);
            long mySecondLong = (long)mySecondFloat;
            Console.WriteLine(mySecondLong);
            int mySecondInt = (int)mySecondLong;
            Console.WriteLine(mySecondInt);
            short mySecondShort = (short)mySecondInt;
            Console.WriteLine(mySecondShort);
            byte mySecondByte = (byte)mySecondShort;
            Console.WriteLine(mySecondByte);

            Console.WriteLine();

            // Type Conversion Methods
            int myThirdInt = 8;
            Console.WriteLine(myThirdInt);
            Console.WriteLine(Convert.ToDouble(myThirdInt));
            double myThirdDouble = 4.2;
            Console.WriteLine(myThirdDouble);
            Console.WriteLine(Convert.ToInt32(myThirdDouble));

        }

    }
}
