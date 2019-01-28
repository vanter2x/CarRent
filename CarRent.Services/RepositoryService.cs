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
            throw new NotImplementedException();
        }

        public virtual ServiceResult Delete(T entity)
        {
            throw new NotImplementedException();
        }

        public virtual ServiceResult Edit(T entity)
        {
            throw new NotImplementedException();
        }

        public virtual IQueryable<T> FindBy(Expression<Func<T, bool>> predicate)
        {
            throw new NotImplementedException();
        }

        public virtual IQueryable<T> GetAll()
        {
            throw new NotImplementedException();
        }

        public virtual T GetSingle(int id)
        {
            throw new NotImplementedException();
        }

        public virtual ServiceResult Save()
        {
            ServiceResult result = new ServiceResult();

            try
            {
                ((DbContext) _context).SaveChanges();
            }
            catch (Exception e)
            {
                result.ResultStatus = ServiceResultStatus.Error;
                result.Messages.Add(e.Message);
            }
        
        }
    }
}