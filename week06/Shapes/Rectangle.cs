using System.Drawing;

public class Rectangle : Shape
{
    private double _width;
    private double _length;


    public Rectangle(double width, double length, string color) : base(color)
    {
        _width = width;
        _length = length;


    }

    public double Getwidth()
    {
        return _width;
    }

    public void Setwidth(float side)
    {
        _width = side;
    }

    public double Getlength()
    {
        return _length;
    }

    public void Setlength(float side)
    {
        _length = side;
    }

    public override double GetArea()
    {
        return _width * _length;
    }



}