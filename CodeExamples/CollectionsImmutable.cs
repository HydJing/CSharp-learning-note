using System;
using System.Collections.Immutable;
using System.Linq;

class Program
{
    // Sample class to represent a task
    class Task
    {
        public int Id { get; }
        public string Description { get; }
        public int Priority { get; }
        public Task(int id, string description, int priority) => (Id, Description, Priority) = (id, description, priority);
        public override string ToString() => $"Task {Id}: {Description} (Priority: {Priority})";
    }

    static void Main()
    {
        // ImmutableList: Add, remove, access, update, query, clear
        ImmutableList<Task> tasks = ImmutableList.Create<Task>();
        tasks = tasks.Add(new Task(1, "Write report", 3)).AddRange(new[] { new Task(2, "Code feature", 1), new Task(3, "Test module", 2) }); // Add
        Task firstTask = tasks[0]; // Access
        tasks = tasks.SetItem(0, new Task(1, "Write report", 2)); // Update
        bool hasCode = tasks.Contains(tasks[1]); // Query
        tasks = tasks.RemoveAt(1); // Remove
        tasks = tasks.Clear(); // Clear
        Console.WriteLine($"ImmutableList: First: {firstTask}, Has Code: {hasCode}, Count: {tasks.Count}"); // Outputs: Task 1..., True, 0

        // ImmutableDictionary: Add, remove, access, update, query
        ImmutableDictionary<int, Task> taskLookup = ImmutableDictionary.Create<int, Task>();
        taskLookup = taskLookup.Add(1, new Task(1, "Design UI", 2)).Add(2, new Task(2, "Fix bugs", 1)); // Add
        taskLookup.TryGetValue(1, out Task uiTask); // Access
        taskLookup = taskLookup.SetItem(2, new Task(2, "Fix bugs", 2)); // Update
        bool hasKey = taskLookup.ContainsKey(1); // Query
        taskLookup = taskLookup.Remove(1); // Remove
        Console.WriteLine($"ImmutableDictionary: UI Task: {uiTask}, Has Key 1: {hasKey}, Count: {taskLookup.Count}"); // Outputs: Task 1..., True, 1

        // ImmutableSortedDictionary: Add, remove, access, update, query
        ImmutableSortedDictionary<string, Task> sortedByDesc = ImmutableSortedDictionary.Create<string, Task>();
        sortedByDesc = sortedByDesc.Add("Code feature", new Task(3, "Code feature", 1)).Add("Review code", new Task(4, "Review code", 2)); // Add
        sortedByDesc.TryGetValue("Code feature", out Task codeTask); // Access
        sortedByDesc = sortedByDesc.SetItem("Review code", new Task(4, "Review code", 1)); // Update
        bool hasReview = sortedByDesc.ContainsKey("Review code"); // Query
        sortedByDesc = sortedByDesc.Clear(); // Clear
        Console.WriteLine($"ImmutableSortedDictionary: Code Task: {codeTask}, Has Review: {hasReview}, Count: {sortedByDesc.Count}"); // Outputs: Task 3..., True, 0

        // ImmutableHashSet: Add, remove, access, query
        ImmutableHashSet<string> categories = ImmutableHashSet.Create<string>();
        categories = categories.Add("Development").Union(new[] { "Testing", "Reporting" }); // Add
        string firstCategory = categories.ElementAt(0); // Access
        categories = categories.Remove("Testing"); // Remove
        bool hasDev = categories.Contains("Development"); // Query
        categories = categories.Clear(); // Clear
        Console.WriteLine($"ImmutableHashSet: First: {firstCategory}, Has Development: {hasDev}, Count: {categories.Count}"); // Outputs: Development, True, 0

        // ImmutableSortedSet: Add, remove, access, query
        ImmutableSortedSet<int> priorities = ImmutableSortedSet.Create<int>();
        priorities = priorities.Add(1).Union(new[] { 2, 3 }); // Add
        int minPriority = priorities.Min; // Access
        priorities = priorities.Remove(2); // Remove
        bool hasThree = priorities.Contains(3); // Query
        priorities = priorities.Clear(); // Clear
        Console.WriteLine($"ImmutableSortedSet: Min: {minPriority}, Has 3: {hasThree}, Count: {priorities.Count}"); // Outputs: 1, True, 0

        // ImmutableQueue: Add, remove, access, query
        ImmutableQueue<Task> taskQueue = ImmutableQueue.Create<Task>();
        taskQueue = taskQueue.Enqueue(new Task(5, "Plan sprint", 3)).Enqueue(new Task(6, "Write docs", 2)); // Add
        Task peekTask = taskQueue.Peek(); // Access
        taskQueue = taskQueue.Dequeue(out Task dequeuedTask); // Remove
        bool isEmptyQueue = taskQueue.IsEmpty; // Query
        taskQueue = taskQueue.Clear(); // Clear
        Console.WriteLine($"ImmutableQueue: Peeked: {peekTask}, Dequeued: {dequeuedTask}, IsEmpty: {isEmptyQueue}"); // Outputs: Task 5..., Task 5..., False

        // ImmutableStack: Add, remove, access, query
        ImmutableStack<Task> taskStack = ImmutableStack.Create<Task>();
        taskStack = taskStack.Push(new Task(7, "Update API", 1)).Push(new Task(8, "Refactor code", 2)); // Add
        Task topTask = taskStack.Peek(); // Access
        taskStack = taskStack.Pop(out Task poppedTask); // Remove
        bool isEmptyStack = taskStack.IsEmpty; // Query
        taskStack = taskStack.Clear(); // Clear
        Console.WriteLine($"ImmutableStack: Top: {topTask}, Popped: {poppedTask}, IsEmpty: {isEmptyStack}"); // Outputs: Task 8..., Task 8..., False

        // ImmutableArray: Add, remove, access, update, query
        ImmutableArray<Task> taskArray = ImmutableArray.Create<Task>();
        taskArray = taskArray.Add(new Task(9, "Design DB", 3)).AddRange(new[] { new Task(10, "Setup server", 2) }); // Add
        Task firstArrayTask = taskArray[0]; // Access
        taskArray = taskArray.SetItem(0, new Task(9, "Design DB", 1)); // Update
        bool hasServer = taskArray.Contains(taskArray[1]); // Query
        taskArray = taskArray.RemoveAt(0); // Remove
        Console.WriteLine($"ImmutableArray: First: {firstArrayTask}, Has Server: {hasServer}, Count: {taskArray.Length}"); // Outputs: Task 9..., True, 1
    }
}