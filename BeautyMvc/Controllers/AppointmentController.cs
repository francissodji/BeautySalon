using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BeautyLibrary.Data;
using Microsoft.AspNetCore.Mvc;
using BeautyMvc.Models;
using BeautyLibrary.Models;
using Microsoft.AspNetCore.Mvc.Rendering;

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
            ViewBag.StyleList = new SelectList(GetStyleList(), "IDStyle", "DesigStyle");

            if (ModelState.IsValid)
            {
                if (AppointMod.IDClientAppoint > 0)
                {
                    AppointMod.StateAppoint = 'N';

                    _database.SetNewAppointment(AppointMod.IDClientAppoint, AppointMod.IDStyleAppoint, AppointMod.IDLenghtstyle,
                    AppointMod.DateAppoint, AppointMod.BeginTimeAppoint, AppointMod.AddTakeOffAppoint,
                    AppointMod.StateAppoint, AppointMod.Typeservice, AppointMod.NumberTrack, AppointMod.IDBraiderAppoint,
                    AppointMod.IdSizeAppoint, AppointMod.IdBraiderOwner);
                }
            }
            return View();
        }


        //Cascading***************************
        public List<StyleModel> GetStyleList()
        {
            var AllStyleFromDB = _database.StyleGetList();

            return AllStyleFromDB;
        }


        public IActionResult GetAllSizePerStyle(int theIdStyle)
        {
            try
            {
                var AllSizePerStylefromDB = _database.SizePerStyleGetAllList(theIdStyle);
                ViewBag.SizeDDList = new SelectList(AllSizePerStylefromDB, "IdSize", "TitleSize");
            }
            catch (Exception ex)
            {

                throw ex;
            }
            
            return PartialView("DisplaySizeInStyle"); //DisplaySizeInStyle is the PartialView's name
        }

        public IActionResult GetAllLengthPerStyleAndSize(int theIdSize)
        {
            try
            {
                theIdSize = 13;
                List<ExtratModel> lengthAllFromDB = _database.LengthPerStyleAllList(theIdSize);
                    
                if (lengthAllFromDB.Count > 0)
                {
                    ViewBag.lengthDDList = new SelectList(lengthAllFromDB, "IdExtrat", "TitleExtrat");
                }
            }
            catch (Exception ex)
            {

                throw ex;
            }

            return PartialView("DisplayLengthInStyleAndSize");
        }

        //****************************************

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
                    StateAppoint = appoint.StateAppoint,
                    Typeservice = appoint.Typeservice,
                    NumberTrack = appoint.NumberTrack,
                    IDBraiderAppoint = appoint.IDBraiderAppoint,
                    IdSizeAppoint = appoint.IdSizeAppoint,
                    IdBraiderOwner = appoint.IdBraiderOwner
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
