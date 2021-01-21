using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using BeautyLibrary.Data;
using BeautyLibrary.Models;
using BeautyMvc.Models;


namespace BeautyMvc.Controllers
{
    public class ClientController : Controller
    {
        /*
        private readonly ISqlDataConnect _database;


        public ClientController(ISqlDataConnect database)
        {
            //_database = database;
        }
        */
        [HttpGet]
        public IActionResult ClientRegistration()
        {
            return View();
        }

        
    }
}
