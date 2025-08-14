// Imagine a Car and a Vehicle. A Car IS-A Vehicle
using System;

class Vehicle
{
    public void Move()
    {
        Console.WriteLine("The vehicle is moving");
    }
}

class Car : Vehicle
{
    public void Honk()
    {
        Console.WriteLine("The car is honking");
    }
}

class Program
{
    static void Main()
    {
        Car myCar = new Car();
        myCar.Move(); // Inherited from Vehicle
        myCar.Honk(); // Specific to Car
    }
}

// Consider a Car and an Engine
class Engine
{
    public void Start()
    {
        Console.WriteLine("Engine started");
    }
}

class Car
{
    private Engine engine = new Engine();

    public void StartCar()
    {
        engine.Start(); // Car contains an Engine and uses it
        Console.WriteLine("Car is ready to drive");
    }
}

class Program
{
    static void Main()
    {
        Car myCar = new Car();
        myCar.StartCar();
    }
}