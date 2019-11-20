using PodcastInterfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Podcast.Models
{
    public class UploadModel
    {
        public IEnumerable<PlaylistModel> Playlists { get; set; }
    }
}
