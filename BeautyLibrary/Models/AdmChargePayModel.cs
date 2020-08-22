using System;
using System.Collections.Generic;
using System.Text;

namespace BeautyLibrary.Models
{
    public class AdmChargePayModel
    {
        public int IdAdmchargePay { get; set; }
        public int IdAdmcharge { get; set; }
        public decimal CostChargePay { get; set; }
        public DateTime DatePayment { get; set; }
        public int IdTypeOperat { get; set; }
    }
}
