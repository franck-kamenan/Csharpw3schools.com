using System;
using System.Collections.Generic;
using System.Text;

namespace HelloWorld.Exceptions
{
    class ExceptionsClass
    {
        static void Main(string[] args)
        {
            try
            {
                int[] myNumbers = { 1, 2, 3 };
                Console.WriteLine(myNumbers[10]);
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }

            // Write your own error message
            try
            {
                int[] myNumbers = { 1, 2, 3 };
                Console.WriteLine(myNumbers[10]);
            }
            catch (Exception e)
            {
                Console.WriteLine("Something went wrong.");
            }

            // Finally Statement
            try
            {
                int[] myNumbers = { 1, 2, 3 };
                Console.WriteLine(myNumbers[10]);
            }
            catch (Exception e)
            {
                Console.WriteLine("It is all wrong.");
            }
            finally
            {
                Console.WriteLine("The 'try catch' is finished.");
            }

            checkAge(20);
        }

        // Throw Statement
        public static void checkAge(int age)
        {
            if(age < 18)
            {
                throw new ArithmeticException("Access denied.");
            }
            else
            {
                Console.WriteLine("Access granted.");
            }
        }
    }
}
