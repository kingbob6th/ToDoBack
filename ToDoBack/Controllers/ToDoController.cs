using Microsoft.AspNetCore.Mvc;
using ToDoBack.Data;
using ToDoBack.Models;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace ToDoBack.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ToDoController : ControllerBase
    {
        private readonly ApplicationDbContext _context;
        
        public ToDoController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: api/<ToDoController>
        [HttpGet]
        public IActionResult Get()
        {
            return Ok(_context.ToDos.ToList());
        }

        // GET api/<ToDoController>/5
        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            return Ok(_context.ToDos.ToList().FirstOrDefault(x => x.ToDoId == id));
        }

        // POST api/<ToDoController>
        [HttpPost]
        public async Task<OkObjectResult> Post([FromBody] ToDo toDo)
        {
            _context.ToDos.Add(toDo);
            await _context.SaveChangesAsync();
            return Ok("success");
        }

        // PUT api/<ToDoController>/5
        [HttpPut("{id}")]
        public async Task<OkObjectResult> Put(int id, [FromBody] ToDo toDo)
        {
            _context.ToDos.Update(toDo);
            await _context.SaveChangesAsync();
            return Ok("success");
        }

        // DELETE api/<ToDoController>/5
        [HttpDelete("{id}")]
        public async Task<OkObjectResult> Delete(int id)
        {
            var toDo = _context.ToDos.ToList().Single(x => x.ToDoId == id);
            _context.ToDos.Remove(toDo);
            await _context.SaveChangesAsync();
            return Ok("success");
        }
    }
}
