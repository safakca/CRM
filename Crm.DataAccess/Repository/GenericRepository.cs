using Crm.DataAccess.Abstract;
using Crm.DataAccess.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;

namespace Crm.DataAccess.Repository
{
    public class GenericRepository<T> : IRepository<T> where T : class
    {
        private readonly Context _context;

        public GenericRepository(Context context)
        {
            _context = context;
        }
        public void Insert(T entity)
        {
            _context.Add(entity);
            _context.SaveChanges(); 
        }
        public void Update(T entity)
        {
            _context.Update(entity);
            _context.SaveChanges();
        }
        public void Delete(T entity)
        {
            _context.Remove(entity);
            _context.SaveChanges();
        }

        public List<T> GetAll(Expression<Func<T, bool>> filter = null)
        {
            return filter==null ? _context.Set<T>().ToList() : _context.Set<T>().Where(filter).ToList();
        }

        public T GetByFilter(Expression<Func<T, bool>> filter)
        {
            return _context.Set<T>().SingleOrDefault(filter);
        } 

    }
}
