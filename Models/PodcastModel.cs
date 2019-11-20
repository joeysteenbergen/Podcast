using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Podcast.Models
{
    public class PodcastModel
    {
        public string Playlist { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public byte[] Image { get; set; }
        public DateTime CreationDate { get; set; }
        public int AgeRestriction { get; set; }
        public string AudioPath { get; set; }
    }
}
