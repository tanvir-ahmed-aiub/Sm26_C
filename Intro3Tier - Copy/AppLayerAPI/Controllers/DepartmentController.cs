using BLL.Services;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace AppLayerAPI.Controllers
{
    [EnableCors("OpenAPI")]
    [Route("api/[controller]")]
    [ApiController]
    public class DepartmentController : ControllerBase
    {
        DepartmentService service;
        public DepartmentController(DepartmentService service) { 
            this.service = service;
        }
        
        [HttpGet("all")]
        public IActionResult All() {
            var data = service.All() ;// Call BLL
            return Ok(data);
        }
        //[HttpGet("all/students")]
        //public IActionResult AllStudents() {
        //    var data = service.GetwithStudent();

        //    return Ok(data);
        //}
        //[HttpGet("all/info")]
        //public IActionResult Students() { 
        //    var data = service.GetDepartmentInfos();
        //    return Ok(data);
        //}
    }
}
