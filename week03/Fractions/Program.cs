<<<<<<< HEAD
using System;

public class Fraction
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Fractions Project.");
        Fraction fraction = new Fraction();
    }
    private int _top;
    private int _bottom;

    public Fraction()
    {
        _top = 1;
        _bottom = 1;
    }

    public Fraction(int top, int bottom)
    {
        _top = top;
        _bottom = bottom;
    }
    public string GetFractionString()
    {
        string fraction = $"{_top}/{_bottom}";
        return fraction;

    }
    public double GetDecimalValue()
    {
        double decimalValue = (double)_top / (double)_bottom;
        return decimalValue;
    }








}
=======
using System;

public class Fraction
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Fractions Project.");
        Fraction fraction = new Fraction();
    }
    private int _top;
    private int _bottom;

    public Fraction()
    {
        _top = 1;
        _bottom = 1;
    }

    public Fraction(int top, int bottom)
    {
        _top = top;
        _bottom = bottom;
    }
    public string GetFractionString()
    {
        string fraction = $"{_top}/{_bottom}";
        return fraction;

    }
    public double GetDecimalValue()
    {
        double decimalValue = (double)_top / (double)_bottom;
        return decimalValue;
    }








}
>>>>>>> e0a3d674394e1dd1c8c05d09e00dfd83aa905b50
