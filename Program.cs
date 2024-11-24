using System;

public abstract class Shape
{
    public abstract double Area();
    public static double GetArea(Shape shape)
    {
        return shape.Area();
    }
}

public class Square : Shape
{
    private double size;
    public Square(double length)
    {
        this.size = length;
    }
    public override double Area()
    {
        return Math.Pow(size, 2);
    }
}

public class Circle : Shape
{
    private double radius;
    public Circle(double radius)
    {
        this.radius = radius;
    }
    public override double Area()
    {
        return Math.Round(Math.PI * Math.Pow(radius, 2), 2);
    }
}

public class Rectangle : Shape
{
    private double length;
    private double width;

    public Rectangle(double length, double width)
    {
        this.length = length;
        this.width = width;
    }
    public override double Area()
    {
        return Math.Round(length * width, 2);
    }
}

public class Triangle : Shape
{
    private double length;
    private double height;

    public Triangle(double length, double height)
    {
        this.length = length;
        this.height = height;
    }
    public override double Area()
    {
        return Math.Round(0.5 * length * height, 2);
    }
}


/*
 * CSC180 Week12 Assignment #1
 * key concepts: abstract class/method; inheritance; constructor; array of objects
 * Tester: Program.cs
 */
public class Program
{
    public static void Main()
    {
        Shape[] shapes = { new Square(10), new Circle(10), new Rectangle(10,5),new Triangle(10,5)};
        foreach (var shape in shapes)
        {
            Console.WriteLine($"Area of {shape}: {shape.Area()}");
            Console.WriteLine($"Area of {shape}: {Shape.GetArea(shape)}, again");
        }
    }
}