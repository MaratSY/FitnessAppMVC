using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FitnessAppMVC.Models
{
    public class User
    {
        public ulong Id { get; set; }

        public string Login { get; set; }

        public string Password { get; set; }
        
        public byte Height { get; set; }

        public byte Weight { get; set; }

        public byte Age { get; set; }
    }
}
