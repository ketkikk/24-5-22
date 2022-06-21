using System;

namespace jagged_array
{
    class Program
    {
        static void Main(string[] args)
        {
            int[][] arr = new int[3][]
            {
             new int[] { 1, 2, 3, 4, 5, 6, 7, 8 },
             new int[] { 1, 2, 3, 4, 5, 6, },
             new int[] { 1, 2, 3, 4, 5 }
            };


            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = 0; j < arr[i].Length; j++)
                {
                    System.Console.Write(arr[i][j] + " ");
                }
                System.Console.WriteLine();
            }
        }
    }
}