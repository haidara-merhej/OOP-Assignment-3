namespace Generics;

public class Store<T> where T : IHasId
{
     private readonly Dictionary<int, T> _entities = [];

    public void Add(T entity)
    {
        if(_entities.ContainsKey(entity.Id))
            throw new InvalidOperationException($"An entity with id = {entity.Id} already exists");

        _entities[entity.Id] = entity;
    }

    public IReadOnlyCollection<T> GetAll() => _entities.Values;

    public T? GetById(int id)
    {
        if(_entities.TryGetValue(id, out T? entity))
                return entity;

        return default(T);
    }

    public void Remove(int id)
    {
        _entities.Remove(id);
    }
}