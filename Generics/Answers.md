# Generics — One Store for Every Type

## What is the same between StudentStore and CourseStore, and what is different?

**Same:**

Both stores have the same behaviors and operations (`Add`, `GetById`, `GetAll`, and `Remove`).
They also use the same logic to implement these operations.

**Different:**

The only difference is the data type they work with. 
`StudentStore` works with `Student` objects, while `CourseStore` works with `Course` objects. 
Each type has its own properties.
