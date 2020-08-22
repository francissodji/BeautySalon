using System;
using System.Collections.Generic;
using System.Text;

namespace BeautyLibrary.Models
{
    public class SalesModel
    {
        public int IDSale { get; set; }
        public string RefSale { get; set; }
        public DateTime DateSale { get; set; }
        public int IdJobDone { get; set; }
    }
}
