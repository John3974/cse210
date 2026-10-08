using System;
using System.Collections.Generic;
using Shapes;
using System.Drawing;
using System.Formats.Asn1;
using System.Runtime.CompilerServices;



// Notice that the list is a list of "Shape" objects. That means
// you can put any Shape objects in there, and also, any object where
// the class inherits from Shape
List<Shape> shape = new List<Shape>();

Square s1 = new Square("Red", 3);
shape.Add(s1);

Rectangle s2 = new Rectangle(4, 5, "Blue");
shape.Add(s2);

Circle s3 = new Shapes.Circle(6, "Green");
shape.Add(s3);

foreach (Shape s in shape)
{
    // Notice that all shapes have a GetColor method from the base class
    string color = s.GetColor();

    // Notice that all shapes have a GetArea method, but the behavior is
    // different for each type of shape
    double area = s.GetArea();

    Console.WriteLine($"The {color} shape has an area of {area}.");
}
