using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace Crm.DataAccess.Abstract
{
    public interface IRepository<T>
    {
        void Insert(T entity);
        void Update(T entity);
        void Delete(T entity);
        List<T> GetAll(Expression<Func<T, bool>> filter = null);
        T GetByFilter(Expression<Func<T, bool>> filter);
    }
}
