using Microsoft.AspNetCore.Mvc;
using auth.Service;
using auth.DTO;

namespace auth.Controllers
{
    [ApiController]
    [Route("api/auth")]
    public class AuthController : ControllerBase
    {
        private readonly ILogger<AuthController> logger;
        private readonly AuthService authService;

        public AuthController(ILogger<AuthController> logger, AuthService authService)
        {
            this.logger = logger;
            this.authService = authService;
        }

        [Route("register")]
        [HttpPost()]
        public string Register([FromBody] UserDtoCreated userDtoCreated)
        {
            Console.WriteLine("1");
            authService.Register(userDtoCreated);
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