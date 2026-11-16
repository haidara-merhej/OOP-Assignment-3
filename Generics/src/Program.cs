using Generics;

Store<Student> studentStore = new Store<Student>();
studentStore.Add(new Student(1, "Ahmed"));
studentStore.Add(new Student(2, "Ali"));

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
courseStore.Add(new Course(1, "OOP"));
courseStore.Add(new Course(2, "C# Advanced"));

Console.WriteLine("Courses:");

foreach(var course in courseStore.GetAll())
{
    Console.WriteLine($"Id: {course.Id}, Name: {course.Name}");
}

int courseId = 2;
Course? course1 = courseStore.GetById(courseId);

if(course1 is null)
    Console.WriteLine($"Course with id = {courseId} not found");
else
    Console.WriteLine($"Course with id = {courseId} found");