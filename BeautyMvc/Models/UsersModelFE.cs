using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using Microsoft.AspNetCore.Mvc;

namespace BeautyMvc.Models
{
    public class UsersModelFE
    {
        public int IDUser { get; set; }
        
        public int Idprofil { get; set; }

        public bool Connectstate { get; set; }

        [DisplayName("E-mail")]
        [DataType(DataType.EmailAddress)]
        [Required(AllowEmptyStrings = false, ErrorMessage = "Email is required.")]
        public string EmailClient { get; set; }

        [Required(AllowEmptyStrings = false, ErrorMessage = "Username is required.")]
        [DisplayName("Username")]
        public string UserName { get; set; }

        [Required(AllowEmptyStrings = false, ErrorMessage = "Password is required.")]
        [DisplayName("Password")]
        [DataType(DataType.Password)]
        [MinLength(6, ErrorMessage = "Minimum of 6 characters are required")]
        public string Password { get; set; }


        [DisplayName("Confirm Password")]
        [DataType(DataType.Password)]
        [Compare("Password", ErrorMessage = "Confirm password and password do not match.")]
        public string ConfirmPassword { get; set; }

        [Required(AllowEmptyStrings = false, ErrorMessage = "First name is required.")]
        [DisplayName("First Name")]
        public string FnameClient { get; set; }

        [DisplayName("Middle Name")]
        public string MnameClient { get; set; }

        [Required(AllowEmptyStrings = false, ErrorMessage = "Last name is required.")]
        [DisplayName("Last Name")]
        public string LnameClient { get; set; }

        [Required]
        [DisplayName("First Phone Number")]
        public string CelClient { get; set; }

        [Required]
        [BindProperty]
        [DisplayName("Second Phone Number")]
        public string PhoneClient { get; set; }


        [BindProperty]
        [DisplayName("Date Of Birth")]
        [DataType(DataType.DateTime)]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:MM/dd/yyyy}")]
        public DateTime DOBClient { get; set; }

        [BindProperty]
        [DisplayName("Street Address")]
        public string StreetClient { get; set; }

        
        [DisplayName("County")]
        public string CountyClient { get; set; }

        
        [DisplayName("Zip Code")]
        public string ZipCodeClient { get; set; }


        [DisplayName("State")]
        public string StateClient { get; set; }


        public Nullable<System.DateTime> Dateuserexpire { get; set; }

        public System.Guid ActivationCode { get; set; }

        public bool IsEmailVerified { get; set; }
    }
}
