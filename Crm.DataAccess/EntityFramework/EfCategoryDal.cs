using Crm.DataAccess.Abstract;
using Crm.DataAccess.Concrete;
using Crm.DataAccess.Repository;
using Crm.Entity.Concrete;

namespace Crm.DataAccess.EntityFramework
{
    public class EfCategoryDal : GenericRepository<Category>, ICategoryDal
    {
        public EfCategoryDal(Context context) : base(context)
        {
        }
    }
}
