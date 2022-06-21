using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

class LinqExercise
{
    static void Main(string[] args)
    {

        List<int> list = new List<int>();
        list.Add(10);
        list.Add(20);
        list.Add(30);
        list.Add(40);
        list.Add(50);
      

        //List<int> list = new List<int>();
        //list.Add(10);
        //list.Add(20);
        //list.Add(30);
        //list.Add(40);
        //list.Add(5);

        Console.WriteLine("\nThe members of the list are : ");
        foreach (var lstnum in list)
        {
            Console.Write(lstnum + " ");
        }
        List<int> FilterList = list.FindAll(x => x > 20 ? true : false);
        Console.WriteLine("\n\nThe numbers greater than 20 are : ");
        foreach (var num in FilterList)
        {
            Console.WriteLine(num);
        }
        Console.ReadLine();
    }
}