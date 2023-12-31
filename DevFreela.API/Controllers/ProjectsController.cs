using Microsoft.AspNetCore.Mvc;
using DevFreela.API.Models;

namespace DevFreela.API.Controllers
{
    [Route("api/projects")]
    public class ProjectsController : ControllerBase
    {
        [HttpGet]
        public IActionResult Get(string query)
        {
            return Ok();
        }

        [HttpGet("{id}")]
        public IActionResult GetById(int id)
        {
            return Ok();
            // return NotFound();
        }

        [HttpPost]
        public IActionResult Post([FromBody] object teste)
        {
            return Ok();
            // return BadRequest();
        }

        [HttpPut("{id}")]
        public IActionResult Put(int id, [FromBody] object teste)
        {
            return Ok();
            // return BadRequest();
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            return Ok();
            // return NoContent();
        }

        [HttpPost("{id}/comments")]
        public IActionResult PostComment(int id, [FromBody] object commentModel)
        {
            return NoContent();
        }
        [HttpPost("{id}/start")]
        public IActionResult Start(int id)
        {
            return NoContent();
        }

        [HttpPost("{id}/finish")]
        public IActionResult Finish(int id)
        {
            return NoContent();
        }
    }
}