using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using BeautyLibrary.Data;
using BeautyMvc.Models;


namespace BeautyMvc.Controllers
{
    public class ClientController : Controller
    {

        private readonly ISqlDataConnect _database;


        public ClientController(ISqlDataConnect database)
        {
            _database = database;
        }


        public IActionResult CreateClient(ClientModelFE ClientMod)
        {
            if (ModelState.IsValid)
            {
                //_database.
            }
            return View();
        }

        public IActionResult Index()
        {
            return View();
        }
    }
}
