using System;
using System.Collections.Generic;
using System.Text;

namespace Employee_information
{
    class student
    {
        public string sname;
        public int sid;
        public string classname;
        public string collegename;

        public student(string sname, int sid, string classname, string collegename)
        {
            this.sname = sname;
            this.sid = sid;
            this.classname = classname;
            this.collegename = collegename;
        }
    }
    public student1()
    {
        string collegename = "vdf school";
    }
    public void GetData()
    {

        Console.WriteLine("Please enter student name");
        string sname = Console.ReadLine();
        Console.WriteLine("Please enter student id");
        int sid = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Please enter student classname");
        string classname = Console.ReadLine();
    }
    public void PrintData()
    {
        string sname = null;
        Console.WriteLine("student name " + sname);
        string sid = null;
        Console.WriteLine("student id" + sid);
        string classname = null;
        Console.WriteLine("student classname" + classname);
        string collegename = null;
        Console.WriteLine("student collegename" + collegename);
    }

    static void Main(string[] args)
    {
        student1[] studentList = new student1[3];
        for (int i = 0; i < studentList.Length; i++) ;
        {
            student1 s = new student1();
            s.GetData();
            studentlist[i] = s;
        }
        for (int i = 0; i < studentList.Length; i++)
        {
            object p = studentList.Length[i].PrintData();
        }
    }
}
    
}  
    }
