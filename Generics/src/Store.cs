namespace Generics;

public class Store<T>
{
     private readonly List<T> _entities = [];

    public void Add(T entity)
    {
        _entities.Add(entity);
    }

    public IReadOnlyList<T> GetAll() => _entities;

    public T? GetById(int id)
    {
        foreach(var entity in _entities)
        {
            if(entity.Id == id)
                return entity;
        }

        return null;
    }

    public void Remove(int id)
    {
        T? entity = GetById(id);

        if(entity is not null)
            _entities.Remove(entity);
    }
}