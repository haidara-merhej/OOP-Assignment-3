using Generics;

Store<Student> studentStore = new Store<Student>();
studentStore.Add(new Student(1, "Ahmed"));
studentStore.Add(new Student(2, "Ali"));
studentStore.Add(new Student(3, "Omar"));
studentStore.Add(new Student(4, "Mona"));
studentStore.Add(new Student(5, "Sara"));

Console.WriteLine("Students:");

foreach(var student in studentStore.GetAll())
{
    Console.WriteLine($"Id: {student.Id}, Name: {student.Name}");
}
int studentId = 2;
Student? student1 = studentStore.GetById(studentId);

if(student1 is null)
    Console.WriteLine($"Student with id = {studentId} not found");
else
    Console.WriteLine($"Student with id = {studentId} found");

Console.WriteLine();

Store<Course> courseStore = new Store<Course>();
courseStore.Add(new Course(1, "OOP", 100.00m));
courseStore.Add(new Course(2, "C# Advanced", 150.00m));
courseStore.Add(new Course(3, "Data Structures", 120.00m));

Console.WriteLine("Courses:");

foreach(var course in courseStore.GetAll())
{
    Console.WriteLine($"Id: {course.Id}, Title: {course.Titel}, Price: {course.Price:C}");
}

int courseId = 2;
Course? course1 = courseStore.GetById(courseId);

if(course1 is null)
    Console.WriteLine($"Course with id = {courseId} not found");
else
    Console.WriteLine($"Course with id = {courseId} found");


try
{
    studentStore.Add(new Student(2, "Khaled"));
}
catch(InvalidOperationException ex)
{
    Console.WriteLine($"\nError: {ex.Message}");
}

Console.WriteLine("\nPage 2:");

foreach(var student in studentStore.GetAll().Page(2, 2))
{
    Console.WriteLine($"Id: {student.Id}, Name: {student.Name}");
}

// must not compile
//var invalidStore = new Store<string>();