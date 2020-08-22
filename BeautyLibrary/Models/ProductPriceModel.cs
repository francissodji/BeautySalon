using System;
using System.Collections.Generic;
using System.Text;

namespace BeautyLibrary.Models
{
    public class ProductPriceModel
    {
        public int IdProdPrice { get; set; }
        public int IdProd { get; set; }
        public decimal SalePrice { get; set; }
        public float SaleTax { get; set; }
    }
}
