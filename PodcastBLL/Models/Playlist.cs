using PodcastInterfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace PodcastBLL.Models
{
    class Playlist : IPlaylist
    {
        public int ID { get; set; }
        public int UserID { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public byte[] Image { get; set; }
    }
}
