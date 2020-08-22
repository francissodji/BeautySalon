using System;
using System.Collections.Generic;
using System.Text;

namespace BeautyLibrary.Models
{
    public class DeliveryModel
    {
        public int IDDelivery { get; set; }
        public int IDOrder { get; set; }
        public DateTime DateDelivery { get; set; }
    }
}
