using Microsoft.AspNetCore.Mvc;
using MVCBasics.Models;


namespace MVCBasics.Controllers
{
    [Route("students")]
    public class StudentController : Controller
    {
        [Route("info")] //students/info
        public IActionResult Index()
        {
            Student[] students = new Student[10];
            for (int i = 1; i <= 10; i++) {
                students[i - 1] = new Student() { 
                    Id = i,
                    Name = "Student "+i
                };
            }
            ViewBag.Students = students;
            return View();
        }
        [Route("details/{name}/{id:int}")]
        public IActionResult Details(string name, int id) { 
            ViewBag.Name = name;
            ViewBag.Id = id;
            return View();
        }
        [Route("login")]
        public IActionResult Login() { 
            return View();
        }
    }
}
