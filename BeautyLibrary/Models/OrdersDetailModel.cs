using System;
using System.Collections.Generic;
using System.Text;

namespace BeautyLibrary.Models
{
    public class OrdersDetailModel
    {
        public int IDOrderDetail { get; set; }
        public int IDOrder { get; set; }
        public int IDProd { get; set; }
        public float QttyOrder { get; set; }
        public decimal UnitPrice { get; set; }
        public int IDHair { get; set; }
        public int IDColor { get; set; }
    }
}
