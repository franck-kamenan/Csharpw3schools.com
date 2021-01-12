using System;
using System.Collections.Generic;
using System.Text;

namespace HelloWorld.Operators
{
    class OperatorsClass
    {

        static void Main(string[] args)
        {

            // Arithmetic Operators
            int a = 40;
            Console.WriteLine(a);
            int b = 20;
            Console.WriteLine(b);
            int c = 30;
            Console.WriteLine(c);
            int sum = a + b;
            Console.WriteLine(sum);
            int sub = a - b;
            Console.WriteLine(sub);
            int mul = a * b;
            Console.WriteLine(mul);
            int div = a / b;
            Console.WriteLine(div);
            int mod = c % b;
            Console.WriteLine(mod);
            Console.WriteLine(++a);
            Console.WriteLine(a++);
            Console.WriteLine(a);
            Console.WriteLine(--b);
            Console.WriteLine(b--);
            Console.WriteLine(b);

            Console.WriteLine();

            // Assignement Operators
            int x = 10;
            Console.WriteLine(x);
            int y = 5;
            Console.WriteLine(y);
            int z = 7;
            Console.WriteLine(x += y);
            Console.WriteLine(x -= y);
            Console.WriteLine(x *= y);
            Console.WriteLine(x /= y);
            Console.WriteLine(x %= z);

            Console.WriteLine();

            // Comparison Operators
            int giant = 8;
            int titan = 9;
            Console.WriteLine(giant == titan);
            Console.WriteLine(giant != titan);
            Console.WriteLine(giant < titan);
            Console.WriteLine(giant > titan);
            Console.WriteLine(giant <= titan);
            Console.WriteLine(giant >= titan);

            Console.WriteLine();

            // Logical Operators
            bool and = giant < titan && titan > giant;
            Console.WriteLine(and);
            bool not = !(giant < titan && titan > giant);
            Console.WriteLine(not);
            bool or = giant < titan || titan < giant;
            Console.WriteLine(or);

        }

    }
}
