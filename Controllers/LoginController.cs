using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
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
        public ActionResult Login(string username, string password)
        {
            var userLogic = new Userlogic(_personContext);

            foreach (var user in userLogic.GetAllUsers())
            {
                if (user.Username == username && user.Password == password)
                {

                    HttpContext.Session.SetString("Username", user.Username);

                    return RedirectToAction("Index", "Home");
                }
            }

            ModelState.AddModelError("LogOnError", "The username or password provided is incorrect.");
            return View("Index");
        }

        [HttpPost]
        public ActionResult Register(string username, string password, string firstname, string lastname, DateTime dateOfBirth, string email)
        {
            var userLogic = new Userlogic(_personContext);

            userLogic.AddUser(username, password, firstname, lastname, dateOfBirth, email, DateTime.Now);
            return RedirectToAction("Index", "Home");
        }
    }
}