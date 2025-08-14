# Method Sealed

## What is it?

A **sealed method** is a method in a base class that **prevents further overriding** in derived classes. In other words, once a method is sealed, it **cannot be modified** by any subclass.

In C#, a method can only be sealed if it is already **overridden** in a derived class. This means you cannot seal a method directly in the base class; it must first be an overridden method.

[Click to see code example](../../CodeExamples/MethodSealed.cs)

## When to Use Which?
 - **Prevent Unintended Changes** 每 If you have a method that you don't want subclasses to alter, sealing it ensures consistency.
 - **Maintain Security and Integrity** 每 In sensitive applications like banking software or authentication systems, sealing methods can prevent unauthorized modifications.
 - **Optimize Performance** 每 The JIT compiler can optimize sealed methods more efficiently since it knows the method will not be overridden.

## Best Practices
 - **Seal only when necessary** 每 Use sealed methods **only when overriding should be prevented**.
 - **Keep base classes flexible** 每 Avoid sealing methods too early unless you are sure they should not be modified.
 - **Document the reason for sealing** 每 When working in a team, adding comments explaining why a method is sealed can be helpful.

## Common Mistakes
 - **Trying to seal a non-overridden method** 每 You **cannot** seal a method in a base class unless it is overridden.
 - **Overusing sealed methods** 每 Sealing too many methods can reduce the flexibility of your class design.
 - **Forgetting to mark base methods as virtual** 每 If you want a method to be overridden first before sealing, make sure it＊s **virtual** in the base class.

## Conclusion
Sealed methods in C# allow developers to **prevent further modifications** of an overridden method in derived classes. This helps in** maintaining code integrity, optimizing performance, and ensuring security** in critical applications.

By using sealed methods wisely, you can **protect important behaviors** in your application while still allowing controlled flexibility.