using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace Crm.Business.Abstract
{
    public interface IGenericService<T>
    {
        void TInsert(T entity);
        void TUpdate(T entity);
        void TDelete(T entity);
        List<T> TGetAll(Expression<Func<T, bool>> filter = null);
        T TGetByFilter(Expression<Func<T, bool>> filter);
    }
}
