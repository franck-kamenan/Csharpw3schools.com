using System;
using System.Collections.Generic;
using System.Text;

namespace HelloWorld.UserInput
{
    class UserInputClass
    {

        static void Main(string[] args)
        {

            Console.WriteLine("Enter your username:");
            string username = Console.ReadLine();
            Console.WriteLine("Your username is: " + username);

            Console.WriteLine();

            Console.WriteLine("Enter your age:");
            int age = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Your age is: " + age);

        }

    }
}
