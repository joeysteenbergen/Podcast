using PodcastInterfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace PodcastBLL.Models
{
    class Podcast : IPodcast
    {
        public int ID { get; set; }
        public int PlaylistID { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string AudioPath { get; set; }
        public byte[] Image { get; set; }
        public DateTime CreationDate { get; set; }
        public int AgeRestriction { get; set; }
    }
}
