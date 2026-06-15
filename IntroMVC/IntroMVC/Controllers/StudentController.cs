using Microsoft.AspNetCore.Mvc;

namespace IntroMVC.Controllers
{
    public class StudentController : Controller
    {
        public IActionResult List() {
            int sum =0;
            for (int i = 1; i <= 10; i++) {
                sum += i;
            }


            return View();
        }
        public IActionResult Create() {
            return View();
        }
        public IActionResult Login() {
            return View();
        }
        public IActionResult SignUp() {
            return View();
        }
        public IActionResult Details(string id)
        {
            return View();
        }
}}
