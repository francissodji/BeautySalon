using BeautyLibrary.Data;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BeautyMvc.Models;
using BeautyLibrary.OtherClasses;
using BeautyLibrary.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Authorization;
using System.Security.Claims;
using Microsoft.Extensions.Logging;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace BeautyMvc.Controllers
{
    public class UserController : Controller
    {

        private readonly ISqlDataConnect _database;
        /*
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly SignInManager<ApplicationUser> _signInManager;
        private readonly ILogger<UserController> _logger;

        
        public UserController(ISqlDataConnect database, 
                              UserManager<ApplicationUser> userManager,
                              SignInManager<ApplicationUser> signInManager,
                              ILogger<UserController> logger)

        */

        public UserController(ISqlDataConnect database)
        {
            _database = database;
            //_userManager = userManager;
            //_signInManager = signInManager;
            //_logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public IActionResult UserRegistration()
        {
            ViewBag.StateList = new SelectList(GetUSAStateList(), "IdState", "NameState");
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]

        //public async Task<IActionResult> UserRegistration(UsersModelFE UserMod)
        public IActionResult UserRegistration(UsersModelFE UserMod)
        {
            //bool status = false;
            //string message = "";
            //bool emailExist = false;

            //Model Validation
            if (ModelState.IsValid)
            {
                /*
                var user = new ApplicationUser
                {
                    UserNameUser = UserMod.UserName,
                    EmailUser = UserMod.EmailClient
                };
                */
                //verify email exist.

                #region
                /*
                switch (UserMod.Idprofil)
                {
                    //Administrator
                    case 1:
                        break;
                    //Owner
                    case 2:
                        break;

                    //Braider
                    case 3:
                        //emailExist = _database.IsClientEmailExist(UserMod.EmailClient);
                        break;

                    //Client
                    case 4:
                        emailExist = _database.IsClientEmailExist(UserMod.EmailClient);
                        break;

                    default:
                        break;
                }
                

                emailExist = _database.IsClientEmailExist(UserMod.EmailClient);

                if (emailExist == false)
                {
                    ModelState.AddModelError("EmailExist", "Email already exist.");
                    return View(UserMod);
                }

                */
                #endregion

                //Generate activation code
                #region Generate Activation Code
                UserMod.ActivationCode = Guid.NewGuid();
                #endregion

                //Password Hashing
                #region Password Hashing
                UserMod.Password = Cryptograph.Hash(UserMod.Password);
                UserMod.ConfirmPassword = Cryptograph.Hash(UserMod.ConfirmPassword);
                #endregion
                UserMod.IsEmailVerified = false;
                
                //Save to data0

                //Send Emaild
                /*
                var result = await _userManager.CreateAsync(user, UserMod.Password);
                if (result.Succeeded)
                {
                    var token = await _userManager.GenerateEmailConfirmationTokenAsync(user);

                    var confirmationLink = Url.Action("ConfirmEmail",
                                                      "User",
                                                      new { userId = user.Id, token = token },
                                                      Request.Scheme);

                    _logger.Log(LogLevel.Warning, confirmationLink);

                    if (_signInManager.IsSignedIn(User) && User.IsInRole("Admin"))
                    {
                        return RedirectToAction("List of User section here"," ---The Controller here---");//need list of user and controller as parameters
                    }

                    ViewBag.ErrorTitle = "Registration successful";
                    ViewBag.ErrorMessage = "Before you can login, please confirm your "+
                        "email, by clicking on the confirmation link we have emailed you";
                    return View("Error");
                }
                 
                */
                    //create the user
                _database.CreateUser(UserMod.UserName, 3, false);

                    //Get user id
                UsersModel theUserInfo = _database.UserGetAUserFromUsername(UserMod.UserName);

                //create the User Password
                DateTime CurrentDate = DateTime.Now;
                DateTime theFinalDate = GetFinalDate(CurrentDate, 364);
                _database.CreateTheWord(theUserInfo.IDUser, UserMod.Password, 0, CurrentDate.Date, theFinalDate.Date);

                
                //Create the client
                _database.CreateClient(UserMod.FnameClient,
                                       UserMod.MnameClient,
                                       UserMod.LnameClient,
                                       UserMod.CelClient,
                                       UserMod.PhoneClient,
                                       UserMod.DOBClient,
                                       UserMod.StreetClient,
                                       UserMod.CountyClient,
                                       UserMod.ZipCodeClient,
                                       UserMod.StateClient,
                                       UserMod.EmailClient,
                                       theUserInfo.IDUser);

            }

            return View();
        }

        //User Login
        #region User Log In

        [HttpGet]
        public IActionResult UserLogin()
        { 
            return View();
        }

        [HttpPost]
        public IActionResult UserLogin(LoginModelFE theUserMod)
        {
            if (ModelState.IsValid)
            {
                if (_database.VerifyUserName(theUserMod.UserName) && _database.VerifyUserPassWord(theUserMod.UserName, theUserMod.Password))
                {
                    //int RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier;

                return RedirectToAction("SetUpAppointment", "Appointment");
                }
                else
                {
                    ViewBag.ErrorMessage = "Username or password not correct";
                }
            }
            
            return View();
        }
        #endregion

        #region Error Message

        public IActionResult ErrorMessage()
        {
            
             
            return View("Error");
        }
        #endregion

        //UserLogout
        #region User LogOut
        public IActionResult UserLogOut()
        {
            RedirectToAction();
            return View();
        }
        #endregion
        public List<USAStates> GetUSAStateList()
        {
            var allUSStates = _database.GetListOfAllUSAStates();

            return allUSStates;
        }

        [NonAction]
        public DateTime GetFinalDate(DateTime theInitialDate, int numberOfDate)
        {
            DateTime finalDate;

            finalDate = theInitialDate.Date.AddDays(numberOfDate);

            return finalDate;
        }
    }
}
