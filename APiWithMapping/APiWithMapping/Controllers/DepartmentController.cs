using APiWithMapping.EF;
using APiWithMapping.Models;
using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace APiWithMapping.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DepartmentController : ControllerBase
    {
        Sm26CContext db;
        IMapper mapper;
        public DepartmentController(Sm26CContext db,IMapper mapper) { 
           this.db = db;
           this.mapper = mapper;
        }
        [HttpGet("all")]
        public IActionResult All() {
            var data = db.Departments.ToList();
            var mapped = mapper.Map<List<DepartmentModel>>(data);
            return Ok(mapped);
        }
        [HttpGet("{id}")]
        public IActionResult Get(int id) {
            var data = db.Departments.Find(id);
            var mapped = mapper.Map<DepartmentModel>(data);
            return Ok(mapped);

        }
    }
}
