using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PodcastBLL;
using PodcastDAL.Context.ContextInterface;

namespace Podcast.Controllers
{
    public class UploadController : Controller
    {
        private readonly IPodcastContext _podcastContext;
        private readonly IPlaylistContext _playlistContext;

        public UploadController(IPodcastContext podcastContext, IPlaylistContext playlistContext)
        {
            _podcastContext = podcastContext;
            _playlistContext = playlistContext;
        }

        public IActionResult Index()
        {
            ViewData["Username"] = HttpContext.Session.GetString("Username");
            return View();
        }

        [HttpPost]
        public ActionResult AddPlaylist(string PlaylistTitle, string PlaylistDescription, string PlaylistImage)
        {
            var uploadLogic = new Uploadlogic(_podcastContext, _playlistContext);
            int UserID = Convert.ToInt32(HttpContext.Session.GetInt32("UserID"));

            uploadLogic.AddPlaylist(UserID, PlaylistTitle, PlaylistDescription, PlaylistImage);
            return RedirectToAction("Index", "Upload");
        }
    }
}