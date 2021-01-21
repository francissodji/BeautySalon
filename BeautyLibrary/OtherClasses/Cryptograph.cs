using System;
using System.Collections.Generic;
using System.Text;

namespace BeautyLibrary.OtherClasses
{
    public class Cryptograph
    {
        public static string Hash(string theValue)
        {

            string valreturn = Convert.ToBase64String(System.Security.Cryptography.SHA256.Create()
                .ComputeHash(Encoding.UTF8.GetBytes(theValue)));

            return valreturn;
        }
    }
}
