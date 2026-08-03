using IntroWebAPI.EF;
using IntroWebAPI.EF.Tables;
using IntroWebAPI.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Runtime.Intrinsics.X86;

namespace IntroWebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentController : ControllerBase
    {
        Sm26CContext db;
        public StudentController(Sm26CContext db)
        {
            this.db = db;
        }
        [HttpGet]
        public IActionResult Get() {
            var data = db.Students.ToList();
            return Ok(data);
        }
        [HttpGet("{id}")]
        public IActionResult Get(int id) {
            var data = db.Students.Find(id);
            return Ok(data);
        }
        [HttpGet("scholarship")]
        public IActionResult Sch() {
            var data = (from s in db.Students
                       where s.Cgpa >=3.75
                       select s).ToList();
            return Ok(data);
        }
        [HttpGet("probation")]
        public IActionResult Prob() {
            var data = (from s in db.Students
                        where s.Cgpa < 2.50
                        select s).ToList();
            return Ok(data);
        }

        [HttpPost("create")]
        public IActionResult Create(StudentModel s) {
            var st = new Student() {
                Name = s.Name,
                Cgpa = s.Cgpa,
                DeptId = s.DeptId,
            };

            db.Students.Add(st);
            db.SaveChanges();
            return Ok(st);
        }
    }
}
