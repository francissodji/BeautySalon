using System;
using System.Collections.Generic;
using System.Text;

namespace BeautyLibrary.Models
{
    public class StyleModel
    {
        public int IDStyle { get; set; }
        public string DesigStyle { get; set; }
        public string DescriptStyle { get; set; }
        public bool HairProvStyle { get; set; }
        public decimal CostStyle { get; set; }
        public string PictureStyle { get; set; }
        public decimal PriceTakeOffHair { get; set; }
        public decimal CostTouchUp { get; set; }
        public byte[] ImageStyle { get; set; }
    }
}
