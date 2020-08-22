using System;
using System.Collections.Generic;
using System.Text;

namespace BeautyLibrary.Models
{
    public class DeliveryDetailModel
    {
        public int IDDeliveryDetail { get; set; }
        public int IDDelivery { get; set; }
        public int IDProd { get; set; }
        public float QttyDelivery { get; set; }
        public int IDHair { get; set; }
        public int IDColor { get; set; }
    }
}
