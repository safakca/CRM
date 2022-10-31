using Crm.DataAccess.Abstract;
using Microsoft.AspNetCore.Mvc;

namespace Crm.UI.Controllers
{
    public class CustomerController : Controller
    {
        private readonly ICategoryDal _categoryDal;

        public CustomerController(ICategoryDal categoryDal)
        {
            _categoryDal = categoryDal;
        }

        public IActionResult Index()
        {
            var result = _categoryDal.GetAll();
            return View(result);
        }
    }
}
