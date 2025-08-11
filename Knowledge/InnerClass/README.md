# Inner Classes

## What is it?
An **Inner Class** (also known as a **nested class**) is a class that is declared inside another class. This means that an **inner** class exists **within the scope** of an outer class. It can be useful when a class is only relevant within the context of another class.

[Click to see code example](../../CodeExamples/InnerClass.cs)

## Why Use Inner Classes?

Inner classes can be beneficial in specific scenarios:

 - **Encapsulation**: Inner classes help **group related logic** together, improving **readability** and **maintainability**.

 - **Restricting Scope**: If a class is only meant to be used inside another class, it makes sense to **keep it enclosed**.

 - **Better Organization**: When a class is tightly coupled to another class, defining it as an inner class can improve **code structure**.

## When to Use It?
Use inner classes when: 
 - The class is only relevant to its enclosing class. 
 - You want to improve encapsulation and avoid cluttering the global namespace. 
 - The inner class **requires access to private members** of the outer class.

## Best Practices:

 - Use inner classes only when they are **strongly related** to the outer class.
 - Keep inner classes **private** unless external access is necessary.
 - Use **static inner classes** if they don¡¯t require an outer instance.
 - Ensure **clean separation** of responsibilities.

## Common Mistakes:

 - **Overusing inner classes**: If a class can exist independently, it should **not** be an inner class. 
 - **Accessing outer class members incorrectly**: Use a **reference to the outer class** when accessing private members. 
 - **Ignoring encapsulation**: Avoid exposing inner class functionality unless required.
	
## Conclusion
Inner classes in C# provide a powerful way to **encapsulate logic** that is closely tied to an outer class. By using inner classes appropriately, we can **improve code organization, maintainability, and encapsulation**.

While not used frequently in everyday programming, inner classes are a useful tool for **structuring code efficiently** when needed. If you encounter a scenario where a class should only be used within another class, consider using an **inner class**.