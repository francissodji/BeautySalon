using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;

namespace BeautyMvc.Models
{
    public class ApplicationUser:IdentityUser
    {
        public string UserNameUser { get; set; }
        public string EmailUser { get; set; }
    }
}
