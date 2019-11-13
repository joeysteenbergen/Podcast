using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Podcast.Models;
using PodcastBLL;
using PodcastDAL;
using PodcastDAL.Context.ContextInterface;
using PodcastInterfaces;

namespace Podcast.Controllers
{
    public class ManageController : Controller
    {
        private readonly IPodcastContext _podcastContext;
        private readonly IPlaylistContext _playlistContext;

        public ManageController(IPodcastContext podcastContext, IPlaylistContext playlistContext)
        {
            _podcastContext = podcastContext;
            _playlistContext = playlistContext;
        }

        public IActionResult Index()
        {
            var uploadLogic = new Uploadlogic(_podcastContext, _playlistContext);
            var userID = Convert.ToInt32(HttpContext.Session.GetInt32("UserID"));
            var viewmodel = new ManageModel();

            var playlists = new List<PlaylistModel>();
            var podcasts = new List<PodcastModel>();

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

            foreach(var podcast in uploadLogic.GetAllPodcastByUserID(userID))
            {
                podcasts.Add(new PodcastModel
                {
                    Title = podcast.Title,
                    Description = podcast.Description,
                    Image = podcast.Image,
                    CreationDate = podcast.CreationDate,
                    AgeRestriction = podcast.AgeRestriction
                });
            }

            return View();
        }
    }
}