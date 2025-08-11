// Basic Syntax
// An inner class is declared inside another class
using System;

public class OuterClass
{
    private string outerField = "I am from OuterClass";

    public class InnerClass
    {
        public void DisplayMessage()
        {
            Console.WriteLine("Hello from InnerClass");
        }
    }
}

class Program
{
    static void Main()
    {
        // Creating an instance of the inner class
        OuterClass.InnerClass innerObject = new OuterClass.InnerClass();
        innerObject.DisplayMessage(); // "Hello from InnerClass"
    }
}


// Accessing the Outer Class Members
// An inner class can access members of the outer class if they are marked as public or protected, or if it has a reference to the outer class.
using System;
 
public class OuterClass
{
    private string outerField = "I belong to OuterClass";

    public class InnerClass
    {
        private OuterClass outer;

        public InnerClass(OuterClass outer)
        {
            this.outer = outer;
        }

        public void DisplayOuterField()
        {
            Console.WriteLine(outer.outerField);
        }
    }
}

class Program
{
    static void Main()
    {
        OuterClass outerObject = new OuterClass();
        OuterClass.InnerClass innerObject = new OuterClass.InnerClass(outerObject);
        innerObject.DisplayOuterField(); // "I belong to OuterClass"
    }
}


// Static Nested Classes
// A static nested class is independent of an instance of the outer class, whereas an inner class depends on it.
public class OuterClass
{
    public static class StaticNestedClass
    {
        public static void ShowMessage()
        {
            Console.WriteLine("Hello from Static Nested Class");
        }
    }
}

class Program
{
    static void Main()
    {
        OuterClass.StaticNestedClass.ShowMessage();
    }
}