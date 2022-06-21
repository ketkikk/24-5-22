using System;
using System.Linq;

class LinqExercise2
{
    static void Main1()
    {
        int[] n1 = {4, 22, 3, 56, 9};
        //int[] n2 = { 2, 4, 6, 8, 10 };

        Console.Write("\nLINQ : Using multiple WHERE clause to find the positive numbers within the list : ");


        Console.Write("\n-----------------------------------------------------------------------------");

        var nQuery =
             from VrNum in n1
             //from VrNum in n2
        where VrNum > 0
        where VrNum < 10
        select VrNum;
        Console.Write("\nThe numbers within the range of 1 to 10 are : \n");
        foreach (var VrNum in nQuery)
        {
            Console.Write("{0}  ", VrNum);
        }
        Console.Write("\n\n");
    }
}
