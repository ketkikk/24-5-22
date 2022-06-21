using System;

namespace student_class
{
    class student1
    {
        
        public string sname;
        public int sid;
        public string classname;
       public void GetData()
        {
            Console.WriteLine("Please enter student name");
           sname = Console.ReadLine();
            Console.WriteLine("Please enter student id");
            sid = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please enter student classname");
            classname = Console.ReadLine();
        }
        public void printdata()
        {
            
            Console.WriteLine("student name\n " + sname);
           
            Console.WriteLine("student id\n " + sid);
            
            Console.WriteLine("student classname\n " + classname);
        }
        static void Main(string[] args)
        {
            student1[] studentList = new student1[1];

        for(int i=0; i< studentList.Length; i++)
            {
                student1 s = new student1();
                s.GetData();
                studentList[i] = s;
            } 
        for (int i=0; i < studentList.Length; i++)
            {
                studentList[i].printdata();
            }

        }
    }
}

