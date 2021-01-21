using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Mvc;
using System.ComponentModel;


namespace BeautyMvc.Models
{
    public class AppointmentModelFE
    {

        [Key]
        [BindProperty(SupportsGet = true)]
        public int IDClientAppoint { get; set; }

        [Required]
        [BindProperty]
        [DisplayName("Style")]
        public int IDStyleAppoint { get; set; }

        [Required]
        [BindProperty]
        [DisplayName("Size")]
        public int IdSizeAppoint { get; set; }

        [Required]
        [BindProperty]
        [DisplayName("Length")]
        public int IDLenghtstyle { get; set; }

        [Required]
        [BindProperty(SupportsGet = true)]
        [DisplayName("Date Appointment")]
        [DataType(DataType.Date)]
        public DateTime DateAppoint { get; set; } = DateTime.Now;

        [Required]
        [BindProperty]
        [DataType(DataType.Time)]
        [DisplayName("Beginning Time")]
        public DateTime BeginTimeAppoint { get; set; } //= DateTime.Now.ToString("h:mm:ss tt");

        [Required]
        [BindProperty]
        [DisplayName("Add Take Down?")]
        public bool AddTakeOffAppoint { get; set; }

        [Required]
        [BindProperty]
        [DisplayName("Type Of Service")]
        public char Typeservice { get; set; }

        public char StateAppoint { get; set; }


        [BindProperty]
        [DisplayName("Number Track")]
        public int NumberTrack { get; set; }

        [Required]
        [BindProperty]
        [DisplayName("Braider")]
        public int IDBraiderAppoint { get; set; }



        [Required]
        [BindProperty]
        [DisplayName("Related Owner")]
        public int IdBraiderOwner { get; set; }

        public enum TheYesNo
        { 

        }
    }
}