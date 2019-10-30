using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
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
                    HttpContext.Session.SetString("Id", user.ID.ToString());
                    HttpContext.Session.SetString("Username", user.Username);

                    return RedirectToAction("Index", "Home");
                }
            }

            ModelState.AddModelError("LogOnError", "The username or password provided is incorrect.");
            return RedirectToAction("Index", "Home");
        }

        [HttpPost]
        public ActionResult Register(UserModel model)
        {
            /*string registerUsername, string registerPassword, string firstname, string lastname, string dateOfBirth, string email*/
            var userLogic = new Userlogic(_personContext);

            userLogic.AddUser(model.Username, model.Password, model.Firstname, model.Lastname, model.DateOfCreation, model.Email, DateTime.Now.Date);
            return RedirectToAction("Index", "Home");
        }
    }
}