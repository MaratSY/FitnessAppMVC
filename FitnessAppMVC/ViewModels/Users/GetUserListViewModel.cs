using FitnessAppMVC.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FitnessAppMVC.ViewModels.Users
{
    public class GetUserListViewModel
    {
        public IEnumerable<UserDto> Users { get; set; }
    }
}
