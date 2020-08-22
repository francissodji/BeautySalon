using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BeautyLibrary.Data;
using BeautyLibrary.Models;
using BeautyMvc.Models;
using Microsoft.AspNetCore.Mvc;


namespace BeautyMvc.Controllers
{
    public class LengthController : Controller
    {
        private readonly ISqlDataConnect _database;


        public LengthController(ISqlDataConnect database)
        {
            _database = database;
        }

        //Create Length
        public IActionResult CreateLength(LengthModelFE TheLengthModel)
        {
            if (ModelState.IsValid)
            {
                _database.ExtratAdd(TheLengthModel.TitleExtrat);
                return RedirectToAction();
            }
            
            return View();
        }

        //List of Length
        public IActionResult EditAllLength()
        {
            var AllLengthFromDB = _database.ExtratGetListAllExtrat();

            List<LengthModelFE> TheLenghToDisplay = new List<LengthModelFE>();

            foreach (var length in AllLengthFromDB)
            {
                TheLenghToDisplay.Add( new LengthModelFE
                {
                    IDExtrat = length.IDExtrat,
                    TitleExtrat = length.TitleExtrat
                });
            }
            return View(TheLenghToDisplay);
        }

        //Edit the length
        public IActionResult EditLength(int Id)
        {
            if (Id > 0)
            {
                var theLengthFromDB = _database.ExtratGetOneExtrat(Id);

                LengthModelFE theLengthToDisplay = new LengthModelFE();

                theLengthToDisplay.IDExtrat = theLengthFromDB.IDExtrat;
                theLengthToDisplay.TitleExtrat = theLengthFromDB.TitleExtrat;
                
                return View(theLengthToDisplay);
            }
            return View();
        }

        public IActionResult DetailLength(int Id)
        {
            if (Id > 0)
            {
                var theLengthFromDB = _database.ExtratGetOneExtrat(Id);

                return View(theLengthFromDB);
            }
            return View();
        }



        public IActionResult Index()
        {
            return View();
        }
    }
}
