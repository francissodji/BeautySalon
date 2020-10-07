using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BeautyLibrary.Data;
using Microsoft.AspNetCore.Mvc;
using BeautyMvc.Models;



namespace BeautyMvc.Controllers
{
    public class AppointmentController : Controller
    {
        private readonly ISqlDataConnect _database;


        public AppointmentController(ISqlDataConnect database)
        {
            _database = database;
        }


        public IActionResult SetUpAppointment(AppointmentModelFE AppointMod)
        {
            if (ModelState.IsValid)
            {
                if (AppointMod.IDClientAppoint > 0)
                {
                    AppointMod.StateAppoint = 'N';

                    _database.SetUpAppointment(AppointMod.IDClientAppoint, AppointMod.IDStyleAppoint, AppointMod.IDLenghtstyle,
                    AppointMod.DateAppoint, AppointMod.BeginTimeAppoint, AppointMod.AddTakeOffAppoint,
                    AppointMod.StateAppoint, AppointMod.Typeservice);
                }
            }
            return View();
        }

        public IActionResult ListAllActiveAppointForDate()
        {
            DateTime BeginDates = System.DateTime.Now;
            
            var AllAppointFromDB = _database.AppointGetListPerDate(BeginDates,1,'N');


            List<AppointmentModelFE> TheListAppoint = new List<AppointmentModelFE>();

            foreach (var appoint in AllAppointFromDB)
            {
                TheListAppoint.Add(new AppointmentModelFE
                {
                    IDClientAppoint = appoint.IDClientAppoint,
                    IDStyleAppoint = appoint.IDStyleAppoint,
                    IDLenghtstyle = appoint.IDLenghtstyle,
                    DateAppoint = appoint.DateAppoint,
                    BeginTimeAppoint = appoint.BeginTimeAppoint,
                    AddTakeOffAppoint = appoint.AddTakeOffAppoint,
                    StateAppoint = appoint.StateAppoint
                });
            }

            return View(TheListAppoint);
        }

        //
        public IActionResult ListAllStyle()
        {
            var AllStyleFromDB = _database.StyleGetList();

            List<StyleModelIF> TheListStyle = new List<StyleModelIF>();

            foreach (var style in AllStyleFromDB)
            {
                TheListStyle.Add(new StyleModelIF
                {
                    IDStyle = style.IDStyle,
                    DesigStyle = style.DesigStyle,
                    DescriptStyle = style.DescriptStyle,
                    HairProvStyle = style.HairProvStyle,
                    CostStyle = style.CostStyle,
                    PriceTakeOffHair = style.PriceTakeOffHair,
                    CostTouchUp = style.CostTouchUp,
                    PictureStyle = style.PictureStyle
                });
            }
            return View(TheListStyle);

        }
        
    }
}
