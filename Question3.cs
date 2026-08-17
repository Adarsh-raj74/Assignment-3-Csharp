using System;

abstract class Shape
{
    public abstract void CalculateArea();
}
class Circle : Shape
{
    double radius;

    public Circle(double radius)
    {
        this.radius = radius;
    }

    public override void CalculateArea()
    {
        double area = Math.PI * radius * radius;
        Console.WriteLine("Area of Circle = " + area);
    }
}

class Rectangle : Shape
{
    double length, width;

    public Rectangle(double length, double width)
    {
        this.length = length;
        this.width = width;
    }

    public override void CalculateArea()
    {
        double area = length * width;
        Console.WriteLine("Area of Rectangle = " + area);
    }
}

class Program
{
    static void Main()
    {
        Shape circle = new Circle(4);
        circle.CalculateArea();

        Shape rectangle = new Rectangle(11, 5);
        rectangle.CalculateArea();
    }
}
