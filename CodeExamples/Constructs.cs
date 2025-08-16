using System;

public struct Point
{
    public int X { get; }
    public int Y { get; }

    public Point(int x, int y)
    {
        X = x;
        Y = y;
    }

    public void Print()
    {
        Console.WriteLine($"Point: ({X}, {Y})");
    }
}

class Program
{
    static void Main()
    {
        // Create a struct instance
        Point p1 = new Point(3, 4);
        p1.Print(); // Output: Point: (3, 4)

        // Copy struct
        Point p2 = p1;
        Console.WriteLine("After copying:");
        p2.Print(); // Output: Point: (3, 4)

        // Modify p2 (not possible because fields are readonly)
        // p2.X = 10; // Compile-time error

        // Pass struct to method
        MovePoint(p1);
        Console.WriteLine("After MovePoint method:");
        p1.Print(); // Output: Point: (3, 4) ¨C original unchanged
    }

    static void MovePoint(Point point)
    {
        // point is a copy, modifying it does not affect the original
        Point moved = new Point(point.X + 10, point.Y + 10);
        moved.Print(); // Output: Point: (13, 14)
    }
}
