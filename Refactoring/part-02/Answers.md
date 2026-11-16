# Part 02 — answers

---

## Reports

- What was the problem?

The three report exporters had duplicated code for loading, validating, and saving reports. This made the code harder to maintain because changes to the common workflow had to be repeated in multiple classes.

- What did you change?

I created an abstract base class called `ReportExporter` that contains the shared export workflow. The three exporters inherit from it and implement only their own formatting logic.

- Why did you choose that approach?

I chose the Template Method pattern because the three exporters follow the same sequence of steps but differ in how they format the data. This allows the common workflow to be implemented once while keeping the different formatting behaviors in separate classes.

---

## Enrollment

- What was the problem?

`Program.cs` was responsible for creating four services and calling them individually in the correct order. This exposed the enrollment workflow details to the caller and made the program more dependent on the individual services.


- What did you change?

I created an `EnrollmentFacade` class with an `EnrollStudent()` method. It creates the required services and coordinates their execution. Now, `Program.cs` only needs to call this single method.

- Why did you choose that approach?

I chose the Facade pattern because it provides a simple interface for a complex workflow. It hides the internal services and their execution order from the caller, making the code simpler and reducing dependencies.
