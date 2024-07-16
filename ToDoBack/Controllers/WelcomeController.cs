using Microsoft.AspNetCore.Mvc;

namespace ToDoBack.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class WelcomeController : ControllerBase
    {
        public WelcomeController()
        {

        }

        [HttpGet]
        public async Task<string> Get()
        {
            return $"The ToDo Welcome";
        }
    }
}
