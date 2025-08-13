using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    // Sample class to represent a task
    class Task
    {
        public int Id { get; }
        public string Description { get; }
        public int Priority { get; set; }
        public Task(int id, string description, int priority) => (Id, Description, Priority) = (id, description, priority);
        public override string ToString() => $"Task {Id}: {Description} (Priority: {Priority})";
    }

    static void Main()
    {
        // List<T>: Add and remove tasks
        List<Task> tasks = new List<Task>();
        tasks.Add(new Task(1, "Write report", 3));
        tasks.AddRange(new[] { new Task(2, "Code feature", 1), new Task(3, "Test module", 2) });
        tasks.RemoveAt(1); // Remove task at index 1
        Console.WriteLine("List after removal: " + tasks.First()); // Outputs: Task 1: Write report...

        // Dictionary<TKey, TValue>: Add and remove tasks by ID
        Dictionary<int, Task> taskLookup = new Dictionary<int, Task>();
        taskLookup.Add(1, new Task(1, "Design UI", 2));
        taskLookup[2] = new Task(2, "Fix bugs", 1); // Add via indexer
        taskLookup.Remove(1); // Remove by key
        Console.WriteLine("Dictionary after removal: " + taskLookup[2]); // Outputs: Task 2: Fix bugs...

        // SortedDictionary<TKey, TValue>: Add and remove by description
        SortedDictionary<string, Task> sortedByDesc = new SortedDictionary<string, Task>();
        sortedByDesc.Add("Code feature", new Task(3, "Code feature", 1));
        sortedByDesc.Add("Review code", new Task(4, "Review code", 2));
        sortedByDesc.Remove("Code feature"); // Remove by key
        Console.WriteLine("SortedDictionary first: " + sortedByDesc.First().Value); // Outputs: Task 4: Review code...

        // SortedList<TKey, TValue>: Add and remove high-priority tasks
        SortedList<int, Task> priorityTasks = new SortedList<int, Task>();
        priorityTasks.Add(3, new Task(3, "Test module", 2));
        priorityTasks.Add(4, new Task(4, "Deploy app", 1));
        priorityTasks.RemoveAt(0); // Remove by index
        Console.WriteLine("SortedList first: " + priorityTasks.First().Value); // Outputs: Task 4: Deploy app...

        // HashSet<T>: Add and remove task categories
        HashSet<string> categories = new HashSet<string>();
        categories.Add("Development");
        categories.Add("Testing");
        categories.Remove("Testing"); // Remove category
        Console.WriteLine("HashSet count: " + categories.Count); // Outputs: 1

        // SortedSet<T>: Add and remove task priorities
        SortedSet<int> uniquePriorities = new SortedSet<int>();
        uniquePriorities.Add(1);
        uniquePriorities.Add(2);
        uniquePriorities.Remove(2); // Remove priority
        Console.WriteLine("SortedSet highest: " + uniquePriorities.Min); // Outputs: 1

        // Queue<T>: Add and remove tasks in FIFO order
        Queue<Task> taskQueue = new Queue<Task>();
        taskQueue.Enqueue(new Task(5, "Plan sprint", 3));
        taskQueue.Enqueue(new Task(6, "Write docs", 2));
        var processed = taskQueue.Dequeue(); // Remove and get first task
        Console.WriteLine("Queue processed: " + processed); // Outputs: Task 5: Plan sprint...

        // Stack<T>: Add and remove tasks in LIFO order
        Stack<Task> taskHistory = new Stack<Task>();
        taskHistory.Push(new Task(7, "Update API", 1));
        taskHistory.Push(new Task(8, "Refactor code", 2));
        var lastTask = taskHistory.Pop(); // Remove and get top task
        Console.WriteLine("Stack last: " + lastTask); // Outputs: Task 8: Refactor code...

        // LinkedList<T>: Add and remove tasks in a workflow
        LinkedList<Task> workflow = new LinkedList<Task>();
        var node1 = workflow.AddLast(new Task(9, "Design DB", 3));
        workflow.AddFirst(new Task(10, "Setup server", 2));
        workflow.AddAfter(node1, new Task(11, "Test API", 1));
        workflow.Remove(node1); // Remove specific node
        Console.WriteLine("LinkedList first: " + workflow.First.Value); // Outputs: Task 10: Setup server...
    }
}