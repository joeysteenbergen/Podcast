using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Podcast.Models;

namespace Podcast.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            ViewData["Username"] = HttpContext.Session.GetString("Username");
            return View();
        }
    }
}
