using FitnessAppMVC.Data;
using FitnessAppMVC.Dto;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FitnessAppMVC.Managers
{
    public interface IUserManager 
    {
        Task<UserDto> GetSingleUserById(string id);
        Task<List<UserDto>> GetListOfUsers();
    }

    public class UserManager : IUserManager
    {
        private readonly ApplicationDbContext _dbContext;

        public UserManager(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
        }


        public async Task<UserDto> GetSingleUserById(string id) 
        {
            var user = await _dbContext.AppUsers.FirstOrDefaultAsync(u => u.Id == id);

            // AsNoTracking

            //TODO: вынести в маппер
            // https://metanit.com/sharp/mvc5/23.4.php
            return new UserDto
            {
                Email = user.Email,
                UserName = user.UserName,
                Id = user.Id
            };
        }

        public async Task<List<UserDto>> GetListOfUsers()
        {
            var users = await _dbContext.AppUsers.ToListAsync();

            // какой принцип тут нарушен?
            // https://metanit.com/sharp/mvc5/23.4.php
            return users.Select(u => new UserDto
            {
                Email = u.Email,
                UserName = u.UserName,
                Id = u.Id
            }).ToList();
        }
    }
}
