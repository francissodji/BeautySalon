using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using BeautyLibrary.Data;
using BeautyLibrary.Models;
using BeautyMvc.Models;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BeautyMvc.Controllers
{
    public class StyleController : Controller
    {
        private readonly ISqlDataConnect _database;

        [Obsolete]
        private readonly IHostingEnvironment _hostingEnvironment;

        [Obsolete]
        public StyleController(ISqlDataConnect database, 
                                IHostingEnvironment hostingEnvironment)
        {
            _database = database;
            _hostingEnvironment = hostingEnvironment;
        }

        [Obsolete]
        public IActionResult CreateStyle(StyleModelIF StyleMod)
        {
            
            if (ModelState.IsValid)
            {
                if (StyleMod.Picture != null)//Verify if there is a picture selected
                {
                    if (StyleMod.PictureStyle != null) //Verify if the picture name is there
                    {
                        string filePath = Path.Combine(_hostingEnvironment.WebRootPath, "images");
                        System.IO.File.Delete(filePath);
                    }

                    //PhotoStylePath = ProcessUploadedFile(StyleMod);
                }

                string uniqueFileName = ProcessUploadedFile(StyleMod);

                _database.StyleAdd(StyleMod.DesigStyle, StyleMod.DescriptStyle, StyleMod.HairProvStyle,
                                   StyleMod.CostStyle, StyleMod.PriceTakeOffHair, StyleMod.CostTouchUp, uniqueFileName);

                //int theIdOfNewStyle = _database.StyleGetInfoByTitle(StyleMod.DesigStyle); //This line is to retrieve the Style just inserted Id and pass it to RedirectToAction

                return RedirectToAction();
                //return RedirectToAction("DetailAStyle", new (d = theIdOfNewStyle.IDStyle));
            }

            return View();
        }

        [Obsolete]
        public IActionResult ModifyStyle(StyleModelIF StyleMod)
        {
            if (ModelState.IsValid)
            {
                if (StyleMod.Picture != null)//Verify if there is a picture selected
                {
                    if (StyleMod.PictureStyle != null) //Verify if the picture name is there
                    {
                        string filePath = Path.Combine(_hostingEnvironment.WebRootPath, "images");
                        System.IO.File.Delete(filePath);
                    }

                    //PhotoStylePath = ProcessUploadedFile(StyleMod);
                }

                string uniqueFileName = ProcessUploadedFile(StyleMod);

                _database.StyleModify(StyleMod.IDStyle, StyleMod.DesigStyle, StyleMod.DescriptStyle,
                                      StyleMod.HairProvStyle, StyleMod.CostStyle, StyleMod.PriceTakeOffHair,
                                      StyleMod.CostTouchUp, uniqueFileName);

                return RedirectToAction();
                //return RedirectToAction("DetailAStyle", new (d = theIdOfNewStyle.IDStyle));
            }
            return View();
        }

        public IActionResult DetailAStyle(int Id)
        {
            if (Id > 0)
            {
                var OneStyle = _database.StyleGetInfoById(Id);

                return View(OneStyle);
            }

            return View();
        }

        //Edit
        public IActionResult EditAStyle(int Id)
        {
            if (Id > 0)
            {
                var OneStyle = _database.StyleGetInfoById(Id);

                StyleModel AStyle = new StyleModel();

                AStyle.IDStyle = OneStyle.IDStyle;
                AStyle.DesigStyle = OneStyle.DesigStyle;
                AStyle.DescriptStyle = OneStyle.DescriptStyle;
                AStyle.HairProvStyle = OneStyle.HairProvStyle;
                AStyle.CostStyle = OneStyle.CostStyle;
                AStyle.PriceTakeOffHair = OneStyle.PriceTakeOffHair;
                AStyle.CostTouchUp = OneStyle.CostTouchUp;
                AStyle.PictureStyle = OneStyle.PictureStyle;

                return View(AStyle);
            }

            return View();
        }

        [Obsolete]
        private string ProcessUploadedFile(StyleModelIF TheModele)
        {
            string uniqueFileName = null;

            if (TheModele.Picture != null)
            {
                //_hostingEnvironment.WebRootPath == Provide the absolute path for wwwroot folder
                string uploadFolder = Path.Combine(_hostingEnvironment.WebRootPath, "images");

                //Guid = Global Uniq Identifier
                uniqueFileName = Guid.NewGuid().ToString() + "_" + TheModele.Picture.FileName;

                string FilePath = Path.Combine(uploadFolder, uniqueFileName);

                TheModele.Picture.CopyTo(new FileStream(FilePath, FileMode.Create));
            }
            return uniqueFileName;
        }
        

        //List of Style
        public IActionResult ListAllStyle()
        {
            var AllListStyle = _database.StyleGetList();

            List<StyleModel> TheListStyle = new List<StyleModel>();
            
            foreach (var style in AllListStyle)
            {
                TheListStyle.Add(new StyleModel
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
        public IActionResult Index()
        {
            return View();
        }
    }
}
