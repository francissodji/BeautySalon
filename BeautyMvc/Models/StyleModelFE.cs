using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BeautyMvc.Models
{
    public class StyleModelIF
    {
        [Key]
        [BindProperty(SupportsGet = true)]
        public int IDStyle { get; set; }

        [Required]
        [BindProperty]
        [DisplayName("Title Style")]
        public string DesigStyle { get; set; }

        [Required]
        [BindProperty]
        [DisplayName("Description")]
        public string DescriptStyle { get; set; }

        [BindProperty]
        [DisplayName("Hair Provided ?")]
        public bool HairProvStyle { get; set; }

        [Required]
        [BindProperty]
        [DisplayName("Cost Style")]
        public decimal CostStyle { get; set; }

        [Required]
        [BindProperty]
        [DisplayName("Take Off Cost")]
        public decimal PriceTakeOffHair { get; set; }

        [Required]
        [BindProperty]
        [DisplayName("Touch Up Cost")]
        public decimal CostTouchUp { get; set; }

        [Required]
        [BindProperty(SupportsGet = true)]
        [DisplayName("Picture Style")]
        public string PictureStyle { get; set; }

        [Required]
        [BindProperty(SupportsGet = true)]
        [DisplayName("Charge Type")]
        public string ChargeType { get; set; }

        [Required]
        [BindProperty(SupportsGet = true)]
        [DisplayName("Braiding Duration")]
        public float TimeDoneStyle { get; set; }

        [Required]
        [BindProperty(SupportsGet = true)]
        [DisplayName("Modify Cost ?")]
        public bool ModifyCostManu { get; set; }

        [Required]
        [BindProperty(SupportsGet = true)]
        [DisplayName("Cost Hair Detuct")]
        public decimal CostHairDeducted { get; set; }

        public IFormFile Picture { get; set; }


        /*
       public enum YesNo
       { 
           Yes,
           No
       }

       public enum TheTypeCost
       { 
           CS,
           CT
       }
       */
    }
}
