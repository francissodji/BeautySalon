using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BeautyMvc.Models
{
    public class LoginModelFE
    {
        [DisplayName("Username")]
        [Required(AllowEmptyStrings = false, ErrorMessage = "Password is required.")]
        public string UserName { get; set; }

        [DisplayName("Password")]
        [Required(AllowEmptyStrings =false,ErrorMessage ="Password is required.")]
        [DataType(DataType.Password)]
        public string Password { get; set; }
    }
}
