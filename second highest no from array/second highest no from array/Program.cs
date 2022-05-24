using System;

namespace second_highest_no_from_array
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = { 2, 24, 98, 22, 75, 88 };
            Array.Sort(array);
            Array.Reverse(array);
            Console.WriteLine("Second Highest Value In Array is =  " + array[1]);
            foreach(var result in array)
            {
                Console.Write(result + " ");
            }
               
        }
    }
}
