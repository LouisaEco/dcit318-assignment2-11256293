using System;

//Abstract class
abstract class Shape
{
    // Abstract method must be implemented by child classes
    public abstract double GetArea();
}

// Circle class inherits from Shape
class Circle : Shape
{
    public double Radius;

    public Circle(double radius)
    {
        Radius = radius;
    }

    public override double GetArea()
    {
        return Math.PI * Radius * Radius;
    }
}

// Rectangle class inherits from Shape
class Rectangle : Shape
{
    public double Width;
    public double Height;

    public Rectangle(double width, double height)
    {
        Width = width;
        Height = height;
    }

    public override double GetArea()
    {
        return Width * Height;
    }
}

// Main program
class Program
{
    static void Main()
    {
        Console.WriteLine("Area Calculator");
        Console.WriteLine("Choose a shape:");
        Console.WriteLine("1. Circle");
        Console.WriteLine("2. Rectangle");
        Console.Write("Enter your choice (1 or 2): ");

        string choice = Console.ReadLine();
        Shape shape = null;

        if (choice == "1")
        {
            Console.Write("Enter the radius of the circle: ");
            double radius = double.Parse(Console.ReadLine());
            shape = new Circle(radius);
        }
        else if (choice == "2")
        {
            Console.Write("Enter the width of the rectangle: ");
            double width = double.Parse(Console.ReadLine());
            Console.Write("Enter the height of the rectangle: ");
            double height = double.Parse(Console.ReadLine());
            shape = new Rectangle(width, height);
        }
        else
        {
            Console.WriteLine("Invalid choice.");
            return;
        }

        //Display area
        Console.WriteLine("Area: " + shape.GetArea());
    }
}
