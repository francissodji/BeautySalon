using System;
using System.Collections.Generic;
using System.Text;

namespace BeautyLibrary.Models
{
    public class RegisterSatusModel
    {
        public int IdRegisterStatus { get; set; }
        public DateTime DateStatus { get; set; }
        public decimal TheoryBalance { get; set; }
        public decimal PhysicalBalance { get; set; }
        public string StateRegister { get; set; }
        public int IdRegister { get; set; }
    }
}
