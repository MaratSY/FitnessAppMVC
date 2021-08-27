using FitnessAppMVC.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FitnessAppMVC.ViewModels.Users
{
    public class GetSigleUserViewModel
    {
        // класс ViewModel может нести в себе дополнительные данные, необходимые для отрисовки чего-либо в Html или другом месте

        public UserDto User { get; set; }
    }
}
