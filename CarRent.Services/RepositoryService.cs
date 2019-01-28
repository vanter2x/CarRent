using System;
using System.Linq;
using System.Linq.Expressions;
using CarRent.Models;
using Microsoft.EntityFrameworkCore;

namespace CarRent.Services
{
    public class RepositoryService<T> : IRepositoryService<T> where T : class, IEntity<int>
    {
        protected IDbContext _context;
        protected DbSet<T> _set;

        public RepositoryService(IDbContext context)
        {
            _context = context;
            _set = (_context as DbContext).Set<T>();
        }

        public virtual ServiceResult Add(T entity)
        {
            ServiceResult result = new ServiceResult();

            try
            {
                _set.Add(entity);
                result = Save();
            }
            catch (Exception e)
            {
                result.ResultStatus = ServiceResultStatus.Error;
                result.Messages.Add(e.Message);
            }

            return result;
        }

        public virtual ServiceResult Delete(T entity)
        {

            ServiceResult result = new ServiceResult();

            try
            {
                _set.Remove(entity);
                result = Save();
            }
            catch (Exception e)
            {
                result.ResultStatus = ServiceResultStatus.Error;
                result.Messages.Add(e.Message);
            }

            return result;
        }

        public virtual ServiceResult Edit(T entity)
        {

            ServiceResult result = new ServiceResult();

            try
            {
                //(_context as DbContext).Entry(entity).State = EntityState.Modified;
                _set.Update(entity);
                result = Save();
            }
            catch (Exception e)
            {
                result.ResultStatus = ServiceResultStatus.Error;
                result.Messages.Add(e.Message);
            }

            return result;
        }

        public virtual IQueryable<T> FindBy(Expression<Func<T, bool>> predicate)
        {
            return _set.Where(predicate);
        }

        public virtual IQueryable<T> GetAll()
        {
            return _set;
        }

        public virtual T GetSingle(int id)
        {
            return _set.FirstOrDefault(x => x.Id == id);
        }

        public virtual ServiceResult Save()
        {
            ServiceResult result = new ServiceResult();

            try
            {
                ((DbContext)_context).SaveChanges();
            }
            catch (Exception e)
            {
                result.ResultStatus = ServiceResultStatus.Error;
                result.Messages.Add(e.Message);
            }

            return result;
        }
    }
}