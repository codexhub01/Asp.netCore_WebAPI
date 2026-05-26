using Microsoft.AspNetCore.Mvc;

namespace Asp.net_Core_WebAPI.Controllers
{
    //These both need to mentioned for api
    [ApiController]
    [Route("api/[controller]")]
    public class ProductController : ControllerBase
    {
        [HttpGet]
        public IActionResult GetProducts()
        {
            return Ok("Product returned from getproducts method");
        }
    }
}