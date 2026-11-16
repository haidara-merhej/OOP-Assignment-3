# Part 03 — answers

---

## BlockedUsers

- Time complexity before:

`O(R x B)` - Each request id is checked using `List.Contains()`, which takes `O(B)` time.

- Time (ms) before:

28 ms

- What did you change?

I converted the `blockedIds` list into a `HashSet<int>` and used `HashSet.Contains()` to check each request Id.
The found count remained unchanged at 5,000

- Time complexity after:

`O(B + R)` - Building the HashSet takes `O(B)` and checking all request ids takes `O(R)` on average.

- Time (ms) after:

2 ms

---

## Students

- What was the problem?

`GetAllStudents()` created one million Student objects and stored them in a list, even though the caller only printed the first three students.

- What did you change?

I changed the return type from `List<Student>` to `IEnumerable<Student>` and used `yield return` to generate students one at a time. this ensures that only the requested students are created, and the remaining students are not created when iteration stops.
