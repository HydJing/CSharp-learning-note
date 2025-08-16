// Abstract class - cannot be instantiated
using System;

abstract class Animal
{
    // Abstract method - must be implemented in derived classes
    public abstract void MakeSound();

    // Non-abstract method - can have a default implementation
    public void Sleep()
    {
        Console.WriteLine("Sleeping...");
    }
}

// Concrete class that inherits from Animal
class Dog : Animal
{
    // Providing implementation for abstract method
    public override void MakeSound()
    {
        Console.WriteLine("Woof! Woof!");
    }
}

class Program
{
    static void Main()
    {
        // Animal animal = new Animal(); // ERROR: Cannot instantiate abstract class
        Dog myDog = new Dog();
        myDog.MakeSound(); // Output: Woof! Woof!
        myDog.Sleep(); // Output: Sleeping...
    }
}

// Interface
using System;

// Define the interface
public interface IPaymentService
{
    void ProcessPayment(decimal amount);
}

// Implement the interface
public class CreditCardPaymentService : IPaymentService
{
    public void ProcessPayment(decimal amount)
    {
        Console.WriteLine($"Processing credit card payment of ${amount}");
    }
}

// Use the interface
public class OrderService
{
    private readonly IPaymentService _paymentService;

    public OrderService(IPaymentService paymentService)
    {
        _paymentService = paymentService;
    }

    public void CompleteOrder(decimal amount)
    {
        _paymentService.ProcessPayment(amount);
        Console.WriteLine("Order completed.");
    }
}

class Program
{
    static void Main()
    {
        IPaymentService paymentService = new CreditCardPaymentService();
        OrderService orderService = new OrderService(paymentService);

        orderService.CompleteOrder(99.99m);
    }
}
