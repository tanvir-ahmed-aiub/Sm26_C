using FormProcessing.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace FormProcessing.Controllers
{
    public class HomeController : Controller
    {
        [HttpGet]
        public IActionResult Login() { 
            
            return View();
        }
        [HttpPost]
        public IActionResult Login(string Uname, string Pass) {
            if (Uname == "tanvir" && Pass == "1234") {
                ViewBag.Msg = "Login Sucess";
            }
            else ViewBag.Msg = "Login Failed";
            return View();
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
