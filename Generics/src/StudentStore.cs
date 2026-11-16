namespace Generics;

public class StudentStore
{
    private readonly List<Student> _students = [];

    public void Add(Student student)
    {
        _students.Add(student);
    }

    public IReadOnlyList<Student> GetAll() => _students;

    public Student? GetById(int id)
    {
        foreach(var student in _students)
        {
            if(student.Id == id)
                return student;
        }

        return null;
    }

    public void Remove(int id)
    {
        Student? student = GetById(id);

        if(student is not null)
            _students.Remove(student);
    }
}