using Microsoft.AspNetCore.Mvc;

namespace auth.Controllers
{
    [ApiController]
    [Route("api/auth")]
    public class AuthController : ControllerBase
    {
        private readonly ILogger<AuthController> _logger;

        public AuthController(ILogger<AuthController> logger)
        {
            _logger = logger;
        }

        [Route("register")]
        [HttpPost()]
        public string Register()
        {
            return "Регистрация";
        }

        [Route("authorization")]
        [HttpPost()]
        public string Authorization()
        {
            return "Авторизация";
        }

        [Route("authentication")]
        [HttpPost()]
        public string Authentication()
        {
            return "Аутентификация";
        }

        [Route("exit")]
        [HttpPost()]
        public string Exit()
        {
            return "Выйти из учетки";
        }

        [Route("conf/email/{id}")]
        [HttpGet()]
        public string ConfEmail()
        {
            return "Подвердить учетку";
        }
    }
}