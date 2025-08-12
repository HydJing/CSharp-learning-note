class MathOperations
{
    public int Square(int number)
    {
        return number * number;
    }
}

// becomes below

class MathOperations
{
    public int Square(int number) => number * number;
}


// ============================
// another example

class Person
{
    private string name;

    public Person(string name)
    {
        this.name = name;
    }

    public string Name
    {
        get { return name; }
    }
}

// becomes below

class Person
{
    private string name;

    public Person(string name)
    {
        this.name = name;
    }

    public string Name => name; 
}

// ============================
// another example

class Collection
{
    private int[] numbers = { 1, 2, 3, 4, 5 };

    public int this[int index]
    {
        get { return numbers[index]; }
    }
}

// becomes below

class Collection
{
    private int[] numbers = { 1, 2, 3, 4, 5 };

    public int this[int index] => numbers[index];
}