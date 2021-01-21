using System;
using System.Collections.Generic;
using System.Text;

namespace BeautyLibrary.Models
{
    public class ExtratStyleModel
    {
        public int IDExtratStyle { get; set; }
        public int IDStyle { get; set; }
        public int IdSize { get; set; }
        public int IDExtrat { get; set; }
        public decimal CostExtra { get; set; }
        public decimal CostTouchUpExtra { get; set; }
        public decimal CostExtraSize { get; set; }
        public decimal CostBusyExtra { get; set; }
        public decimal CostHairDeductExtra { get; set; }
    }
}
