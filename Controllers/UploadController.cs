using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Podcast.Models;
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
            var uploadLogic = new Uploadlogic(_podcastContext, _playlistContext);
            var userID = Convert.ToInt32(HttpContext.Session.GetInt32("UserID"));
            var viewmodel = new UploadModel();

            var playlists = new List<PlaylistModel>();

            foreach (var playlist in uploadLogic.GetAllPlaylistByUserID(userID))
            {
                playlists.Add(new PlaylistModel
                {
                    Title = playlist.Title,
                    Description = playlist.Description,
                    Image = playlist.Image
                });
            }

            viewmodel.Playlists = playlists;
            return View(viewmodel);
        }

        [HttpPost]
        public ActionResult AddPlaylist(string PlaylistTitle, string PlaylistDescription, IFormFile PlaylistImage)
        {
            var uploadLogic = new Uploadlogic(_podcastContext, _playlistContext);
            var userID = Convert.ToInt32(HttpContext.Session.GetInt32("UserID"));
            byte[] image = null;

            if (PlaylistImage.Length > 0)
            {
                using (var rs = PlaylistImage.OpenReadStream())
                using (var ms = new MemoryStream())
                {
                    rs.CopyTo(ms);
                    image = ms.ToArray();
                }
            }

            uploadLogic.AddPlaylist(userID, PlaylistTitle, PlaylistDescription, image);
            return RedirectToAction("Index", "Upload");
        }
    }
}