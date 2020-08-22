using System;
using System.Collections.Generic;
using System.Text;

namespace BeautyLibrary.Models
{
    public class SalesDetailsModel
    {
        public int IDSaleDetail { get; set; }
        public int IDSale { get; set; }
        public int IDProd { get; set; }
        public decimal UnitPrice { get; set; }
        public float QttySale { get; set; }
    }
}
