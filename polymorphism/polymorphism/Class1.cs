using System;
using System.Collections.Generic;
using System.Text;

namespace polymorphism
{
   
    class Class1
    {
        public int Number1;
        public int Number2;
        public Class1(int num1, int num2)
        {
            Number1 = num1;
            Number2 = num2;
        }
        public void print()
        {
            Console.WriteLine("Number1 " + Number1);
            Console.WriteLine("Number2 " + Number2);
        }
        public static Calculator operator *(Calculator c1 , Calculator c2)
        {
            Calculator c3 = new Calculator(1, 1);

            c3.Number1 = c1.Number1 * c2.Number1;
            c3.Number2 = c1.Number2 * c2.Number2;

            return c3;
        }
        static void Main(string[] args)
        {
            Calculator c1 = new Calculator(2, 2);
            Calculator c2 = new Calculator(3, 3);
            Calculator c3 = new Calculator(1, 1);
            c3 = c1*c2;
            c3.Print();
        }
    }

}
