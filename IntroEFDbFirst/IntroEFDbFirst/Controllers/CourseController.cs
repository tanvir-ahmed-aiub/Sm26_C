using IntroEFDbFirst.EF;
using Microsoft.AspNetCore.Mvc;

namespace IntroEFDbFirst.Controllers
{
    public class CourseController : Controller
    {
        Sm26CContext db;
        public CourseController(Sm26CContext db)
        {
            this.db = db;
        }

        public IActionResult Index()
        {
            return View();
        }
    }
}
