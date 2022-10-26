using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Swiggy_API.Core.IServices;
using Swiggy_API.Core.Services;
using Swiggy_API.DTO;
using Swiggy_API.Model;

namespace Swiggy_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly IRegistrationServices registrationservice;

        public UserController(IRegistrationServices _registrationservice)
        {
            this.registrationservice = _registrationservice;
        }
        [HttpGet]
        [Route("Read")]
        public List<UserModel> GetUsers()
        {
            return registrationservice.GetUsers();
        }
        [HttpPost]
        [Route("Login")]
        public string SignIn([FromBody] LogInDTO logInDTO)
        {
            return registrationservice.SignIn(logInDTO);
        }
        [HttpPost]
        [Route("Registration")]
        public string SignUp([FromBody] UserModel userModels)
        {
            return registrationservice.SignUp(userModels);
        }
        [HttpPut]
        [Route("Change Password or Email")]
        public string PutUser(int UserId, [FromBody] UserModel userModels)
        {
            return registrationservice.PutUser(UserId, userModels);

        }
    }
}
