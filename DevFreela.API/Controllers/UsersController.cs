using Microsoft.AspNetCore.Mvc;

namespace DevFreela.API.Controllers
{
    [Route("api/users")]
    public class UsersController : ControllerBase
    {
        [HttpGet("{id}")]
        public IActionResult GetById(int id)
        {
            return Ok();
        }

        [HttpPost]
        public IActionResult Post([FromBody] object teste)
        {
            return CreatedAtAction(nameof(GetById), new { id = 1 }, teste);
        }
        
        [HttpPut("{id}/login")]
        public IActionResult Login(int id, [FromBody] object teste)
        {
            return NoContent();
        }
    }
}