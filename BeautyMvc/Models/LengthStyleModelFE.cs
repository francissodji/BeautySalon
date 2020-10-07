using BeautyLibrary.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace BeautyMvc.Models
{
    public class LengthStyleModelFE
    {
        [BindProperty(SupportsGet = true)]
        public int IDExtratStyle { get; set; }

        [Required]
        [DisplayName("Style")]
        [BindProperty(SupportsGet = true)]
        public int IDStyle { get; set; }

        [Required]
        [DisplayName("Length")]
        [BindProperty]
        public int IDExtrat { get; set; }

        [Required]
        [DisplayName("Cost Length")]
        [BindProperty]
        public decimal CostExtra { get; set; }

        [Required]
        [DisplayName("Cost Touch Up")]
        [BindProperty]
        public decimal CostTouchUpExtra { get; set; }

        public string DesignLength { get; set; }
        //public string DesignStyleShow { get; set; }
        //public string DescripStyleShow { get; set; }
    }
}
