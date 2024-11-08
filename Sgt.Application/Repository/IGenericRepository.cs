﻿using System.Linq.Expressions;

namespace Sgt.Application.Repository;

public interface IGenericRepository<T> where T : class
{
    T Get(Expression<Func<T, bool>> expression);
    IEnumerable<T> GetAll();
    IEnumerable<T> GetAll(Expression<Func<T, bool>> expression);
    T Add(T entity);
    void AddRange(IEnumerable<T> entities);
    void Remove(string id);
    void RemoveRange(string[] ids);
    T Update(string id, T entity);
    void UpdateRange(IEnumerable<T> entities);
    Task<T> GetAsync(Expression<Func<T, bool>> expression, CancellationToken cancellationToken = default);
    Task<IEnumerable<T>> GetAllAsync(CancellationToken cancellationToken = default);
    Task<IEnumerable<T>> GetAllAsync(Expression<Func<T, bool>> expression, CancellationToken cancellationToken = default);
    Task<T> AddAsync(T entity, CancellationToken cancellationToken = default);
    Task AddRangeAsync(IEnumerable<T> entities, CancellationToken cancellationToken = default);
}
