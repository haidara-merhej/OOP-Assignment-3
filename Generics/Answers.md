# Generics — One Store for Every Type

## Step 2 - What is the same between StudentStore and CourseStore, and what is different?

**Same:**

Both stores have the same behaviors and operations (`Add`, `GetById`, `GetAll`, and `Remove`).
They also use the same logic to implement these operations.

**Different:**

The only difference is the data type they work with. 
`StudentStore` works with `Student` objects, while `CourseStore` works with `Course` objects. 
Each type has its own properties.

## Step 3 — One class for both

**Compile Error:** 'T' does not contain a definition for 'Id' and no accessible extension method 'Id' accepting a first argument of type 'T' could be found (are you missing a using directive or an assembly reference?)

### Why does the compiler reject GetById?

The compiler does not know whether the generic type T has an Id property or not.

Since T can represent any data type, the compiler cannot guarantee that accessing T.Id is valid.

## Step 7 — Why does Store<string> not compile?

Store<T> requires T to implement the IHasId interface.

The string type does not implement IHasId, so it does not satisfy the generic constraint.
