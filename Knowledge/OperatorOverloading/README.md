# Operator Overloading

## What is it?
Operator overloading is a feature in C# that allows you to redefine the behavior of operators for custom classes and structs. By default, operators like `+`, `-`, `*`, and `/` work with built-in types such as `int`, `double`, and `string`. However, if you create a custom class (e.g., `Vector`, `Matrix`, `ComplexNumber`), C# does not automatically define how these operators should behave when applied to instances of your class.

With operator overloading, you can **extend the functionality of standard operators to work with your custom types**, making your code more intuitive and natural.

Similarly, operator overloading allows us to **customize existing operators to work with our own data types**, making them more useful in our specific scenarios.

[Click to see code example](../../CodeExamples/OperatorOverloading.cs){:target="_blank"}

## Best Practices:

 - Overload operators only when it improves **code readability and maintainability**.

 - Always overload the corresponding **opposite operator** (e.g., if you overload ==, also overload !=).

 - Keep operator implementations **efficient and meaningful**.

 - Use **value types** (structs) wisely when overloading to avoid unnecessary heap allocations.

## Common Mistakes:

 - Overloading an operator **without making its behavior intuitive**.

 - Forgetting to **return a new instance** (mutating an existing object can lead to unexpected side effects).

 - Not overloading complementary operators, causing inconsistent behavior.
	
## Conclusion
Operator overloading is a powerful feature in C# that allows us to **extend the functionality of standard operators for our custom classes**. 

With this custom behavior for operators like `+`, `-`, `*`, and `==`, we can make our code **more readable and intuitive**. This approach is particularly useful in mathematical operations, game development, and any domain where custom data types need to interact seamlessly.