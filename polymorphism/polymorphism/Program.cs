using System;

namespace polymorphism
{
    class Program
    {
    public static void sum()
        {
            int sum = 10 + 20;
            Console.WriteLine(sum);
        }
        public static void sum(int a, int b)
        {
            int sum = a + b;
            Console.WriteLine(sum);
        }
        public static void sum(int a, int b, int c)
        {
            int sum = a + b +c ;
            Console.WriteLine(sum);
        }
        public static void sum(string a, string b)
        {
            int sum =Convert.ToInt32(a) + Convert.ToInt32 (b);
            Console.WriteLine(sum);
        }
        static void Main1(string[] args)
        {
            sum();
            sum(2, 5, 3);
            sum(9, 3, 4);
            sum("8", "7");

        }
    }
}
