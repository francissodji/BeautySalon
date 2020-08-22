using System;
using System.Collections.Generic;
using System.Text;

namespace BeautyLibrary.Models
{
    public class JobConsumptionModel
    {
        public int IDJobConsump { get; set; }
        public int IDJobDone { get; set; }
        public int IDHair { get; set; }
        public int IDColor { get; set; }
        public float QttyPacks { get; set; }
        public bool HairProvided { get; set; }
    }
}
