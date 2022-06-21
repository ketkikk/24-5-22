using System;
using System.Collections.Generic;
using System.Text;

namespace Employee_information
{
    class Student
    {
        class Student
        {
            public string sname;
            public int sid;
            public string classname;
            public string collegename;
        }
        public Student()
        {
            collegename = "vdf school";
        }
        public void GetData()
        {
            
            Console.WriteLine("Please enter student name");
            sname=Console.ReadLine();
            Console.WriteLine("Please enter student id");
            sid=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please enter student classname");
            classname= Console.ReadLine();
        }
        public void PrintData()
        {
            Console.WriteLine("student name " +sname);
            Console.WriteLine("student id"+sid);
            Console.WriteLine("student classname"+classname);
            Console.WriteLine("student collegename"+ collegename);
        }

        static void Main1(string[] args)
        {
         student1[] studentList = new student1[3];
            for (int i = 0; i <studentList.Length; i++) ;
            {
                student1 s= new student1();
                s.GetData();
                studentlist[i] =s;
            }
            for (int i = 0; i < studentList.Length; i++)
            {
                studentList.Length[i].PrintData();
            }
        }
    }
}
