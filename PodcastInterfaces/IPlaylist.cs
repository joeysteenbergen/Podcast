using System;
using System.Collections.Generic;
using System.Text;

namespace PodcastInterfaces
{
    public interface IPlaylist
    {
        int ID { get; set; }
        int UserID { get; set; }
        string Title { get; set; }
        string Description { get; set; }
        byte[] Image { get; set; }
    }
}
