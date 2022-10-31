using Crm.Business.Abstract;
using Crm.DataAccess.Abstract;
using Crm.Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace Crm.Business.Concrete
{
    public class ProductManager : IProductService
    {
        private readonly IProductDal _productDal;

        public ProductManager(IProductDal productDal)
        {
            _productDal = productDal;
        }

        public void TDelete(Product entity)
        {
            _productDal.Delete(entity);
        }

        public List<Product> TGetAll(Expression<Func<Product, bool>> filter = null)
        {
            return filter == null ? _productDal.GetAll() : _productDal.GetAll(filter);
        }

        public Product TGetByFilter(Expression<Func<Product, bool>> filter)
        {
            return _productDal.GetByFilter(filter);
        }

        public void TInsert(Product entity)
        {
            _productDal.Insert(entity);
        }

        public void TUpdate(Product entity)
        {
            _productDal.Update(entity);
        }
    }
}
