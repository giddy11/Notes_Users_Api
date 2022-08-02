using CCSA_WebApi.DTOs;
using CCSANoteApp.Infrastructure.Services;
using Microsoft.AspNetCore.Mvc;

namespace CCSA_WebApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class UsersController : ControllerBase
    {
        public IUserService UserService { get; }
        public UsersController(IUserService userService)
        {
            UserService = userService;
        }

        [HttpPost]
        public IActionResult CreateUser(string username, string email, string password)
        {
            UserService.CreateUser(username, email, password);
            return Ok("User Created Successfully");
        }

        [HttpPost("byUser")]
        public IActionResult CreateUser([FromBody] UserDto user)
        {
            UserService.CreateUser(user.Username, user.Email, user.Password);
            return Ok("User Created Successfully");
        }

        [HttpDelete("{id}")]
        public IActionResult DeleteUser(Guid id)
        {
            UserService.DeleteUser(id);
            return Ok("User Deleted Successfully");
        }

        [HttpGet("user/{id}")]
        //returns all the users
        public IActionResult GetUser(Guid id)
        {
            return Ok(UserService.GetUser(id));
        }

        [HttpGet]
        public IActionResult GetUsers()
        {
            return Ok(UserService.GetAllUsers());
        }

        [HttpPut("updateEmail")]
        public IActionResult UpdateEmail(Guid id, string email)
        {
            UserService.UpdateEmail(id, email);
            return Ok("Updated Successfully");
        }

        [HttpPut("updateName")]
        public IActionResult UpdateName(Guid id, string name)
        {
            UserService.UpdateName(id, name);
            return Ok("Updated Successfully");
        }
    }
}
