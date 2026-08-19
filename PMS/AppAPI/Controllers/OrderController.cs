using BLL.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace AppAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OrderController : ControllerBase
    {
        [HttpPost("place")]
        public IActionResult PlaceOrder(OrderPlaceModel model) {
            return Ok();
        }


    }
}
