using System;
using System.Collections.Generic;
using System.Text;

namespace BeautyLibrary.Models
{
    public class OrdersModel
    {
        public int IDOrder { get; set; }
        public int IDVendor { get; set; }
        public DateTime DateOrder { get; set; }
        public string CategOrder { get; set; }
    }
}
