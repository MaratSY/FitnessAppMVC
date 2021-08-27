using FitnessAppMVC.Managers;
using FitnessAppMVC.ViewModels.Users;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace FitnessAppMVC.Controllers
{
    [ApiController]
    [Route("users")]
    public class UsersController : Controller
    {
        private readonly IUserManager _userManager;

        public UsersController(
            IUserManager userManager
            )
        {
            _userManager = userManager;
        }


        [HttpGet("{id}")]
        //[AllowAnonymous]
        public async Task<IActionResult> GetSigleUser(string id)
        {
            var user = await _userManager.GetSingleUserById(id);
            var userViewModel = new GetSigleUserViewModel
            {
                User = user
            };

            return View("GetSigleUser", userViewModel);
        }


        [HttpGet("")]
        public async Task<IActionResult> GetUserList()
        {
            var users = await _userManager.GetListOfUsers();
            var usersViewModel = new GetUserListViewModel
            {
                Users = users
            };

            return View("GetUserList", usersViewModel);
        }
    }
}
