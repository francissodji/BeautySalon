using System;
using System.Collections.Generic;
using System.Text;

namespace BeautyLibrary.Models
{
    public class DiscountModel
    {
        public int IDDiscount { get; set; }
        public string TitleDiscount { get; set; }
        public float RateDiscount { get; set; }
        public decimal CostDiscount { get; set; }
    }
}
