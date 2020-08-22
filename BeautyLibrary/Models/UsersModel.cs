using System;
using System.Collections.Generic;
using System.Text;

namespace BeautyLibrary.Models
{
    public class UsersModel
    {
        public int IDUser { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public int Idprofil { get; set; }
        public DateTime Dateuserexpire { get; set; }
        public bool Connectstate { get; set; }
    }
}
