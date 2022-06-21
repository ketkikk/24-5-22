using System;

namespace Factorization
{
    class Program
    {
        static void Main(string[] args)
        {
            int i, f = 1, num;

            Console.Write("Calculate the factorial of a given number:  ");
            Console.Write("\n\n");

            Console.Write("Enter any number you want: ");
            num = Convert.ToInt32(Console.ReadLine());
            for (i = 1; i <= num; i++)
            {
                f = f * i;
            }
            Console.Write("The Factorial of {0} is: {1}\n", num, f);
        }
    }
}
