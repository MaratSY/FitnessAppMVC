using FitnessAppMVC.Managers;
using FitnessAppMVC.ViewModels.Users;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace FitnessAppMVC.Controllers
{
    [ApiController]     // ApiController должен содержать роуты и будет мапить по аттрибутам Route в контроллере и template в методах
    [Route("users")]    // нужен для ApiController

    //[Controller]      // Controller мапится по имени контроллеров и методов
    public class UsersController : Controller
    {
        private readonly IUserManager _userManager;

        public UsersController(
            IUserManager userManager
            )
        {
            _userManager = userManager;
        }


        [HttpGet("{id}")]   // для ApiController
        //[HttpGet]         // для Controller
        public async Task<IActionResult> GetSigleUser(string id)
        {
            var user = await _userManager.GetSingleUserById(id);
            var userViewModel = new GetSigleUserViewModel
            {
                User = user
            };

            return View("GetSigleUser", userViewModel);
        }


        [HttpGet("")]   // для ApiController
        //[HttpGet]     // для Controller
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
