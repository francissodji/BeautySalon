using System;
using System.Collections.Generic;
using System.Text;

namespace BeautyLibrary.Models
{
    public class HairColorsModel
    {
        public int IdHairColor { get; set; }
        public int IdHair { get; set; }
        public int IdColor { get; set; }
        public float StockAlert { get; set; }
        public float StockSecurity { get; set; }
    }
}
