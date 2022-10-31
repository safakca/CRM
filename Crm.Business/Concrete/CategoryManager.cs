using Crm.Business.Abstract;
using Crm.DataAccess.Abstract;
using Crm.Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace Crm.Business.Concrete
{
    public class CategoryManager : ICategoryService
    {
        private readonly ICategoryDal _categoryDal;

        public CategoryManager(ICategoryDal categoryDal)
        {
            _categoryDal = categoryDal;
        }

        public void TDelete(Category entity)
        {
            _categoryDal.Delete(entity);
        }

        public List<Category> TGetAll(Expression<Func<Category, bool>> filter = null)
        {
            return filter==null ? _categoryDal.GetAll() : _categoryDal.GetAll(filter);
        }

        public Category TGetByFilter(Expression<Func<Category, bool>> filter)
        {
            return _categoryDal.GetByFilter(filter);
        }

        public void TInsert(Category entity)
        {
            // if(entity.Name != null && entity.Name.Length >= 5 && entity.Description.StartsWith("A"))
            _categoryDal.Insert(entity); 
        }

        public void TUpdate(Category entity)
        {
            _categoryDal.Update(entity);
        }
    }
}
