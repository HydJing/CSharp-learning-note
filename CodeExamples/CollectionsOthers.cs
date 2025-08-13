using System;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;

class Program
{
    // Sample class to represent a task, implementing INotifyPropertyChanged for ObservableCollection
    class Task : INotifyPropertyChanged
    {
        public int Id { get; }
        private string _description;
        private int _priority;

        public string Description
        {
            get => _description;
            set
            {
                _description = value;
                OnPropertyChanged(nameof(Description));
            }
        }
        public int Priority
        {
            get => _priority;
            set
            {
                _priority = value;
                OnPropertyChanged(nameof(Priority));
            }
        }

        public Task(int id, string description, int priority) => (Id, Description, Priority) = (id, description, priority);
        public override string ToString() => $"Task {Id}: {Description} (Priority: {Priority})";

        public event PropertyChangedEventHandler PropertyChanged;
        protected void OnPropertyChanged(string propertyName) =>
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
    }

    // Custom KeyedCollection for tasks
    class TaskKeyedCollection : KeyedCollection<int, Task>
    {
        protected override int GetKeyForItem(Task item) => item.Id;
    }

    static void Main()
    {
        // Array: Add, remove, access, update, query, clear
        Task[] tasks = new Task[3];
        tasks[0] = new Task(1, "Write report", 3); // Add via initialization
        tasks[1] = new Task(2, "Code feature", 1);
        Task firstTask = tasks[0]; // Access
        tasks[1].Priority = 2; // Update
        bool hasCode = tasks.Any(t => t?.Description == "Code feature"); // Query
        Array.Clear(tasks, 0, tasks.Length); // Clear
        Console.WriteLine($"Array: First: {firstTask}, Has Code: {hasCode}, First after clear: {tasks[0]}"); // Outputs: Task 1..., True, null

        // KeyedCollection: Add, remove, access, update, query
        TaskKeyedCollection taskCollection = new TaskKeyedCollection();
        taskCollection.Add(new Task(3, "Test module", 2)); // Add
        taskCollection.Add(new Task(4, "Deploy app", 1));
        Task testTask = taskCollection[3]; // Access
        taskCollection[3].Priority = 3; // Update
        bool hasDeploy = taskCollection.Contains(4); // Query
        taskCollection.Remove(3); // Remove
        Console.WriteLine($"KeyedCollection: Test Task: {testTask}, Has Deploy: {hasDeploy}, Count: {taskCollection.Count}"); // Outputs: Task 3..., True, 1

        // ObservableCollection: Add, remove, access, update, query
        ObservableCollection<Task> observableTasks = new ObservableCollection<Task>();
        observableTasks.CollectionChanged += (s, e) => Console.WriteLine($"ObservableCollection changed: Action={e.Action}");
        observableTasks.Add(new Task(5, "Plan sprint", 3)); // Add (triggers event)
        observableTasks.Add(new Task(6, "Write docs", 2));
        Task planTask = observableTasks[0]; // Access
        observableTasks[0].Priority = 4; // Update (triggers PropertyChanged)
        bool hasDocs = observableTasks.Contains(observableTasks[1]); // Query
        observableTasks.Clear(); // Clear (triggers event)
        Console.WriteLine($"ObservableCollection: Plan Task: {planTask}, Has Docs: {hasDocs}, Count: {observableTasks.Count}"); // Outputs: Task 5..., True, 0
    }
}