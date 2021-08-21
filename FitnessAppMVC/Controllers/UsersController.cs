using FitnessAppMVC.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FitnessAppMVC.Controllers
{
    [ApiController]
    [Route("users")]
    public class UsersController : Controller
    {
        private readonly ApplicationDbContext _dbContext;

        public UsersController(
            ApplicationDbContext dbContext
            )
        {
            _dbContext = dbContext;
        }

        [HttpGet("{id}")]
        //[AllowAnonymous]
        public async Task<IActionResult> Get(string id)
        {
            var user = await _dbContext.Users.Where(u => u.Id == id).FirstOrDefaultAsync();
            //return Json(user);

            return View("GetUser", user);
        }
    }
}
