using Microsoft.AspNetCore.Mvc;

namespace Auth.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class AuthsController : ControllerBase
    {
      
        private readonly ILogger<AuthsController> _logger;
        IConfiguration _configuration;
        public AuthsController(ILogger<AuthsController> logger, IConfiguration configuration)
        {
            _logger = logger;
            _configuration = configuration;
        }

        [HttpPost(Name = "Login")]
        public IActionResult Login([FromBody] User login)
        {
            TokenHandler._configuration = _configuration;
            return Ok(login.userName == "azattekce" && login.password == "215454" ? TokenHandler.CreateAccessToken() : new UnauthorizedResult());
        }

        public class User
        {
            public string userName { get; set; }
            public string password { get; set; }
        }
    }
}