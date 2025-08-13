using System;
using System.Collections.Concurrent;
using System.Threading.Tasks;

class Program
{
    // Sample class to represent a task
    class TaskItem
    {
        public int Id { get; }
        public string Description { get; }
        public TaskItem(int id, string description) => (Id, Description) = (id, description);
        public override string ToString() => $"Task {Id}: {Description}";
    }

    static void Main()
    {
        // ConcurrentDictionary: Add, remove, access, update, query
        ConcurrentDictionary<int, TaskItem> taskLookup = new ConcurrentDictionary<int, TaskItem>();
        Parallel.Invoke(
            () => taskLookup.TryAdd(1, new TaskItem(1, "Process data")),
            () => taskLookup.AddOrUpdate(2, new TaskItem(2, "Send email"), (k, v) => new TaskItem(k, "Updated email"))
        );
        taskLookup.TryGetValue(2, out TaskItem emailTask); // Access
        taskLookup.TryUpdate(2, new TaskItem(2, "Resend email"), emailTask); // Update
        bool hasKey = taskLookup.ContainsKey(2); // Query
        taskLookup.TryRemove(1, out TaskItem removedTask); // Remove
        Console.WriteLine($"ConcurrentDictionary: Key 2 exists: {hasKey}, Removed: {removedTask}"); // Outputs: True, Task 1: Process data

        // ConcurrentQueue: Add, remove, access, query, clear
        ConcurrentQueue<TaskItem> taskQueue = new ConcurrentQueue<TaskItem>();
        Parallel.Invoke(
            () => taskQueue.Enqueue(new TaskItem(3, "Generate report")),
            () => taskQueue.Enqueue(new TaskItem(4, "Backup database"))
        );
        taskQueue.TryPeek(out TaskItem peekedTask); // Access
        taskQueue.TryDequeue(out TaskItem dequeuedTask); // Remove
        bool isEmptyQueue = taskQueue.IsEmpty; // Query
        taskQueue.Clear(); // Clear
        Console.WriteLine($"ConcurrentQueue: Peeked: {peekedTask}, Dequeued: {dequeuedTask}, IsEmpty: {isEmptyQueue}"); // Outputs: Task 3..., Task 3..., True

        // ConcurrentStack: Add, remove, access, query, clear
        ConcurrentStack<TaskItem> taskHistory = new ConcurrentStack<TaskItem>();
        taskHistory.PushRange(new[] { new TaskItem(5, "Log error"), new TaskItem(6, "Notify admin") });
        taskHistory.TryPeek(out TaskItem topTask); // Access
        taskHistory.TryPop(out TaskItem poppedTask); // Remove
        int stackCount = taskHistory.Count; // Query
        taskHistory.Clear(); // Clear
        Console.WriteLine($"ConcurrentStack: Peeked: {topTask}, Popped: {poppedTask}, Count: {stackCount}"); // Outputs: Task 6..., Task 6..., 1

        // ConcurrentBag: Add, remove, access, query
        ConcurrentBag<TaskItem> taskResults = new ConcurrentBag<TaskItem>();
        Parallel.Invoke(
            () => taskResults.Add(new TaskItem(7, "Compute metrics")),
            () => taskResults.Add(new TaskItem(8, "Validate input"))
        );
        taskResults.TryPeek(out TaskItem peekedResult); // Access
        taskResults.TryTake(out TaskItem takenResult); // Remove
        int bagCount = taskResults.Count; // Query
        Console.WriteLine($"ConcurrentBag: Peeked: {peekedResult}, Taken: {takenResult}, Count: {bagCount}"); // Outputs: Task 7 or 8..., Task 7 or 8..., 1

        // BlockingCollection: Add, remove, query
        BlockingCollection<TaskItem> taskBuffer = new BlockingCollection<TaskItem>(boundedCapacity: 2);
        Task producer = Task.Run(() =>
        {
            taskBuffer.Add(new TaskItem(9, "Analyze logs")); // Add
            taskBuffer.TryAdd(new TaskItem(10, "Send alert")); // Non-blocking add
            taskBuffer.CompleteAdding(); // Signal no more additions
        });
        Task consumer = Task.Run(() =>
        {
            int bufferCount = taskBuffer.Count; // Query
            while (!taskBuffer.IsCompleted)
            {
                if (taskBuffer.TryTake(out TaskItem item, TimeSpan.FromMilliseconds(100))) // Remove
                    Console.WriteLine($"BlockingCollection: Taken: {item}, Count before: {bufferCount}");
            }
        });
        Task.WaitAll(producer, consumer); // Outputs: Task 9 or 10..., Count before: 2
    }
}