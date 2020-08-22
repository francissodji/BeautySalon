using System;
using System.Collections.Generic;
using System.Text;

namespace BeautyLibrary.Models
{
    public class ClientRelationModel
    {
        public int IDClientRelation { get; set; }
        public int IdClientParent { get; set; }
        public int IdClientRelative { get; set; }
    }
}
