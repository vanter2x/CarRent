using System;
using System.Linq;
using System.Linq.Expressions;
using CarRent.Models;

namespace CarRent.Services
{
    public interface IRepositoryService<T> where T : IEntity<int>
    {
        IQueryable<T> GetAll();
        T GetSingle(int id);
        IQueryable<T> FindBy(Expression<Func<T, bool>> predicate);
        ServiceResult Add(T entity);
        ServiceResult Edit(T entity);
        ServiceResult Delete(T entity);
        ServiceResult Save();
    }
}