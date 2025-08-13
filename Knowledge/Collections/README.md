# Summary of C# Collections

# Table of Contents for C# Collections

- [Non-Generic Collections](#non-generic-collections)
  - [ArrayList](#arraylist)
  - [Hashtable](#hashtable)
  - [Queue](#queue)
  - [Stack](#stack)
  - [SortedList](#sortedlist)
  - [BitArray](#bitarray)
  - [Code Example](#non-generic-code-example)
  - [Notes](#non-generic-notes)
- [Generic Collections](#generic-collections)
  - [List](#listt)
  - [Dictionary](#dictionary)
  - [SortedDictionary](#sorteddictionary)
  - [SortedList](#sortedlist-generic)
  - [HashSet](#hashset)
  - [SortedSet](#sortedset)
  - [Queue](#queue-generic)
  - [Stack](#stack-generic)
  - [LinkedList](#linkedlist)
  - [Code Example](#generic-code-example)
  - [Notes](#generic-notes)
- [Concurrent Collections](#concurrent-collections)
  - [ConcurrentDictionary](#concurrentdictionary)
  - [ConcurrentQueue](#concurrentqueue)
  - [ConcurrentStack](#concurrentstack)
  - [ConcurrentBag](#concurrentbag)
  - [BlockingCollection](#blockingcollection)
  - [Code Example](#concurrent-code-example)
  - [Notes](#concurrent-notes)
- [Specialized Collections](#specialized-collections)
  - [NameValueCollection](#namevaluecollection)
  - [StringCollection](#stringcollection)
  - [StringDictionary](#stringdictionary)
  - [HybridDictionary](#hybriddictionary)
  - [ListDictionary](#listdictionary)
  - [OrderedDictionary](#ordereddictionary)
  - [BitVector32](#bitvector32)
  - [Code Example](#specialized-code-example)
  - [Notes](#specialized-notes)
- [Immutable Collections](#immutable-collections)
  - [ImmutableList](#immutablelist)
  - [ImmutableDictionary](#immutabledictionary)
  - [ImmutableSortedDictionary](#immutablesorteddictionary)
  - [ImmutableHashSet](#immutablehashset)
  - [ImmutableSortedSet](#immutablesortedset)
  - [ImmutableQueue](#immutablequeue)
  - [ImmutableStack](#immutablestack)
  - [ImmutableArray](#immutablearray)
  - [Code Example](#immutable-code-example)
  - [Notes](#immutable-notes)
- [Other Notable Collections](#other-notable-collections)
  - [Array](#array)
  - [KeyedCollection](#keyedcollection)
  - [ObservableCollection](#observablecollection)
  - [Code Example](#other-code-example)
  - [Notes](#other-notes)

# Non-Generic Collections

Non-generic collections, located in the `System.Collections` namespace, store elements as `object`, allowing mixed types but lacking type safety. They are legacy collections, generally replaced by generic collections in modern C# due to performance and type-checking benefits. Below is a summary of each collection, its common use cases, basic operations (including add, remove, access, update, query, and clear), and an advanced code example demonstrating these operations in an inventory management system.

## ArrayList
- **Description**: A dynamic array that can grow or shrink, storing elements of any type.
- **Use Case**: Flexible list for legacy code or when type safety isn¡¯t required.
- **Common Usage**: Storing mixed-type data, such as user inputs or temporary collections.
- **Basic Operations**:
  - **Add**: `Add(object item)`, `AddRange(ICollection items)` to append items.
  - **Remove**: `Remove(object item)`, `RemoveAt(int index)`, `RemoveRange(int index, int count)` to delete items.
  - **Access**: Indexer (`this[int index]`) to get/set items; `IndexOf(object item)` to find index.
  - **Update**: Modify via indexer (`list[index] = value`) or methods like `Sort()` or `Reverse()`.
  - **Query**: `Contains(object item)`, `Count` to check content.
  - **Clear**: `Clear()` to remove all items.

## Hashtable
- **Description**: A collection of key-value pairs organized by the hash code of the key, with keys and values as `object`.
- **Use Case**: Fast key-based lookups in non-type-safe scenarios.
- **Common Usage**: Caching data or mapping keys to values in legacy systems.
- **Basic Operations**:
  - **Add**: `Add(object key, object value)` to insert a key-value pair.
  - **Remove**: `Remove(object key)` to delete a key-value pair.
  - **Access**: Indexer (`this[object key]`) to get/set values.
  - **Update**: Modify via indexer (`hashtable[key] = value`).
  - **Query**: `ContainsKey(object key)`, `ContainsValue(object value)`, `Count` to check content.
  - **Clear**: `Clear()` to remove all pairs.

## Queue
- **Description**: A first-in, first-out (FIFO) collection.
- **Use Case**: Processing items in the order they were added.
- **Common Usage**: Task queues or event handling in legacy applications.
- **Basic Operations**:
  - **Add**: `Enqueue(object item)` to add an item to the end.
  - **Remove**: `Dequeue()` to remove and retrieve the item at the front.
  - **Access**: `Peek()` to retrieve the front item without removing.
  - **Query**: `Count` to get number of items.
  - **Clear**: `Clear()` to remove all items.

## Stack
- **Description**: A last-in, first-out (LIFO) collection.
- **Use Case**: Managing items where the most recent addition is processed first.
- **Common Usage**: Undo operations or backtracking in legacy code.
- **Basic Operations**:
  - **Add**: `Push(object item)` to add an item to the top.
  - **Remove**: `Pop()` to remove and retrieve the top item.
  - **Access**: `Peek()` to retrieve the top item without removing.
  - **Query**: `Count` to get number of items.
  - **Clear**: `Clear()` to remove all items.

## SortedList
- **Description**: A collection of key-value pairs sorted by key.
- **Use Case**: Key-value storage requiring sorted iteration.
- **Common Usage**: Ordered data storage in legacy systems, such as sorted configurations.
- **Basic Operations**:
  - **Add**: `Add(object key, object value)` to insert a key-value pair.
  - **Remove**: `Remove(object key)`, `RemoveAt(int index)` to delete a key-value pair.
  - **Access**: `GetByIndex(int index)`, `GetKey(int index)`, `GetValueList()`, indexer (`this[object key]`) for get/set.
  - **Update**: Modify via indexer (`sortedList[key] = value`).
  - **Query**: `ContainsKey(object key)`, `ContainsValue(object value)`, `Count` to check content.
  - **Clear**: `Clear()` to remove all pairs.

## BitArray
- **Description**: A compact array of bit values (true/false).
- **Use Case**: Efficient storage and manipulation of boolean flags.
- **Common Usage**: Managing feature flags or permissions in memory-constrained scenarios.
- **Basic Operations**:
  - **Add**: Set bits using indexer (`bitArray[index] = true`) or constructor initialization.
  - **Remove**: No direct remove; set bits to `false` (`bitArray[index] = false`) or resize.
  - **Access**: Indexer (`this[int index]`) to get/set bits.
  - **Update**: Modify via indexer or methods like `And(BitArray)`, `Or(BitArray)`.
  - **Query**: `Length`, `Get(int index)`, `Count` to check content.
  - **Clear**: `SetAll(false)` to reset all bits.


[Click to see code example](../../CodeExamples/CollectionsNonGeneric.cs)

## Non-Generic Notes

 - Type Safety: Non-generic collections store items as `object`, requiring casting and risking runtime errors.
 - Performance: Boxing/unboxing for value types (e.g., `int`) can reduce performance.
 - Basic Operations: The example demonstrates add, remove, access, update, query, and clear operations in a practical inventory management context.
 - Recommendation: Use generic collections (`System.Collections.Generic`) for new code unless maintaining legacy systems.


# Generic Collections

Generic collections in the `System.Collections.Generic` namespace provide type-safe, efficient data structures for modern C# applications. They offer compile-time type checking and eliminate boxing/unboxing overhead, making them the preferred choice over non-generic collections. Below is a summary of each collection, its common use cases, basic operations (including add, remove, access, update, query, and clear), and an advanced code example demonstrating these operations in a task management system.

## `List<T>`
- **Description**: A dynamic, resizable array of elements of type `T`.
- **Use Case**: Storing ordered sequences, such as lists of records, with frequent access or modifications.
- **Common Usage**: Managing collections like user lists, product inventories, or task logs.
- **Basic Operations**:
  - **Add**: `Add(T item)`, `AddRange(IEnumerable<T> items)` to append items.
  - **Remove**: `Remove(T item)`, `RemoveAt(int index)`, `RemoveAll(Predicate<T> match)` to delete items.
  - **Access**: Indexer (`this[int index]`) to get/set items; `Find(Predicate<T> match)` to search.
  - **Update**: Modify via indexer (`list[index] = value`) or methods like `Sort()` or `Reverse()`.
  - **Query**: `Contains(T item)`, `Count`, `Exists(Predicate<T> match)` to check content.
  - **Clear**: `Clear()` to remove all items.

## `Dictionary<TKey, TValue>`
- **Description**: A collection of key-value pairs with unique keys, optimized for fast lookup using hashing.
- **Use Case**: Quick key-based access, such as mapping IDs to objects or caching.
- **Common Usage**: Lookup tables, configuration settings, or indexing objects.
- **Basic Operations**:
  - **Add**: `Add(TKey key, TValue value)` to insert a key-value pair.
  - **Remove**: `Remove(TKey key)` to delete a key-value pair.
  - **Access**: `TryGetValue(TKey key, out TValue value)` to retrieve; indexer (`this[TKey key]`) for get/set.
  - **Update**: Modify via indexer (`dict[key] = value`).
  - **Query**: `ContainsKey(TKey key)`, `ContainsValue(TValue value)`, `Count` to check content.
  - **Clear**: `Clear()` to remove all pairs.

## `SortedDictionary<TKey, TValue>`
- **Description**: A dictionary maintaining keys in sorted order using a binary search tree.
- **Use Case**: Key-value storage requiring sorted iteration.
- **Common Usage**: Ordered lookups, such as sorted settings or records.
- **Basic Operations**:
  - **Add**: `Add(TKey key, TValue value)` to insert a key-value pair.
  - **Remove**: `Remove(TKey key)` to delete a key-value pair.
  - **Access**: `TryGetValue(TKey key, out TValue value)`; indexer (`this[TKey key]`) for get/set.
  - **Update**: Modify via indexer (`dict[key] = value`).
  - **Query**: `ContainsKey(TKey key)`, `Count`, `Keys`, `Values` to check content.
  - **Clear**: `Clear()` to remove all pairs.

## `SortedList<TKey, TValue>`
- **Description**: A sorted key-value collection stored in contiguous memory, memory-efficient compared to `SortedDictionary`.
- **Use Case**: Sorted key-value pairs for smaller datasets or memory-constrained scenarios.
- **Common Usage**: Sorted data with frequent access.
- **Basic Operations**:
  - **Add**: `Add(TKey key, TValue value)` to insert a key-value pair.
  - **Remove**: `Remove(TKey key)`, `RemoveAt(int index)` to delete a key-value pair.
  - **Access**: `TryGetValue(TKey key, out TValue value)`; indexer (`this[TKey key]`) for get.
  - **Update**: Modify via indexer (`list[key] = value`).
  - **Query**: `ContainsKey(TKey key)`, `ContainsValue(TValue value)`, `Count` to check content.
  - **Clear**: `Clear()` to remove all pairs.

## `HashSet<T>`
- **Description**: A collection of unique elements with fast lookup and set operations.
- **Use Case**: Storing unique items or performing set operations like union or intersection.
- **Common Usage**: Deduplication, tracking unique IDs, or membership testing.
- **Basic Operations**:
  - **Add**: `Add(T item)` to insert an item (returns `false` if duplicate).
  - **Remove**: `Remove(T item)` to delete an item.
  - **Access**: No direct indexing; iterate or use `ElementAt(int index)` with LINQ.
  - **Update**: Remove and re-add to modify (no direct update).
  - **Query**: `Contains(T item)`, `Count`, `IsSubsetOf(IEnumerable<T> other)` for set operations.
  - **Clear**: `Clear()` to remove all items.

## `SortedSet<T>`
- **Description**: A set of unique elements maintained in sorted order.
- **Use Case**: Ordered collections of unique items, such as prioritized lists.
- **Common Usage**: Managing sorted unique values like rankings or priorities.
- **Basic Operations**:
  - **Add**: `Add(T item)` to insert an item (returns `false` if duplicate).
  - **Remove**: `Remove(T item)` to delete an item.
  - **Access**: `Min`, `Max`, or iterate to access elements.
  - **Update**: Remove and re-add to modify (no direct update).
  - **Query**: `Contains(T item)`, `Count`, `GetViewBetween(T lower, T upper)` for range queries.
  - **Clear**: `Clear()` to remove all items.

## `Queue<T>`
- **Description**: A first-in, first-out (FIFO) collection.
- **Use Case**: Processing items in the order they were added, like task scheduling.
- **Common Usage**: Job queues, event handling, or sequential processing.
- **Basic Operations**:
  - **Add**: `Enqueue(T item)` to add an item to the end.
  - **Remove**: `Dequeue()` to remove and retrieve the item at the front.
  - **Access**: `Peek()` to retrieve the front item without removing.
  - **Query**: `Count` to get number of items.
  - **Clear**: `Clear()` to remove all items.

## `Stack<T>`
- **Description**: A last-in, first-out (LIFO) collection.
- **Use Case**: Managing items where the most recent addition is processed first, like undo operations.
- **Common Usage**: Backtracking algorithms, call stacks, or history tracking.
- **Basic Operations**:
  - **Add**: `Push(T item)` to add an item to the top.
  - **Remove**: `Pop()` to remove and retrieve the top item.
  - **Access**: `Peek()` to retrieve the top item without removing.
  - **Query**: `Count` to get number of items.
  - **Clear**: `Clear()` to remove all items.

## `LinkedList<T>`
- **Description**: A doubly-linked list where each element points to the next and previous elements.
- **Use Case**: Frequent insertions or deletions in the middle of a sequence.
- **Common Usage**: Playlists, navigation histories, or dynamic sequences.
- **Basic Operations**:
  - **Add**: `AddFirst(T item)`, `AddLast(T item)`, `AddAfter(LinkedListNode<T> node, T item)`, `AddBefore(LinkedListNode<T> node, T item)` to insert items.
  - **Remove**: `Remove(T item)`, `RemoveFirst()`, `RemoveLast()` to delete items.
  - **Access**: `First`, `Last`, or iterate to access nodes.
  - **Update**: Modify node values via `node.Value = newValue`.
  - **Query**: `Contains(T item)`, `Count` to check content.
  - **Clear**: `Clear()` to remove all nodes.

[Click to see code example](../../CodeExamples/CollectionsGeneric.cs)

## Note

 - **Type Safety**: Generic collections ensure compile-time type checking, reducing runtime errors.
 - **Performance**: Optimized for specific scenarios (e.g., `Dictionary<TKey, TValue>` for fast lookups, `LinkedList<T>` for dynamic insertions).
 - **Basic Operations**: The example demonstrates add, remove, access, update, query, and clear operations, using a task management scenario for practical context.
 - **Recommendation**: Use these collections for new code due to their efficiency, type safety, and robust APIs.



# Concurrent Collections

Concurrent collections in the `System.Collections.Concurrent` namespace are designed for thread-safe operations in multi-threaded applications, minimizing the need for explicit locking. Below is a summary of each collection, its common use cases, basic operations (including add, remove, and other fundamental operations like access, update, or query), and an advanced code example demonstrating these operations in a simulated task processing system.

## `ConcurrentDictionary<TKey, TValue>`
- **Description**: A thread-safe dictionary of key-value pairs with unique keys, optimized for concurrent access and updates.
- **Use Case**: Storing key-value data in multi-threaded environments, such as caching or shared state.
- **Common Usage**: Managing shared configurations, counters, or session data across threads.
- **Basic Operations**:
  - **Add**: `TryAdd(TKey key, TValue value)` (adds if key doesn't exist); `AddOrUpdate(TKey key, TValue addValue, Func<TKey, TValue, TValue> updateFactory)` (adds or updates).
  - **Remove**: `TryRemove(TKey key, out TValue value)` (removes and retrieves value).
  - **Access**: `TryGetValue(TKey key, out TValue value)` (retrieves value); indexer (`this[TKey key]`) for get/set.
  - **Update**: `TryUpdate(TKey key, TValue newValue, TValue comparisonValue)` (updates if current value matches).
  - **Query**: `ContainsKey(TKey key)` (checks if key exists); `Count` (gets number of pairs).
  - **Clear**: `Clear()` (removes all pairs).

## `ConcurrentQueue<T>`
- **Description**: A thread-safe first-in, first-out (FIFO) queue.
- **Use Case**: Processing items in the order they were added across multiple threads.
- **Common Usage**: Task queues, event processing, or producer-consumer scenarios.
- **Basic Operations**:
  - **Add**: `Enqueue(T item)` (adds to end).
  - **Remove**: `TryDequeue(out T item)` (removes and retrieves from front; returns `false` if empty).
  - **Access**: `TryPeek(out T item)` (retrieves front item without removing; returns `false` if empty).
  - **Query**: `Count` (gets number of items); `IsEmpty` (checks if queue is empty).
  - **Clear**: `Clear()` (removes all items).

## `ConcurrentStack<T>`
- **Description**: A thread-safe last-in, first-out (LIFO) stack.
- **Use Case**: Managing items where the most recent addition is processed first in a thread-safe manner.
- **Common Usage**: Undo operations or history tracking in concurrent applications.
- **Basic Operations**:
  - **Add**: `Push(T item)`; `PushRange(T[] items)` (adds multiple items to top).
  - **Remove**: `TryPop(out T item)` (removes and retrieves top item; returns `false` if empty); `TryPopRange(T[] items, int startIndex, int count)` (pops multiple).
  - **Access**: `TryPeek(out T item)` (retrieves top item without removing; returns `false` if empty).
  - **Query**: `Count` (gets number of items); `IsEmpty` (checks if stack is empty).
  - **Clear**: `Clear()` (removes all items).

## `ConcurrentBag<T>`
- **Description**: A thread-safe, unordered collection optimized for scenarios where threads primarily add and remove their own items.
- **Use Case**: Storing items without order requirements in multi-threaded environments.
- **Common Usage**: Collecting results from parallel tasks or temporary storage.
- **Basic Operations**:
  - **Add**: `Add(T item)` (adds an item).
  - **Remove**: `TryTake(out T item)` (removes and retrieves an item; returns `false` if empty).
  - **Access**: `TryPeek(out T item)` (retrieves an item without removing; returns `false` if empty).
  - **Query**: `Count` (gets number of items); `IsEmpty` (checks if bag is empty).
  - **Clear**: Not directly supported; must iterate and use `TryTake` to empty.

## `BlockingCollection<T>`
- **Description**: A thread-safe collection supporting bounding and blocking, often wrapping another collection (e.g., `ConcurrentQueue<T>`).
- **Use Case**: Producer-consumer scenarios where threads wait for items or respect capacity limits.
- **Common Usage**: Task pipelines, buffered data processing, or throttled queues.
- **Basic Operations**:
  - **Add**: `Add(T item)` (adds item, blocks if full); `TryAdd(T item)` (non-blocking add).
  - **Remove**: `Take()` (removes and retrieves item, blocks if empty); `TryTake(out T item)` (non-blocking).
  - **Access**: No direct peek; use underlying collection if accessible (e.g., `ConcurrentQueue<T>`).
  - **Query**: `Count` (gets number of items); `IsCompleted` (checks if adding is complete); `BoundedCapacity` (gets max capacity).
  - **Clear**: Not directly supported; use `Take` or underlying collection to empty.

[Click to see code example](../../CodeExamples/CollectionsGeneric.cs)

## Note

 - **Thread Safety**: Concurrent collections ensure safe access and modification in multi-threaded scenarios without manual locks.
 - **Performance**: Optimized for concurrency; ConcurrentBag excels when threads manage their own items, while BlockingCollection supports blocking for producer-consumer patterns.
 - **Basic Operations**: The example highlights add, remove, access, update, query, and clear operations, using Parallel.Invoke and Task to simulate concurrent access.
 - **Recommendation**: Use these collections in multi-threaded applications for thread-safe, efficient data management.


 # Specialized Collections

Specialized collections, located in the `System.Collections.Specialized` namespace, are designed for specific use cases, often providing additional functionality tailored to particular scenarios. These collections can be generic or non-generic and are typically used in legacy code or specific contexts like configuration management or string-based data handling. Below is a summary of each collection, its common use cases, basic operations (including add, remove, access, update, query, and clear), and an advanced code example demonstrating these operations in a configuration and settings management system.

## NameValueCollection
- **Description**: A non-generic collection of key-value pairs where keys are strings, and multiple values can be associated with a single key.
- **Use Case**: Storing configuration settings or query parameters where a key may have multiple values.
- **Common Usage**: Handling HTTP query strings, configuration files, or settings with multiple values per key.
- **Basic Operations**:
  - **Add**: `Add(string name, string value)` to append a value to a key.
  - **Remove**: `Remove(string name)` to delete all values for a key.
  - **Access**: `Get(string name)` to retrieve all values for a key; `GetValues(string name)` for array of values; indexer (`this[string name]`) for get/set.
  - **Update**: Modify via indexer (`collection[name] = value`) to replace all values for a key.
  - **Query**: `AllKeys`, `Count`, `HasKeys()` to check content.
  - **Clear**: `Clear()` to remove all pairs.

## StringCollection
- **Description**: A non-generic collection optimized for storing strings.
- **Use Case**: Managing lists of strings, such as tags or categories, in a type-safe manner for strings.
- **Common Usage**: Storing string-based data like file paths or labels in legacy systems.
- **Basic Operations**:
  - **Add**: `Add(string value)`, `AddRange(string[] values)` to append strings.
  - **Remove**: `Remove(string value)`, `RemoveAt(int index)` to delete strings.
  - **Access**: Indexer (`this[int index]`) to get/set strings; `IndexOf(string value)` to find index.
  - **Update**: Modify via indexer (`collection[index] = value`).
  - **Query**: `Contains(string value)`, `Count` to check content.
  - **Clear**: `Clear()` to remove all strings.

## StringDictionary
- **Description**: A non-generic dictionary where both keys and values are strings.
- **Use Case**: Simple key-value storage for string-based data.
- **Common Usage**: Configuration settings or metadata with string keys and values.
- **Basic Operations**:
  - **Add**: `Add(string key, string value)` to insert a key-value pair.
  - **Remove**: `Remove(string key)` to delete a key-value pair.
  - **Access**: Indexer (`this[string key]`) to get/set values.
  - **Update**: Modify via indexer (`dict[key] = value`).
  - **Query**: `ContainsKey(string key)`, `ContainsValue(string value)`, `Count` to check content.
  - **Clear**: `Clear()` to remove all pairs.

## HybridDictionary
- **Description**: A non-generic dictionary that switches between a `ListDictionary` (for small collections) and a `Hashtable` (for larger collections) for performance optimization.
- **Use Case**: Key-value storage where collection size is unpredictable.
- **Common Usage**: Dynamic configuration or small-to-medium datasets in legacy systems.
- **Basic Operations**:
  - **Add**: `Add(object key, object value)` to insert a key-value pair.
  - **Remove**: `Remove(object key)` to delete a key-value pair.
  - **Access**: Indexer (`this[object key]`) to get/set values.
  - **Update**: Modify via indexer (`dict[key] = value`).
  - **Query**: `Contains(object key)`, `Count`, `Keys`, `Values` to check content.
  - **Clear**: `Clear()` to remove all pairs.

## ListDictionary
- **Description**: A non-generic, lightweight dictionary implemented as a linked list, optimized for small collections.
- **Use Case**: Key-value storage for small datasets where memory efficiency is critical.
- **Common Usage**: Small configuration sets or metadata in legacy applications.
- **Basic Operations**:
  - **Add**: `Add(object key, object value)` to insert a key-value pair.
  - **Remove**: `Remove(object key)` to delete a key-value pair.
  - **Access**: Indexer (`this[object key]`) to get/set values.
  - **Update**: Modify via indexer (`dict[key] = value`).
  - **Query**: `Contains(object key)`, `Count`, `Keys`, `Values` to check content.
  - **Clear**: `Clear()` to remove all pairs.

## OrderedDictionary
- **Description**: A non-generic dictionary that maintains insertion order of key-value pairs.
- **Use Case**: Key-value storage where order of insertion matters.
- **Common Usage**: Sequential configuration or logging where order is significant.
- **Basic Operations**:
  - **Add**: `Add(object key, object value)` to insert a key-value pair.
  - **Remove**: `Remove(object key)`, `RemoveAt(int index)` to delete a key-value pair.
  - **Access**: `GetEnumerator()` or indexer (`this[object key]` or `this[int index]`) to get values.
  - **Update**: Modify via indexer (`dict[key] = value`·ÅÏÂ

System: value` or `dict[index] = value`).
  - **Query**: `Contains(object key)`, `Count`, `Keys`, `Values` to check content.
  - **Clear**: `Clear()` to remove all pairs.

## BitVector32
- **Description**: A structure for manipulating sets of boolean flags or small integers efficiently within a 32-bit integer.
- **Use Case**: Compact storage of flags or small integers in performance-critical scenarios.
- **Common Usage**: Managing feature toggles or bitmasks in legacy systems.
- **Basic Operations**:
  - **Add**: Set bits using `BitVector32[int index] = true` or `Data` property for integer values.
  - **Remove**: No direct remove; set bits to `false` or reset `Data` to 0.
  - **Access**: `BitVector32[int index]` to get/set individual bits; `Data` for the entire value.
  - **Update**: Modify via `BitVector32[int index]` or `Data`.
  - **Query**: `Count`, `Length`, or check individual bits with `BitVector32[int index]`.
  - **Clear**: Set `Data = 0` to reset all bits.

[Click to see code example](../../CodeExamples/CollectionsSpecial.cs)

## Note

 - Type Safety: Most specialized collections are non-generic, requiring casting for non-string types, which may lead to runtime errors.
 - Performance: `ListDictionary` and `HybridDictionary` are optimized for small collections; `BitVector32` is highly efficient for bit-level operations.
 - Basic Operations: The example demonstrates add, remove, access, update, query, and clear operations in a configuration management context.
 - Recommendation: Use generic collections (`System.Collections.Generic`) for new code unless specific functionality (e.g., multiple values per key in `NameValueCollection`) or legacy compatibility is required.


 # Immutable Collections

Immutable collections, available in the `System.Collections.Immutable` namespace (via the `System.Collections.Immutable` NuGet package), are thread-safe and cannot be modified after creation, ensuring data integrity in concurrent or functional programming scenarios. These collections are designed for scenarios where immutability is preferred, creating new instances for modifications rather than altering the original. Below is a summary of each collection, its common use cases, basic operations (including add, remove, access, update, query, and clear), and an advanced code example demonstrating these operations in a task management system.

## `ImmutableList<T>`
- **Description**: An immutable, ordered list of elements.
- **Use Case**: Storing immutable sequences of items, such as task lists or logs, in thread-safe or functional programming contexts.
- **Common Usage**: Maintaining unchangeable collections for data integrity or snapshotting state.
- **Basic Operations**:
  - **Add**: `Add(T item)`, `AddRange(IEnumerable<T> items)` to create a new list with added items.
  - **Remove**: `Remove(T item)`, `RemoveAt(int index)`, `RemoveAll(Predicate<T> match)` to create a new list without specified items.
  - **Access**: Indexer (`this[int index]`) to get items; `ElementAt(int index)` for access.
  - **Update**: `SetItem(int index, T value)` to create a new list with a modified item.
  - **Query**: `Contains(T item)`, `Count`, `IndexOf(T item)` to check content.
  - **Clear**: `Clear()` to create an empty list.

## `ImmutableDictionary<TKey, TValue>`
- **Description**: An immutable collection of key-value pairs with unique keys.
- **Use Case**: Thread-safe key-value storage for immutable lookups, such as configuration or state snapshots.
- **Common Usage**: Caching or mapping IDs to objects in immutable contexts.
- **Basic Operations**:
  - **Add**: `Add(TKey key, TValue value)`, `AddRange(IEnumerable<KeyValuePair<TKey, TValue>> pairs)` to create a new dictionary with added pairs.
  - **Remove**: `Remove(TKey key)`, `RemoveRange(IEnumerable<TKey> keys)` to create a new dictionary without specified keys.
  - **Access**: `TryGetValue(TKey key, out TValue value)`; indexer (`this[TKey key]`) for get.
  - **Update**: `SetItem(TKey key, TValue value)` to create a new dictionary with a modified value.
  - **Query**: `ContainsKey(TKey key)`, `Count`, `Keys`, `Values` to check content.
  - **Clear**: `Clear()` to create an empty dictionary.

## `ImmutableSortedDictionary<TKey, TValue>`
- **Description**: An immutable dictionary with keys maintained in sorted order.
- **Use Case**: Immutable key-value storage requiring sorted iteration.
- **Common Usage**: Sorted configuration settings or ordered data snapshots.
- **Basic Operations**:
  - **Add**: `Add(TKey key, TValue value)`, `AddRange(IEnumerable<KeyValuePair<TKey, TValue>> pairs)` to create a new sorted dictionary.
  - **Remove**: `Remove(TKey key)`, `RemoveRange(IEnumerable<TKey> keys)` to create a new dictionary without specified keys.
  - **Access**: `TryGetValue(TKey key, out TValue value)`; indexer (`this[TKey key]`) for get.
  - **Update**: `SetItem(TKey key, TValue value)` to create a new dictionary with a modified value.
  - **Query**: `ContainsKey(TKey key)`, `Count`, `Keys`, `Values` to check content.
  - **Clear**: `Clear()` to create an empty dictionary.

## `ImmutableHashSet<T>`
- **Description**: An immutable collection of unique elements with fast lookup.
- **Use Case**: Storing unique items immutably, such as deduplicated lists or tags.
- **Common Usage**: Maintaining immutable sets for thread-safe operations or functional programming.
- **Basic Operations**:
  - **Add**: `Add(T item)`, `Union(IEnumerable<T> items)` to create a new set with added items.
  - **Remove**: `Remove(T item)`, `Except(IEnumerable<T> items)` to create a new set without specified items.
  - **Access**: `ElementAt(int index)` (with LINQ) or iterate to access elements.
  - **Update**: Remove and re-add to modify (no direct update).
  - **Query**: `Contains(T item)`, `Count`, `IsSubsetOf(IEnumerable<T> other)` for set operations.
  - **Clear**: `Clear()` to create an empty set.

## `ImmutableSortedSet<T>`
- **Description**: An immutable set of unique elements maintained in sorted order.
- **Use Case**: Ordered, unique collections, such as prioritized or ranked items.
- **Common Usage**: Managing sorted unique values like priorities or rankings immutably.
- **Basic Operations**:
  - **Add**: `Add(T item)`, `Union(IEnumerable<T> items)` to create a new set with added items.
  - **Remove**: `Remove(T item)`, `Except(IEnumerable<T> items)` to create a new set without specified items.
  - **Access**: `Min`, `Max`, or iterate to access elements.
  - **Update**: Remove and re-add to modify (no direct update).
  - **Query**: `Contains(T item)`, `Count`, `GetViewBetween(T lower, T upper)` for range queries.
  - **Clear**: `Clear()` to create an empty set.

## `ImmutableQueue<T>`
- **Description**: An immutable first-in, first-out (FIFO) queue.
- **Use Case**: Processing items in order of addition in an immutable, thread-safe manner.
- **Common Usage**: Immutable task queues or event logs.
- **Basic Operations**:
  - **Add**: `Enqueue(T item)` to create a new queue with an added item.
  - **Remove**: `Dequeue()` to create a new queue without the front item (returns item).
  - **Access**: `Peek()` to retrieve the front item without removing.
  - **Query**: `Count`, `IsEmpty` to check content.
  - **Clear**: `Clear()` to create an empty queue.

## `ImmutableStack<T>`
- **Description**: An immutable last-in, first-out (LIFO) stack.
- **Use Case**: Managing items where the most recent addition is processed first, immutably.
- **Common Usage**: Undo operations or history tracking in immutable contexts.
- **Basic Operations**:
  - **Add**: `Push(T item)` to create a new stack with an added item.
  - **Remove**: `Pop()` to create a new stack without the top item (returns item).
  - **Access**: `Peek()` to retrieve the top item without removing.
  - **Query**: `Count`, `IsEmpty` to check content.
  - **Clear**: `Clear()` to create an empty stack.

## `ImmutableArray<T>`
- **Description**: An immutable, fixed-size array with efficient memory usage.
- **Use Case**: Storing a fixed collection of items immutably, with array-like access.
- **Common Usage**: Snapshots of data or immutable buffers.
- **Basic Operations**:
  - **Add**: `Add(T item)`, `AddRange(IEnumerable<T> items)` to create a new array (via builder or conversion).
  - **Remove**: `RemoveAt(int index)`, `Remove(T item)` to create a new array without specified items.
  - **Access**: Indexer (`this[int index]`) to get items; `ElementAt(int index)` for access.
  - **Update**: `SetItem(int index, T value)` to create a new array with a modified item.
  - **Query**: `Contains(T item)`, `Count`, `IndexOf(T item)` to check content.
  - **Clear**: `Clear()` to create an empty array.
	 
[Click to see code example](../../CodeExamples/CollectionsImmutable.cs)
	
## Notes

 - Immutability: Operations return new instances, leaving the original collection unchanged, ensuring thread safety and data integrity.
 - Performance: Optimized for immutability; use builders (e.g., `ImmutableList<T>.Builder`) for bulk modifications to improve efficiency.
 - Basic Operations: The example demonstrates add, remove, access, update, query, and clear operations in a task management context.
 - NuGet Dependency: Requires the `System.Collections.Immutable` NuGet package.
 - Recommendation: Use immutable collections in scenarios requiring thread safety, functional programming, or data integrity guarantees.


 # Other Notable Collections

The following collections, while not part of the `System.Collections` or `System.Collections.Generic` namespaces, are significant in C# for specific use cases. These include the basic `Array`, the `KeyedCollection<TKey, TItem>` from `System.Collections.ObjectModel`, and the `ObservableCollection<T>` from the same namespace. Below is a summary of each collection, its common use cases, basic operations (including add, remove, access, update, query, and clear), and an advanced code example demonstrating these operations in a task management system.

## `Array (T[])`
- **Description**: A fixed-size, type-safe array of elements, part of the core C# language.
- **Use Case**: Storing a fixed number of items with fast, index-based access.
- **Common Usage**: Static data storage, such as configuration arrays or fixed-size buffers.
- **Basic Operations**:
  - **Add**: Not directly supported; initialize with fixed size or use array resizing (`Array.Resize`).
  - **Remove**: Not directly supported; create a new array or set elements to `null`/default.
  - **Access**: Indexer (`this[int index]`) to get/set elements.
  - **Update**: Modify via indexer (`array[index] = value`).
  - **Query**: `Length`, `Contains` (via LINQ), or iterate to check content.
  - **Clear**: `Array.Clear(array, int index, int length)` to set elements to default values.

## `KeyedCollection<TKey, TItem>`
- **Description**: An abstract base class in `System.Collections.ObjectModel` for collections where items are indexed by a key embedded in the item, requiring implementation of `GetKeyForItem`.
- **Use Case**: Storing items with embedded keys for lookup, bridging lists and dictionaries.
- **Common Usage**: Managing collections where items have a unique identifier, such as database records.
- **Basic Operations**:
  - **Add**: `Add(TItem item)`, `AddRange(IEnumerable<TItem> items)` to append items.
  - **Remove**: `Remove(TKey key)`, `RemoveAt(int index)` to delete items.
  - **Access**: Indexer (`this[TKey key]` or `this[int index]`) to get items.
  - **Update**: Modify via indexer (`collection[key] = item`) or direct item modification.
  - **Query**: `Contains(TKey key)`, `Count`, `Contains(TItem item)` to check content.
  - **Clear**: `Clear()` to remove all items.

## `ObservableCollection<T>`
- **Description**: A generic collection in `System.Collections.ObjectModel` that provides notifications when items are added, removed, or modified, commonly used in data-binding scenarios (e.g., WPF, MAUI).
- **Use Case**: Dynamic collections with automatic UI updates in data-binding frameworks.
- **Common Usage**: Binding to UI elements like lists or grids in desktop or mobile applications.
- **Basic Operations**:
  - **Add**: `Add(T item)` to append an item (triggers `CollectionChanged`).
  - **Remove**: `Remove(T item)`, `RemoveAt(int index)` to delete items (triggers `CollectionChanged`).
  - **Access**: Indexer (`this[int index]`) to get/set items.
  - **Update**: Modify via indexer (`collection[index] = item`) or direct item modification (triggers `PropertyChanged` if item implements `INotifyPropertyChanged`).
  - **Query**: `Contains(T item)`, `Count`, `IndexOf(T item)` to check content.
  - **Clear**: `Clear()` to remove all items (triggers `CollectionChanged`).

[Click to see code example](../../CodeExamples/CollectionsOthers.cs)

## Notes

 - Type Safety: `Array` and `ObservableCollection<T>` are type-safe; `KeyedCollection<TKey, TItem>` is generic and requires a key extraction implementation.
 - Performance: `Array` is highly efficient for fixed-size data; `KeyedCollection` balances list and dictionary access; `ObservableCollection` incurs overhead due to change notifications.
 - Basic Operations: The example demonstrates add, remove, access, update, query, and clear operations, with `ObservableCollection` showcasing change notifications for data-binding.
 - Recommendation: Use `Array` for fixed-size data, `KeyedCollection` for key-based lists, and `ObservableCollection` for UI-bound dynamic collections in frameworks like WPF or MAUI.
