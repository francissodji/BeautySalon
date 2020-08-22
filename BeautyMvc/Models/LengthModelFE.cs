using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BeautyMvc.Models
{
    public class LengthModelFE
    {
        [Key]
        [BindProperty(SupportsGet = true)]
        public int IDExtrat { get; set; }

        [Required]
        [DisplayName("Length")]
        public string TitleExtrat { get; set; }

        
    }
}
