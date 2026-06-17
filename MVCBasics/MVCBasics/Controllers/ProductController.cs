using Microsoft.AspNetCore.Mvc;

namespace MVCBasics.Controllers
{
    public class ProductController : Controller
    {
        public IActionResult Index(string category,int id)
        {
            ViewBag.Category = category;
            ViewBag.Id = id;
            return View();
        }
    }
}
