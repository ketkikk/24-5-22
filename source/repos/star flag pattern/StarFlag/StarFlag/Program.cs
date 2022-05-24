using System;

namespace StarFlag
{
    class Program
    {
        int row = 10;
        int col = 5;
        static void Main(string[] args)
        {
            for (int i = 10; i >= 0; i--)
            {
                for (int j = 1; j <= 5; j++)
                    Console.Write(j.ToString());
                Console.WriteLine("*");
            }
            for (int i=1; i<=10; i++)
            {
                for (int j = 1; j <= 10; j++)
                    Console.Write(j.ToString());
                Console.WriteLine(" ");

            }
            Console.WriteLine();
        }
    }
}
