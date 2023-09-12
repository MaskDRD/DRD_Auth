using auth.DTO;
using auth.Model;
using auth.Service;
using Microsoft.AspNetCore.Mvc;

namespace auth.Controllers
{
    [ApiController]
    [Route("api/user")]
    public class UserController : ControllerBase
    {
        private readonly ILogger<UserController> logger;
        private readonly UserServer userServer;
        public UserController(
            ILogger<UserController> logger,
            UserServer userServer
            )
        {
            this.logger = logger;
            this.userServer = userServer;
        }

        [Route("get/${id}")]
        [HttpGet()]
        public UserModel GetId(int id)
        {
            Console.WriteLine(id);
            return userServer.getUser(id);
        }
    }
}
