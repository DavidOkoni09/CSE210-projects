using System;
using System.Diagnostics.CodeAnalysis;

public class Square : Shape
{
    private double _side;

    public Square(string color, double side) : base(color)
    {
        _side = side;
    }

    public double GetSide()
    {
        return _side;
    }

    public override double GetArea()
    {
        return _side * _side;
    }


}