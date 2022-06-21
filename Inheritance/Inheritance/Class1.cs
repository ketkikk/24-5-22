using System;
using System.Collections.Generic;
using System.Text;


namespace Inheritance
{
    class person
    {
        protected int age;
        public void greet()
        {
            Console.WriteLine("Hello");
        }
        public void setage(int _age)
        {
             age = _age;
        }
    }
    class Student : person
    {
        public void study()
        {
            Console.WriteLine("i am studying from screen");
        }
        public void showage()
        {
            Console.WriteLine("My age is :" +age);
        }
    }
    class Teacher: person
    {
        public void explain()
        {
            Console.WriteLine("i'm explaining");
        }
    }
    public class studentprofessorTest
    {
       public static void Main1()
        {
            person p = new person();
            p.greet();
            Student s = new Student();
            s.setage(18);
            s.greet();
            s.showage();
            Teacher t = new Teacher();
            t.setage(40);
            t.greet();
            t.explain();

        }
    }
}
