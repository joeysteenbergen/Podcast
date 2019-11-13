using PodcastInterfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Podcast.Models
{
    public class ManageModel
    {
        public IEnumerable<PlaylistModel> Playlists { get; set; }
        public IEnumerable<PodcastModel> Podcasts { get; set; }
    }
}
