# Part 02 - Collection & Extension Methods

## Task 2.1 - Research

### IReadOnlyDictionary<TKey,TValue>

`IReadOnlyDictionary<TKey, TValue>` is a generic interface that represent a collection of key-value pairs. 
It allows reading and accessing elements wihout providing methods to add, remove, or modify entries.

**Main Features:**

- Inherits from `IReadOnlyCollection<KeyValuePair<TKey, TValue>>`
- Supports iteration using `foreach`.
- Provides access to `Keys`, `Values` and `Count`.
- Provides `ContainsKey()` and `TryGetValue()` methods.
- Does not expose methods for adding or removing elements.

**When should we use it?**

It is useful when returning a dictionary from a class or service while allowing consumers to read its data without providing them with modification methods.

---

### SortedDictionary<TKey,TValue>

`SortedDictionary<TKey, TValue>` is a generic collection that stores the key-value pairs and automatically maintains them in sorted order based on their keys.

**Main Features:**

- Stores elements as `KeyValuePair<TKey, TValue>`.
- Uses a self-balancing binary search tree (Red-Black Tree).
- Sorts keys using `IComparer<TKey>`.
- Uses ascending order by default.
- Supports searching, adding, and removing elements in `O(log n)` time.

**When should we use it?**

It is useful when we need to store key-value pairs while keeping their keys sorted automatically, such as storing student records by student Id.

## Task 2.2 - Pick the Collection

### S1

**Collection:** `Dictionary`

**Reason:** It provides fast lookups using a key, making it suitable for finding a student by their National ID.

### S2

**Collection:** `HashSet`

**Reason:** It prevents duplicate elements, ensuring that each course tag is stored only once.

### S3

**Collection:** `List`

**Reason:** It preserves the insertion order and allows duplicate elements.

### S4

**Collection:** `IReadOnlyDictionary`

**Reason:** It allows caller to read key-value pairs without exposing methods to add or remove entries.

### S5

**Collection:** `SortedDictionary`

**Reason:** It automatically keeps elements sorted by thier keys, which in this case are the session start times.

### S6

**Collection:** `IEnumerable`

**Reason:** It allows the caller to iterate over results using `foreach` and stop early without requiring the entire collection to be stored or processed at once.