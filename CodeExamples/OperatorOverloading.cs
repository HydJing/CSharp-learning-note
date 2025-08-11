using System;

public class Vector
{
    public int X { get; set; }
    public int Y { get; set; }

    public Vector(int x, int y)
    {
        X = x;
        Y = y;
    }

    public void Display()
    {
        Console.WriteLine($"Vector: ({X}, {Y})");
    }
}


public static Vector operator +(Vector v1, Vector v2)
{
    return new Vector(v1.X + v2.X, v1.Y + v2.Y);
}



class Program
{
    static void Main()
    {
        Vector v1 = new Vector(3, 5);
        Vector v2 = new Vector(7, 2);
        Vector result = v1 + v2;

        result.Display(); // Output: Vector: (10, 7)
    }
}


// Alternative
public Vector Add(Vector other)
{
    return new Vector(this.X + other.X, this.Y + other.Y);
}
Vector result = v1.Add(v2);
