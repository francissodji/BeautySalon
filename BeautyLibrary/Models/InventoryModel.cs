using System;
using System.Collections.Generic;
using System.Text;

namespace BeautyLibrary.Models
{
    public class InventoryModel
    {
        public int IDInvent { get; set; }
        public string RefInvent { get; set; }
        public DateTime DateInvent { get; set; }
        public string DescriptInvent { get; set; }
        public string StateInvent { get; set; }
    }
}
