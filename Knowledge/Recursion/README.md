# Recursion

## What is it?

Recursion is a **programming technique where a function calls itself** to solve a problem. Instead of using loops, recursion breaks a problem into smaller subproblems of the same type, repeatedly calling itself until it reaches a base condition.

Every recursive function has two key components:

 1. **Base Case** ¨C This is the condition that stops recursion. Without a base case, recursion would continue forever, causing a **stack overflow error**.

 2. **Recursive Case** ¨C This is where the function calls itself with a smaller or simpler problem, gradually working towards the base case.

[Click to see code example](../../CodeExamples/Recursion.cs)


## Best Practices and Common Mistakes
Best Practices
 - Always define a **base case** to prevent infinite recursion.
 - Use recursion for **problems that naturally fit its approach**, like tree traversal and divide-and-conquer algorithms.
 - Keep an eye on the **call stack size**, as too many recursive calls can lead to a **stack overflow**.

## Common Mistakes
 - **Forgetting the base case**: This leads to infinite recursion.

 - **Using recursion when a simple loop is better**: Recursion isn¡¯t always the best solution for simple iterative tasks.

 - **Not reducing the problem size properly**: Ensure the recursive call moves toward the base case.

## When to Use Recursion?

 - The problem **naturally fits a recursive approach** (e.g., mathematical problems, backtracking, searching).

 - You need to **traverse hierarchical data** like trees and graphs.

 - A problem can be broken into **smaller subproblems** of the same type.

## Examples of Recursion in Real-World Applications
 - **Sorting algorithms** (QuickSort, MergeSort)

 - **Tree traversal** (Binary trees, file system navigation)

 - **Backtracking problems** (Sudoku solver, Maze solving)

 - **Mathematical problems** (Fibonacci series, Factorials)


## Conclusion
Recursion is a powerful programming concept where a function calls itself to solve smaller instances of the same problem. It provides an elegant solution for problems involving hierarchical structures or repetitive processes but should be used wisely to avoid unnecessary memory consumption.