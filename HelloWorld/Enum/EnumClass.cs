using System;
using System.Collections.Generic;
using System.Text;

namespace HelloWorld.Enum
{
    class EnumClass
    {
        // Enum inside a class
        enum Niveau
        {
            Low,
            Medium,
            High
        }

        // Enum Values
        enum Months
        {
                JAN,
                FEB,
                MAR,
                APR,
                MAY,
                JUN
        }

        // Assigned Enum Values
        enum AssignedMonths
        {
            JAN = 6,
            FEB = 3,
            MAR = 1,
            APR = 2,
            MAY = 4,
            JUN = 5
        }

        static void Main(string[] args)
        {
            Level myLevel = Level.Medium;
            Console.WriteLine(myLevel);

            Niveau monNiveau = Niveau.High;
            Console.WriteLine(monNiveau);

            int myNum = (int)Months.APR;
            Console.WriteLine(myNum);

            int monNr = (int)AssignedMonths.APR;
            Console.WriteLine(monNr);

            // Enum in a Switch Statement
            switch(myLevel)
            {
                case Level.Low:
                    Console.WriteLine("Low Level");
                    break;
                case Level.Medium:
                    Console.WriteLine("Medium Level");
                    break;
                case Level.High:
                    Console.WriteLine("High Level");
                    break;
            }
        }
    }
}
