using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace WebApi_2022.Controllers
{


    [Route("/")]
    public class HealthController : ControllerBase
    {
        [AllowAnonymous]
        [HttpGet("health")]
        public IActionResult Health()
        {
            return Ok("ok");
        }

        [AllowAnonymous]
        [HttpGet("status")]
        public IActionResult Status()
        {
            return Ok("hello world");
        }

        [AllowAnonymous]
        [HttpGet("exit")]
        public IActionResult Exit()
        {
            this.Exit();
            return Ok("hello world");
        }

    }
}
