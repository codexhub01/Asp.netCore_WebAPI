using Microsoft.AspNetCore.Mvc;

namespace Asp.net_Core_WebAPI.Controllers
{
    [ApiController]
    [Route("api/controller")]
    public class HttpMethodController : ControllerBase
    {

        [HttpGet]
        public IActionResult GetMethod()
        {
            return Ok("This is get method");
        }

        [HttpGet("{id}")]
        public IActionResult GetDataByPara(int id)
        {
            return Ok("This is get method");
        }

        [HttpPost]
        public IActionResult CreateData(Employee employee)
        {
            return Created();
        }
    }
}
