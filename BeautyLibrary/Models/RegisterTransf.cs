using System;
using System.Collections.Generic;
using System.Text;

namespace BeautyLibrary.Models
{
    public class RegisterTransf
    {
        public int IDRegistTransf { get; set; }
        public DateTime DateTransf { get; set; }
        public decimal AmountTransf { get; set; }
        public int IDRegisterSender { get; set; }
        public int IDRegisterReceiver { get; set; }
    }
}
