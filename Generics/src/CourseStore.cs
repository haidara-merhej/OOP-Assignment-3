namespace Generics;

public class CourseStore
{
     private readonly List<Course> _courses = [];

    public void Add(Course course)
    {
        _courses.Add(course);
    }

    public IReadOnlyList<Course> GetAll() => _courses;

    public Course? GetById(int id)
    {
        foreach(var course in _courses)
        {
            if(course.Id == id)
                return course;
        }

        return null;
    }

    public void Remove(int id)
    {
        Course? course = GetById(id);

        if(course is not null)
            _courses.Remove(course);
    }
}