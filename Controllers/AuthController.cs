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