using System;
using System.Collections.Generic;
using System.Text;

namespace HelloWorld.Strings
{
    class StringsClass
    {

        static void Main(string[] args)
        {

            Console.Write("Hello ");
            string greeting = "World";            
            Console.WriteLine(greeting);

            Console.WriteLine();

            // String Methods
            Console.WriteLine("The length of the greeting string is: " + greeting.Length);
            Console.WriteLine(greeting.ToUpper());
            Console.WriteLine(greeting.ToLower());

            Console.WriteLine();

            // String Concatenation
            string how = "evil ";
            string what = how + greeting;
            string who = string.Concat(how, greeting);
            Console.WriteLine(what);
            Console.WriteLine(who);

            Console.WriteLine();

            // String Interpolation
            string firstname = "John";
            string lastname = "Doe";
            string fullname = $"My full name is: {firstname} {lastname}";
            Console.WriteLine(fullname);

            Console.WriteLine();

            // Access Strings and Other Methods
            Console.WriteLine(firstname[0]);
            Console.WriteLine(firstname[3]);
            Console.WriteLine(firstname.IndexOf("o"));
            Console.WriteLine(fullname.Substring(17));

            // New Line
            Console.Write("\n");

            // Adding Numbers and Strings
            int x = 10;
            int y = 20;
            Console.WriteLine(x + y);
            string a = "10";
            string b = "20";
            Console.WriteLine(a + b);

        }

    }
}
