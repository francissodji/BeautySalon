using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BeautyMvc.Models
{
    public class TheWordModelFE
    {
        public int IdPassword { get; set; }

        public int IdUsers { get; set; }

        public string UserPassword { get; set; }

        public int NumConnect { get; set; }

        public DateTime DateBeginPw { get; set; }

        public DateTime DateEndPw { get; set; }
    }
}
