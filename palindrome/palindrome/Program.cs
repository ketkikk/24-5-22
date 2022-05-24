using System;

namespace palindrome
{
    class Program
    {
        static void Main(string[] args)
        {
            string str = "";
            Console.WriteLine("Enter a String");
            str = Console.ReadLine();
            char[] arr = str.ToCharArray();
            Array.Reverse(arr);
            string str_reverse = new string(arr);
            if (str.ToLower().Equals(str_reverse.ToLower()))
            {
                Console.WriteLine(str + " It is a palindrome string..");
            }
            else
            {
                Console.WriteLine(str + " It is not a palindrome string..");
            }
            Console.ReadLine();
        }
    }
}
