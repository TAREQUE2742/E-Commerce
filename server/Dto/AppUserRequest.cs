using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace E_Commerce.Dto
{
    public class AppUserRequest
    {
        public string Email { get; set; }
        public string FullName { get; set; }
        public string Password { get; set; }
        public string Gender { get; set; }
    }
}