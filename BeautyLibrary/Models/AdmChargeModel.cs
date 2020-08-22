using System;
using System.Collections.Generic;
using System.Text;

namespace BeautyLibrary.Models
{
    public class AdmChargeModel
    {
        public int IdAdmcharge { get; set; }
        public int IdPartener { get; set; }
        public decimal CostCharge { get; set; }
        public DateTime DateCharge { get; set; }
        public string DescriptCharge { get; set; }
    }
}
