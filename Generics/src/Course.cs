namespace Generics;

public class Course : IHasId
{
    public int Id { get; }
    public string Name { get; }

    public Course(int id, string name)
    {
        Id = id;
        Name = name;
    }
}