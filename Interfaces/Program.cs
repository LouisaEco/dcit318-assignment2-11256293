using System;

// Define interface
interface IMovable
{
    void Move();
}

// Class: Car
class Car : IMovable
{
    public void Move()
    {
        Console.WriteLine("Car is moving");
    }
}

// Class: Bicycle
class Bicycle : IMovable
{
    public void Move()
    {
        Console.WriteLine("Bicycle is moving");
    }
}

class InterfaceDemo
{
    static void Main(string[] args)
    {
        IMovable car = new Car();
        IMovable bike = new Bicycle();

        car.Move();   // Outputs: Car is moving
        bike.Move();  // Outputs: Bicycle is moving
    }
}
