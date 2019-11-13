using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Session;
using Podcast.Models;
using PodcastBLL;
using PodcastDAL;
using PodcastInterfaces;

namespace Podcast.Controllers
{
    public class LoginController : Controller
    {
        private readonly IUserContext _personContext;

        public LoginController(IUserContext personContext)
        {
            _personContext = personContext;
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Login(string loginUsername, string loginPassword)
        {
            var userLogic = new Userlogic(_personContext);

            foreach (var user in userLogic.GetAllUsers())
            {
                if (user.Username == loginUsername && user.Password == loginPassword)
                {
                    HttpContext.Session.SetString("Username", user.Username);
                    HttpContext.Session.SetInt32("UserID", user.ID);

                    return RedirectToAction("Index", "Home");
                }
            }

            ModelState.AddModelError("LogOnError", "The username or password provided is incorrect.");
            return RedirectToAction("Index", "Login");
        }

        [HttpPost]
        public ActionResult Register(string registerUsername, string registerPassword, string firstname, string lastname, DateTime dateOfBirth, string email)
        {
            /*string registerUsername, string registerPassword, string firstname, string lastname, string dateOfBirth, string email*/
            var userLogic = new Userlogic(_personContext);

            userLogic.AddUser(registerUsername, registerPassword, firstname, lastname, dateOfBirth, email, DateTime.Now.Date);
            return RedirectToAction("Index", "Home");
        }

        public ActionResult Logout()
        {
            HttpContext.Session.Clear();
            return RedirectToAction("Index", "Login");
        }
    }
}