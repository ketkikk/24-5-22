﻿using System;
using System.Collections.Generic;
using System.Text;

namespace interface_class
{
    interface Shape
    {
        public class Shape
        {
            protected Location c;

            public string ToString()
            {
                return string.Empty;
            }

            public double Area()
            {
                return 0.000;
            }

            public double Perimeter()
            {
                return 0.000;
            }
            public class Location
            {
                private double x, y;
            }
            public class Rectangle : Shape
            {
                protected double side1, side2;
            }

            public class Circle : Shape
            {
                protected double radius;
            }
        }
    }
}
