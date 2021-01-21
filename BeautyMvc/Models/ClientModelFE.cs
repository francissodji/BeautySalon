using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BeautyMvc.Models
{
    public class ClientModelFE
    {

        [Key]
        [BindProperty(SupportsGet = true)]
        public int IDClient { get; set; }

        [Required]
        [BindProperty]
        [DisplayName("First Name")]
        public string FnameClient { get; set; }

        [BindProperty]
        [DisplayName("Middle Name")]
        public string MnameClient { get; set; }

        [Required]
        [BindProperty]
        [DisplayName("Last Name")]
        public string LnameClient { get; set; }

        [Required]
        [BindProperty]
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

        [BindProperty]
        [DisplayName("County")]
        public string CountyClient { get; set; }

        [BindProperty]
        [DisplayName("Zip Code")]
        public string ZipCodeClient { get; set; }


        [BindProperty]
        [DisplayName("State")]
        public string StateClient { get; set; }

        public int IDUserClient { get; set; }

       
    }
}
