using System;
using System.Collections.Generic;
using System.Text;

namespace BeautyLibrary.Models
{
    public class BraiderModel
    {
        public int IDBraider { get; set; }
        public string FnameBraider { get; set; }
        public string MnameBraider { get; set; }
        public string LnameBraider { get; set; }
        public string PhoneBraider { get; set; }
        public string CelBraider { get; set; }
        public string StreetBraider { get; set; }
        public string CountyBraider { get; set; }
        public string ZipCodeBraider { get; set; }
        public string EmailBraider { get; set; }
        public int IDUserBraider { get; set; }
        public bool OwnerStatus { get; set; }
        public bool IsBraiderUseRegister { get; set; }
        public bool IdRegisterBraider { get; set; }
        public string StateBraider { get; set; }
        public bool DisplayRegister { get; set; }
    }
}
