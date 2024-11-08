using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;
using Sgt.Application.Repository;
using MongoDB.Driver;
using MongoDB.Bson;

namespace Sgt.Persistence.Generic;

public class GenericRepository<T> : IGenericRepository<T> where T : class
{
    private readonly IMongoCollection<T> _collection;


    public GenericRepository(IMongoDatabase database)
    {
        _collection = database.GetCollection<T>(typeof(T).Name.Replace("Entity",""));
    }

    public T Add(T entity)
    {
        _collection.InsertOne(entity);
        return entity;
    }

    public async Task<T> AddAsync(T entity, CancellationToken cancellationToken = default)
    {
        await _collection.InsertOneAsync(entity, cancellationToken);
        return entity;
    }

    public void AddRange(IEnumerable<T> entities)
    {
        _collection.InsertMany(entities);
    }

    public async Task AddRangeAsync(IEnumerable<T> entities, CancellationToken cancellationToken = default)
    {
        await _collection.InsertManyAsync(entities);
    }

    public T Get(Expression<Func<T, bool>> expression)
    {
        return _collection.Find(expression).FirstOrDefault();
    }

    public IEnumerable<T> GetAll()
    {
        return _collection.Find(new BsonDocument()).ToList();
    }

    public IEnumerable<T> GetAll(Expression<Func<T, bool>> expression)
    {
        return _collection.Find(expression).ToList();
    }

    public async Task<IEnumerable<T>> GetAllAsync(CancellationToken cancellationToken = default)
    {
        return await _collection.Find(new BsonDocument()).ToListAsync();
    }

    public async Task<IEnumerable<T>> GetAllAsync(Expression<Func<T, bool>> expression, CancellationToken cancellationToken = default)
    {
        return await _collection.Find(expression).ToListAsync();
    }

    public async Task<T> GetAsync(Expression<Func<T, bool>> expression, CancellationToken cancellationToken = default)
    {
        return await _collection.Find(expression).FirstOrDefaultAsync();
    }

    public void Remove(string id)
    {
        _collection.DeleteOne(Builders<T>.Filter.Eq("_id", new ObjectId(id)));
    }

    public void RemoveRange(string[] ids)
    {
        _collection.DeleteMany(Builders<T>.Filter.In("_id", ids));
    }

    public T Update(string id, T entity)
    {
       var result = _collection.ReplaceOne(Builders<T>.Filter.Eq("_id", new ObjectId(id)), entity);
        return entity;
    }

    public void UpdateRange(IEnumerable<T> entities)
    {
        throw new NotImplementedException();
    }
}
