using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using BeautyLibrary.Data;
using BeautyLibrary;
using BeautyMvc.Models;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace BeautyMvc.Controllers
{
    public class DiscountController : Controller
    {

        private readonly ISqlDataConnect _database;


        public DiscountController(ISqlDataConnect database)
        {
            _database = database;
        }


       //Create
        public IActionResult CreateDiscount(DiscountModel modelDisc)
        {
            if (ModelState.IsValid)
            {
                _database.DiscountAdd(modelDisc.TitleDiscount, modelDisc.RateDiscount, modelDisc.CostDiscount);
                return RedirectToAction();
            }
            
            return View();
        }

        //Modify
        public IActionResult ModifyDiscount(DiscountModel modelDisc)
        {
            if (ModelState.IsValid)
            {
                _database.DiscountModify(modelDisc.IDDiscount,modelDisc.TitleDiscount,modelDisc.RateDiscount,modelDisc.CostDiscount);
                
                return RedirectToAction();
            }
            return RedirectToAction();
        }

        //Delete
        public IActionResult DeleteADiscount(int Id)
        {
            if (Id > 0)
            {
                //control if it is 
                _database.DiscountDelete(Id);
                return View();
            }
            return View();
        }

        //Edit For Delete
        public IActionResult EditDeleteDiscount(int Id)
        {
            if (Id > 0)
            {
                var OneDiscount = _database.DiscountGetById(Id);

                DiscountModel ADiscount = new DiscountModel();

                ADiscount.IDDiscount = OneDiscount.IDDiscount;
                ADiscount.TitleDiscount = OneDiscount.TitleDiscount;
                ADiscount.RateDiscount = OneDiscount.RateDiscount;
                ADiscount.CostDiscount = OneDiscount.CostDiscount;

                return View(ADiscount);
            }

            return View();
        }

        //Edit
        public IActionResult EditADiscount(int Id)
        {
            if (Id > 0)
            {
                var OneDiscount = _database.DiscountGetById(Id);

                DiscountModel ADiscount = new DiscountModel();

                ADiscount.IDDiscount = OneDiscount.IDDiscount;
                ADiscount.TitleDiscount = OneDiscount.TitleDiscount;
                ADiscount.RateDiscount = OneDiscount.RateDiscount;
                ADiscount.CostDiscount = OneDiscount.CostDiscount;

                return View(ADiscount);
            }

            return View();
        }

        //Detail 
        public IActionResult DetailADiscount(int Id)
        {
            if (Id > 0)
            {
                var OneDiscount = _database.DiscountGetById(Id);

                return View(OneDiscount);
            }

            return View();
        }
        
        //List of All Discount
        public IActionResult ListAllDiscount()
        {
            var AllDiscountAvail = _database.DiscountGetList();

            List<DiscountModel> TheDiscountList = new List<DiscountModel>();
            
            foreach (var discount in AllDiscountAvail)
            {
                TheDiscountList.Add(new DiscountModel
                {
                    IDDiscount = discount.IDDiscount,
                    TitleDiscount = discount.TitleDiscount,
                    RateDiscount = discount.RateDiscount,
                    CostDiscount = discount.CostDiscount
                });
            }

            return View(TheDiscountList);
        }

        


        public IActionResult Index()
        {
            return View();
        }
    }
}
