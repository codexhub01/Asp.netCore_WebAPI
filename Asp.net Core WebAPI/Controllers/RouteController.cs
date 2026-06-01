using Microsoft.AspNetCore.Mvc;

namespace Asp.net_Core_WebAPI.Controllers
{
    [ApiController]
    [Route("api/controller")]
    public class RouteController : ControllerBase
    {
        [HttpGet("{id}")]
        public IActionResult M1(int id)
        {
            return Ok("Single parameter route");
        }

        [HttpGet("{id}/{name}")]
        public IActionResult M1(int id , string name)
        {
            return Ok("Multiple parameter route");
        }

        [HttpGet("{rollno:int}")]
        public IActionResult Route_Para_With_Constraints(int rollno)
        {
            return Ok("Route parameter with constraints");
        }

        [HttpGet("{name?}")]
        public IActionResult Get(string? name)
        {
            return Ok("Optional Route Parameter");
        }

    //    [HttpGet]
    //    public IActionResult Explicit_Query_String(
    //[FromQuery] int roleid)
    //    {
    //        return Ok("Explicit query string binding");
    //    }

        [HttpGet]
        public IActionResult Explicit_Route_Parameter(
    [FromQuery] int userid)
        {
            return Ok("Explicit route parameter binding");
        }
    }
}
