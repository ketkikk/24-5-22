using System;

namespace uniquearrayitem
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] items = { 1, 5, 9, 2, 5, 9, 8, 10 };
            int n = items.Length;

            Console.WriteLine("Unique array elements: ");

            for (int i = 0; i < n; i++)
            {
                bool isDuplicate = false;
                for (int j = 0; j < i; j++)
                {
                    if (items[i] == items[j])
                    {
                        isDuplicate = true;
                        break;
                    }
                }

                if (!isDuplicate)
                {
                    Console.WriteLine(items[i]);

                }
            }

            Console.ReadLine();
        }
    }
}
