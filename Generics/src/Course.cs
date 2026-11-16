namespace Generics;

public class Course : IHasId
{
    public int Id { get; }
    public string Titel { get; }
    public decimal Price { get; }

    public Course(int id, string title, decimal price)
    {
        Id = id;
        Titel = title;
        Price = price;
    }
}