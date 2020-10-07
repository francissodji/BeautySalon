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
        [DisplayName("Length")]
        public int IDLenghtstyle { get; set; }

        [Required]
        [BindProperty(SupportsGet = true)]
        [DisplayName("Date Appointment")]
        [DataType(DataType.Date)]
        public DateTime DateAppoint { get; set; } = DateTime.Now;

        [Required]
        [BindProperty]
        [DisplayName("Beginning Time")]
        public DateTime BeginTimeAppoint { get; set; } //= DateTime.Now.ToString("h:mm:ss tt");

        [Required]
        [BindProperty]
        [DisplayName("Will Require Take Off")]
        public bool AddTakeOffAppoint { get; set; }

        [Required]
        [BindProperty]
        [DisplayName("Type Of Service")]
        public char Typeservice { get; set; }

        public char StateAppoint { get; set; }
    }
}