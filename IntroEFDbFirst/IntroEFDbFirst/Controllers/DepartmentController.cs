using IntroEFDbFirst.EF;
using Microsoft.AspNetCore.Mvc;

namespace IntroEFDbFirst.Controllers
{
    public class DepartmentController : Controller
    {
        Sm26CContext db;
        public DepartmentController(Sm26CContext db)
        {
            this.db = db;
        }

        public IActionResult Index()
        {
            return View();
        }
    }
}
