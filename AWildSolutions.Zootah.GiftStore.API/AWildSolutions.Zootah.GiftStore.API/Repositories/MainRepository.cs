using System.IO.Enumeration;
using System.Linq.Expressions;
using AWildSolutions.Zootah.GiftStore.API.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace AWildSolutions.Zootah.GiftStore.API.Repositories;

public abstract class MainRepository<T> : IRepository<T> where T : class
{
    protected DbContext Context = null!;
    protected DbSet<T> DbSet = null!;
    
    public IEnumerable<T> Get(Expression<Func<T, bool>> filter) => DbSet.Where(filter).ToList();
    public IEnumerable<T> GetAll() => DbSet.ToList();

    public IEnumerable<T> Get(Expression<Func<T, bool>> filter, Func<IQueryable<T>, IOrderedQueryable<T>>? orderBy)
    {
        IQueryable<T> query = DbSet.Where(filter);

        return orderBy is not null ? orderBy(query).ToList() : query.ToList();
    }

    public IEnumerable<T> Get(List<Expression<Func<T, bool>>> filter, Func<IQueryable<T>, IOrderedQueryable<T>>? orderBy)
    {
        IQueryable<T> query = filter.Aggregate<Expression<Func<T, bool>>?, 
            IQueryable<T>>(DbSet, (current, f) => 
            current.Where(f));

        return orderBy is not null ? orderBy(query).ToList() : query.ToList();
    }

    public T? GetById(object id) => DbSet.Find(id);
}