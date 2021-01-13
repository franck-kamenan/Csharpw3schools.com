using System;
using System.Collections.Generic;
using System.Text;

namespace HelloWorld.Methods
{
    class MethodsClass
    {
        static void Main(string[] args)
        {
            MyMethod();
            Console.WriteLine();

            FirstnameMethod("Motumbo");
            FirstnameMethod("Gizenga");
            FirstnameMethod("Anja");
            Console.WriteLine();

            CountryMethod("Congo");
            CountryMethod();
            CountryMethod("Senegal");
            Console.WriteLine();

            MultipleParametersMethod("Motumbo", 5);
            MultipleParametersMethod("Gizenga", 18);
            MultipleParametersMethod("Anja", 31);
            Console.WriteLine();

            Console.WriteLine(ReturnMethod(3));
            Console.WriteLine(ReturnMultipleParametersMethod(4, 8));
            int z = ReturnMultipleParametersMethod(5, 10);
            Console.WriteLine(z);
            Console.WriteLine();

            NamedArgumentsMethod(child2Parameter: "Deus", child3Parameter: "Trinity", child1Parameter: "Wan");
            NamedArgumentsWithDefaultValuesMethod("child3Parameter");
            Console.WriteLine();

            Console.WriteLine(PlusMethod(8, 5));
            Console.WriteLine(PlusMethod(4.3, 6.27));
        }

        public static void MyMethod()
        {
            Console.WriteLine("I just got executed!");
        }

        // Parameters and Arguments
        public static void FirstnameMethod(string firstnameParameter)
        {
            Console.WriteLine(firstnameParameter + " Refnes");
        }

        // Default Parameter Value or Optional Parameter
        public static void CountryMethod(string countryParameter = "Norway")
        {
            Console.WriteLine(countryParameter);
        }

        // Multiple Parameters
        public static void MultipleParametersMethod(string firstnameParameter, int ageParameter)
        {
            Console.WriteLine(firstnameParameter + " is " + ageParameter);
        }

        // Return Values
        public static int ReturnMethod(int xParameter)
        {
            return 5 + xParameter;
        }

        public static int ReturnMultipleParametersMethod(int xParameter, int yParameter)
        {
            return xParameter + yParameter;
        }

        // Named Arguments
        public static void NamedArgumentsMethod(string child1Parameter, string child2Parameter, string child3Parameter)
        {
            Console.WriteLine("The youngest child is " + child3Parameter);
        }

        public static void NamedArgumentsWithDefaultValuesMethod(string child2Parameter = "Deus", string child3Parameter = "Trinity", string child1Parameter = "Wan")
        {
            Console.WriteLine(child3Parameter);
        }

        // Method Overloading
        public static int PlusMethod(int x, int y)
        {
            return x + y;
        }

        public static double PlusMethod(double x, double y)
        {
            return x + y;
        }
    }
}
