# Method hiding and overriding

## What is it?

**Method Hiding** is a technique in C# that allows a derived class to define a method with the same name as a method in the base class, effectively hiding the base class method rather than overriding it. This is done using the `new` keyword.

**Method overriding** in C# allows a derived class to provide a new implementation for a base class method marked as `virtual` or `abstract`, using the `override` keyword.

[Click to see code example](../../CodeExamples/MethodHidingAndOverriding.cs)

## When to Use Which?
 - Method Hiding:
	- You want to introduce a new method in a derived class without affecting the base class method.
	- You don¡¯t need polymorphic behavior (i.e., calling methods dynamically based on object type).
	- The base class method should still be accessible if needed.
 - Method Overriding:
	- You want polymorphic behavior.
	- The method in the derived class should replace the base class method completely.
	- The base method is declared as `virtual`, `abstract`, or `override`.

## Best Practices
 - Always use the `new` keyword when hiding a method to make it explicit.
 - Consider if method overriding is a better choice before using method hiding.
 - Keep the base method accessible when appropriate to avoid confusion.

## Common Mistakes
 - **Forgetting the `new` keyword** ¨C This causes a compiler warning, as C# assumes you unintentionally hid the method.
 - **Expecting polymorphism to work with method hiding** ¨C If you call the hidden method on a base class reference, it will execute the base class version instead.

## Conclusion
**Method Hiding** allows a derived class to define a method with the same name as a method in the base class without overriding it. It is useful when you want to keep the base class method intact while providing a new implementation in the derived class.

While it might seem similar to **Method Overriding**, the key difference is that **Method Hiding does not support polymorphism**. If you need polymorphism, **overriding is the better approach**.