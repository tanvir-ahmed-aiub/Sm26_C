using IntroEFDbFirst.EF;
using Microsoft.AspNetCore.Mvc;

namespace IntroEFDbFirst.Controllers
{
    public class StudentController : Controller
    {
        Sm26CContext db;
        //resolving depency
        public StudentController(Sm26CContext db)
        {
            this.db = db;
        }

        public IActionResult Index()
        {
            return View();
        }
    }
}
