using auth.Model;
using Microsoft.AspNetCore.Mvc;
using auth;
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
            authService.Register(userDtoCreated);
            return "�����������";
        }

        [Route("authorization")]
        [HttpPost()]
        public string Authorization()
        {
            return "�����������";
        }

        [Route("authentication")]
        [HttpPost()]
        public string Authentication()
        {
            return "��������������";
        }

        [Route("exit")]
        [HttpPost()]
        public string Exit()
        {
            return "����� �� ������";
        }

        [Route("conf/email/{id}")]
        [HttpGet()]
        public string ConfEmail()
        {
            return "���������� ������";
        }
    }
}