using IntroEFDbFirst.EF;
using IntroEFDbFirst.EF.Tables;
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
            var data = db.Students.ToList();
            return View(data);
        }
        public IActionResult Details(int id) {
            //searching with PK
            var data = db.Students.Find(id);
            return View(data);
        }
        [HttpGet]
        public IActionResult Edit(int id) { 
            var data = db.Students.Find(id);
            var dept = db.Departments.ToList();
            ViewBag.Depts = dept;
            return View(data);
        }
        [HttpPost]
        public IActionResult Edit(Student formObj) {
            var exObj = db.Students.Find(formObj.Id);
            //
            exObj.Name = formObj.Name;
            exObj.DeptId = formObj.DeptId;
            //
            //
            db.SaveChanges();
            return RedirectToAction("Index");
        }
        [HttpGet]
        public IActionResult Delete(int id) {
            var data = db.Students.Find(id);
            return View(data);
        }
        [HttpPost]
        public IActionResult Delete(string Dcsn, int id) {
            if (Dcsn == "Yes") {
                var data = db.Students.Find(id);
                db.Students.Remove(data);
                db.SaveChanges();
                
            }
            return RedirectToAction("Index");
        }
        public IActionResult Scholarship() { 
            var data = (from s in db.Students
                       where s.Cgpa >=3.75 && s.Id >=1 && s.Id <=5
                       select s).ToList();
            return View(data);
        }
    }
}
