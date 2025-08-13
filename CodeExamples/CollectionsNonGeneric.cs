using System;
using System.Collections;

class Program
{
    // Sample class to represent an inventory item
    class Item
    {
        public string Name { get; }
        public int Quantity { get; set; }
        public Item(string name, int quantity) => (Name, Quantity) = (name, quantity);
        public override string ToString() => $"{Name}: {Quantity}";
    }

    static void Main()
    {
        // ArrayList: Add, remove, access, update, query, clear
        ArrayList inventory = new ArrayList();
        inventory.Add(new Item("Laptop", 10));
        inventory.AddRange(new object[] { new Item("Mouse", 50), "Miscellaneous" }); // Add
        Item firstItem = (Item)inventory[0]; // Access
        inventory[1] = new Item("Mouse", 60); // Update
        bool hasMisc = inventory.Contains("Miscellaneous"); // Query
        inventory.Remove("Miscellaneous"); // Remove
        inventory.Clear(); // Clear
        Console.WriteLine($"ArrayList: First: {firstItem}, Has Misc: {hasMisc}, Count: {inventory.Count}"); // Outputs: Laptop: 10, True, 0

        // Hashtable: Add, remove, access, update, query
        Hashtable itemLookup = new Hashtable();
        itemLookup.Add("Laptop", new Item("Laptop", 10));
        itemLookup["Mouse"] = new Item("Mouse", 50); // Add
        Item mouseItem = (Item)itemLookup["Mouse"]; // Access
        itemLookup["Mouse"] = new Item("Mouse", 60); // Update
        bool hasLaptop = itemLookup.ContainsKey("Laptop"); // Query
        itemLookup.Remove("Laptop"); // Remove
        Console.WriteLine($"Hashtable: Mouse: {mouseItem}, Has Laptop: {hasLaptop}, Count: {itemLookup.Count}"); // Outputs: Mouse: 50, True, 1

        // Queue: Add, remove, access, query, clear
        Queue restockQueue = new Queue();
        restockQueue.Enqueue(new Item("Keyboard", 30));
        restockQueue.Enqueue("Monitor"); // Add
        object peekedItem = restockQueue.Peek(); // Access
        object dequeuedItem = restockQueue.Dequeue(); // Remove
        int queueCount = restockQueue.Count; // Query
        restockQueue.Clear(); // Clear
        Console.WriteLine($"Queue: Peeked: {peekedItem}, Dequeued: {dequeuedItem}, Count: {queueCount}"); // Outputs: Keyboard: 30, Keyboard: 30, 1

        // Stack: Add, remove, access, query, clear
        Stack shipments = new Stack();
        shipments.Push(new Item("Tablet", 20));
        shipments.Push("Order #1: 10 Laptops"); // Add
        object topShipment = shipments.Peek(); // Access
        object poppedShipment = shipments.Pop(); // Remove
        int stackCount = shipments.Count; // Query
        shipments.Clear(); // Clear
        Console.WriteLine($"Stack: Top: {topShipment}, Popped: {poppedShipment}, Count: {stackCount}"); // Outputs: Order #1..., Order #1..., 1

        // SortedList: Add, remove, access, update, query
        SortedList sortedInventory = new SortedList();
        sortedInventory.Add("Zebra", new Item("Zebra", 1));
        sortedInventory.Add("Apple", new Item("Apple", 2)); // Add
        Item appleItem = (Item)sortedInventory["Apple"]; // Access
        sortedInventory["Apple"] = new Item("Apple", 3); // Update
        bool hasZebra = sortedInventory.ContainsKey("Zebra"); // Query
        sortedInventory.Remove("Zebra"); // Remove
        Console.WriteLine($"SortedList: Apple: {appleItem}, Has Zebra: {hasZebra}, Count: {sortedInventory.Count}"); // Outputs: Apple: 2, True, 1

        // BitArray: Add, remove, access, update, query
        BitArray featureFlags = new BitArray(3);
        featureFlags[0] = true; // Add (set bit)
        bool flag0 = featureFlags[0]; // Access
        featureFlags[0] = false; // Update (unset bit, equivalent to remove)
        int flagCount = featureFlags.Length; // Query
        featureFlags.SetAll(false); // Clear
        Console.WriteLine($"BitArray: Flag 0: {flag0}, Length: {flagCount}, First after clear: {featureFlags[0]}"); // Outputs: True, 3, False
    }
}