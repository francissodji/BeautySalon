using System;
using System.Collections.Generic;
using System.Text;

namespace BeautyLibrary.Models
{
    public class ClientModel
    {
        public int IDClient { get; set; }
        public string FnameClient { get; set; }
        public string MnameClient { get; set; }
        public string LnameClient { get; set; }
        public string PhoneClient { get; set; }
        public DateTime DOBClient { get; set; }
        public string CelClient { get; set; }
        public string StreetClient { get; set; }
        public string CountyClient { get; set; }
        public string ZipCodeClient { get; set; }
        public string EmailClient { get; set; }
        public int IDUserClient { get; set; }
        public string StateClient { get; set; }
    }
}
