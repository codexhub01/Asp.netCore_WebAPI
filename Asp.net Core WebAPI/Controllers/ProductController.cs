using Microsoft.AspNetCore.Mvc;

namespace Asp.net_Core_WebAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ProductController : ControllerBase
    {
        [HttpGet]
        public IActionResult GetProducts()
        {
            return Ok("Product returned");
        }
    }
}