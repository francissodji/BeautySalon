using System;
using System.Collections.Generic;
using System.Text;

namespace BeautyLibrary.Models
{
    public class AppointmentModel
    {
        public int IDAppoint { get; set; }

        public int IDClientAppoint { get; set; }

        public int IDStyleAppoint { get; set; }

        public int IDLenghtstyle { get; set; }

        public DateTime DateAppoint { get; set; }

        public DateTime BeginTimeAppoint { get; set; }

        public bool AddTakeOffAppoint { get; set; }

        public char StateAppoint { get; set; }

        public char Typeservice { get; set; }

        public int NumberTrack { get; set; }

        public int IDBraiderAppoint { get; set; }

        public int IdSizeAppoint { get; set; }

        public int IdBraiderOwner { get; set; }
    }
}
