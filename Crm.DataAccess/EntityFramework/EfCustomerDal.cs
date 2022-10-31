using Crm.DataAccess.Abstract;
using Crm.DataAccess.Concrete;
using Crm.DataAccess.Repository;
using Crm.Entity.Concrete;

namespace Crm.DataAccess.EntityFramework
{
    public class EfCustomerDal : GenericRepository<Customer>, ICustomerDal
    {
        public EfCustomerDal(Context context) : base(context)
        {
        }
    }
}
