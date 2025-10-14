using Microsoft.AspNetCore.Mvc;

namespace Api1// 👈 match your actual namespace (check Program.cs)
{
    [ApiController]
    [Route("[controller]")]
    public class HelloController : ControllerBase
    {
        [HttpGet]
        public IActionResult Get()
        {
            return Ok(new { message = "Hello from your first custom API endpoint!" });
        }
    }
}

