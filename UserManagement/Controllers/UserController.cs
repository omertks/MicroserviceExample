using Entity.Models;
using Microsoft.AspNetCore.Mvc;
using UserManagement.Services.Abstracts;
using UserManagement.Services.Concrate;

namespace UserManagement.Controllers
{
    [Route("api/[controller]")]
    public class UserController : Controller
    {
        private readonly IUserService _userService;

        public UserController()
        {
            _userService = new UserService();
        }

        [HttpGet]
        public IActionResult GetUserList()
        {
            return Ok(_userService.GetUserList());
        }

        //[HttpPost]
        //public async Task<IActionResult> CreateUser(User user)
        //{
        //    await _userService.CreateUserAsync(user);

        //    return Created("s","a");
        //}
    }
}
