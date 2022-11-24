using System.Linq.Expressions;

namespace AWildSolutions.Zootah.GiftStore.API.Interfaces;

public interface IRepository<T> where T : class
{
    public IEnumerable<T> Get(Expression<Func<T, bool>> filter);
    public IEnumerable<T> GetAll();
    public IEnumerable<T> Get(
        Expression<Func<T, bool>> filter, 
        Func<IQueryable<T>, IOrderedQueryable<T>>? orderBy);
    public IEnumerable<T> Get(
        List<Expression<Func<T, bool>>> filter, 
        Func<IQueryable<T>, IOrderedQueryable<T>>? orderBy);

    public T? GetById(object id);
}