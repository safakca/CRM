using Crm.DataAccess.Abstract;
using Crm.DataAccess.Concrete;
using Crm.DataAccess.Repository;
using Crm.Entity.Concrete;

namespace Crm.DataAccess.EntityFramework
{
    public class EfProductDal : GenericRepository<Product>, IProductDal
    {
        public EfProductDal(Context context) : base(context)
        {
        }

        public void GetProductByCategory()
        {
            throw new System.NotImplementedException();
        }
    }
}
