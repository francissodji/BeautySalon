using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BeautyMvc.Models
{
    public class DiscountModel
    {
        [BindProperty(SupportsGet = true)]
        public int IDDiscount { get; set; }

        [Required]
        [BindProperty]
        [DisplayName("Title Discount")]
        public string TitleDiscount { get; set; }

        [Required]
        [BindProperty]
        [DisplayName("Rate Discount")]
        public float RateDiscount { get; set; }

        [Required]
        [BindProperty]
        [DisplayName("Cost Discount")]
        public decimal CostDiscount { get; set; }

    }
}
