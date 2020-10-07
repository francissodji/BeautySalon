using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BeautyLibrary.Databases;
using BeautyMvc.Models;
using Microsoft.AspNetCore.Identity.UI.V3.Pages.Internal.Account.Manage;
using Microsoft.AspNetCore.Mvc;
using BeautyLibrary.Data;
using BeautyLibrary.Models;
using StyleModel = BeautyLibrary.Models.StyleModel;

namespace BeautyMvc.Controllers
{
    public class LengthStyleController : Controller
    {
        private readonly ISqlDataConnect _database;

        public LengthStyleController(ISqlDataConnect database)
        {
            _database = database;
        }


        //Create to 
        public IActionResult CreateLengthForStyle(int Id, LengthStyleModelFE TheLengthForStyle)
        {
            //DD Length
            
            List<ExtratModel> ListLength;
            ListLength = _database.ExtratGetListAllExtrat();
            ViewBag.DdListLength = ListLength;

            //List<StyleModel> ListStyle;
            //ListStyle = _database.StyleGetList();
            //ViewBag.DdListStyle = ListStyle;
            

            if (ModelState.IsValid)
            {
                TheLengthForStyle.IDStyle = Id;
                if (TheLengthForStyle.IDStyle > 0 && TheLengthForStyle.IDExtrat > 0)
                {
                    _database.CreateLengthToStyle(TheLengthForStyle.IDStyle, TheLengthForStyle.IDExtrat, TheLengthForStyle.CostExtra, TheLengthForStyle.CostTouchUpExtra);
                    return RedirectToAction();
                }
            }
            return View();
        }


        //List of Extrat Style
        public IActionResult ListAllLengthStyle(int Id)
        {
            if (Id > 0)
            {
                var AllLenghtPerStyleAvail = _database.LengthStyleGetAllLengthPerStyle(Id);

                List<LengthStyleModelFE> TheLengthPerStyleDisplayFE = new List<LengthStyleModelFE>();

                foreach (var length in AllLenghtPerStyleAvail)
                {
                    var OneLength = _database.ExtratGetOneExtrat(length.IDExtrat);
                    var OneStyle = _database.StyleGetInfoById(length.IDStyle);

                    TheLengthPerStyleDisplayFE.Add(new LengthStyleModelFE
                    {
                        IDExtratStyle = length.IDExtratStyle,
                        IDStyle = length.IDStyle,
                        IDExtrat = length.IDExtrat,
                        CostExtra = length.CostExtra,
                        CostTouchUpExtra = length.CostTouchUpExtra,

                        DesignLength = OneLength.TitleExtrat
                        //DesignStyleShow = OneStyle.DesigStyle,
                        //DescripStyleShow = OneStyle.DescriptStyle
                    });
                }

                return View(TheLengthPerStyleDisplayFE);
            }
            return View();
        }

        //public List<ExtratModel> DDListOfLength { get; set; }


        public IActionResult DDAllLength()
        {
            var AllLengthFromDB = _database.ExtratGetListAllExtrat();

            ViewBag(AllLengthFromDB);

            return View();
        }
        

        public IActionResult Index()
        {
            return View();
        }
    }
}
