using System;

namespace exception_handling
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                int a = 5, b = 0;
                 int c = a / b;
                //int[] ar = new int[5];
                //ar[5] = 9;
               Console.WriteLine(c);
            }
            
            catch (Exception ex)
            {
                Console.WriteLine("Some error occured");
                Console.WriteLine(ex.Message);
                Console.WriteLine(ex.StackTrace);
            }

            finally
            {
                Console.WriteLine("I am coming from finally");
            }
        }
    }
}
