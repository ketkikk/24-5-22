using System;
using System.Collections;
using System.Text;
namespace radius_circumference
{
    class Program
    {
        class propertiesinclass
        {
            public propertiesinclass(double r)
            {
                _radius = r;
            }
            private double _radius;
            private const double _pi = 3.14;
            public double radius
            {
                get
                {
                    return _radius;
                }
            }
            public void PrintCircumference()
            {
                Console.WriteLine(2 * _pi * radius);
            }
        }
        class class2
        {
            public static void Main1()
            {
                propertiesinclass p = new propertiesinclass(5);
                Console.WriteLine("Radius is " + p.radius);
                p.PrintCircumference();
                
            }
         }
    }
}
    